using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManegmentHotelASystem
{
    public partial class Register : Form
    {

        String query;
        Function fn = new Function();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtNumber.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                String name = txtLogin.Text;
                Int64 mobile = Int64.Parse(txtNumber.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String username = txtUsername.Text;
                String password = HashPassword(txtPassword.Text);

                query = "insert into employee (ename,mobile,gender,emeailid,username,pass) values ('" + name + "' ," + mobile + ",'" + gender + "','" + email + "','" + username + "','" + password + "')";
                fn.SetData(query, "Employee Registered");
                clearAll();

               
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
            }
            else
            {
                MessageBox.Show("Fill all fields.", "Warning...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public void clearAll()
        {
            txtLogin.Clear();
            txtNumber.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public void SetRegisterButtonVisibility(bool isVisible)
        {
            registerBtn.Visible = isVisible;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
