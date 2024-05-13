using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace ManegmentHotelASystem
{

   
    public partial class Form1 : Form
    { Function fn = new Function();
    String query;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            String pass = txtPassword.Text;
            String hashedpass = HashPassword(pass);
            DataSet ds = new DataSet();
            if (VerifyPassword(pass, hashedpass) == true)
            {
                query = "select  username,pass from employee where username ='" + txtUsername.Text + "' and pass ='" + hashedpass + "' ";
                ds = fn.GetData(query);
            }


            if (ds.Tables[0].Rows.Count != 0)
            {
                labelError.Visible = false;
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
        }
        private bool VerifyPassword(string inputPassword, string hashedPassword)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Хешируем введенный пользователем пароль
                string hashedInputPassword = HashPassword(inputPassword);

                // Сравниваем хеши
                if (hashedInputPassword == hashedPassword)
                {
                    return true; // Пароли совпадают
                }
                else
                {
                    return false; // Пароли не совпадают
                }
            }
        }
          private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Хешируем пароль
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Преобразуем хеш в строку
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }
    }
}
