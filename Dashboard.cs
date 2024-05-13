using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManegmentHotelASystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdd_customer_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAddRoom.Left + 5;
            uC_AddRom1.Visible = true;
            uC_AddRom1.BringToFront();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Customer_Registration_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btn_Customer_Registration.Left +20;
            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRom1.Visible = false;
            uC_Employee1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            btnAddRoom.PerformClick();
        }

        private void UC_AddRom1_Load(object sender, EventArgs e)
        {

        }

        private void UC_AddRom2_Load(object sender, EventArgs e)
        {

        }

        private void Btn_CheckOut_Click(object sender, EventArgs e)
        {
            uC_CheckIn1.Visible = true;
            uC_CheckIn1.BringToFront();
        }

        private void Btn_CustomerDeteils_Click(object sender, EventArgs e)
        {
            customer_Details1.Visible = true;
            customer_Details1.BringToFront();
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }
    }
}
