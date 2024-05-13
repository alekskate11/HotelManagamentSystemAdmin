
namespace ManegmentHotelASystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btn_CustomerDeteils = new Guna.UI2.WinForms.Guna2Button();
            this.btn_CheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Customer_Registration = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_CheckIn1 = new ManegmentHotelASystem.All_Users_Control.UC_CheckIn();
            this.uC_CustomerRegistration1 = new ManegmentHotelASystem.All_Users_Control.UC_CustomerRegistration();
            this.uC_AddRom1 = new ManegmentHotelASystem.All_Users_Control.UC_AddRom();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.customer_Details1 = new ManegmentHotelASystem.All_Users_Control.Customer_Details();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Employee1 = new ManegmentHotelASystem.All_Users_Control.UC_Employee();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.MovingPanel);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btn_CustomerDeteils);
            this.panel1.Controls.Add(this.btn_CheckOut);
            this.panel1.Controls.Add(this.btn_Customer_Registration);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(77, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1779, 132);
            this.panel1.TabIndex = 0;
            // 
            // MovingPanel
            // 
            this.MovingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MovingPanel.Location = new System.Drawing.Point(41, 124);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(200, 5);
            this.MovingPanel.TabIndex = 5;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnEmployee.BorderRadius = 30;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnEmployee.CheckedState.Parent = this.btnEmployee;
            this.btnEmployee.CustomImages.Parent = this.btnEmployee;
            this.btnEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.Parent = this.btnEmployee;
            this.btnEmployee.Location = new System.Drawing.Point(982, 20);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.ShadowDecoration.Parent = this.btnEmployee;
            this.btnEmployee.Size = new System.Drawing.Size(232, 98);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.Click += new System.EventHandler(this.BtnEmployee_Click);
            // 
            // btn_CustomerDeteils
            // 
            this.btn_CustomerDeteils.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_CustomerDeteils.BorderRadius = 30;
            this.btn_CustomerDeteils.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_CustomerDeteils.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_CustomerDeteils.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_CustomerDeteils.CheckedState.Parent = this.btn_CustomerDeteils;
            this.btn_CustomerDeteils.CustomImages.Parent = this.btn_CustomerDeteils;
            this.btn_CustomerDeteils.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_CustomerDeteils.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerDeteils.ForeColor = System.Drawing.Color.White;
            this.btn_CustomerDeteils.HoverState.Parent = this.btn_CustomerDeteils;
            this.btn_CustomerDeteils.Image = ((System.Drawing.Image)(resources.GetObject("btn_CustomerDeteils.Image")));
            this.btn_CustomerDeteils.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CustomerDeteils.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_CustomerDeteils.Location = new System.Drawing.Point(744, 20);
            this.btn_CustomerDeteils.Name = "btn_CustomerDeteils";
            this.btn_CustomerDeteils.ShadowDecoration.Parent = this.btn_CustomerDeteils;
            this.btn_CustomerDeteils.Size = new System.Drawing.Size(232, 98);
            this.btn_CustomerDeteils.TabIndex = 3;
            this.btn_CustomerDeteils.Text = "Customer Details";
            this.btn_CustomerDeteils.Click += new System.EventHandler(this.Btn_CustomerDeteils_Click);
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_CheckOut.BorderRadius = 30;
            this.btn_CheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_CheckOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_CheckOut.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_CheckOut.CheckedState.Parent = this.btn_CheckOut;
            this.btn_CheckOut.CustomImages.Parent = this.btn_CheckOut;
            this.btn_CheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_CheckOut.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut.ForeColor = System.Drawing.Color.White;
            this.btn_CheckOut.HoverState.Parent = this.btn_CheckOut;
            this.btn_CheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_CheckOut.Image")));
            this.btn_CheckOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CheckOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_CheckOut.Location = new System.Drawing.Point(506, 20);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.ShadowDecoration.Parent = this.btn_CheckOut;
            this.btn_CheckOut.Size = new System.Drawing.Size(232, 98);
            this.btn_CheckOut.TabIndex = 2;
            this.btn_CheckOut.Text = "Check Out";
            this.btn_CheckOut.Click += new System.EventHandler(this.Btn_CheckOut_Click);
            // 
            // btn_Customer_Registration
            // 
            this.btn_Customer_Registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_Customer_Registration.BorderRadius = 30;
            this.btn_Customer_Registration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Customer_Registration.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_Customer_Registration.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_Customer_Registration.CheckedState.Parent = this.btn_Customer_Registration;
            this.btn_Customer_Registration.CustomImages.Parent = this.btn_Customer_Registration;
            this.btn_Customer_Registration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_Customer_Registration.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer_Registration.ForeColor = System.Drawing.Color.White;
            this.btn_Customer_Registration.HoverState.Parent = this.btn_Customer_Registration;
            this.btn_Customer_Registration.Image = ((System.Drawing.Image)(resources.GetObject("btn_Customer_Registration.Image")));
            this.btn_Customer_Registration.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Customer_Registration.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Customer_Registration.Location = new System.Drawing.Point(268, 20);
            this.btn_Customer_Registration.Name = "btn_Customer_Registration";
            this.btn_Customer_Registration.ShadowDecoration.Parent = this.btn_Customer_Registration;
            this.btn_Customer_Registration.Size = new System.Drawing.Size(232, 98);
            this.btn_Customer_Registration.TabIndex = 1;
            this.btn_Customer_Registration.Text = "Customer Registration";
            this.btn_Customer_Registration.Click += new System.EventHandler(this.Btn_Customer_Registration_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAddRoom.BorderRadius = 30;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddRoom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAddRoom.CheckedState.Parent = this.btnAddRoom;
            this.btnAddRoom.CustomImages.Parent = this.btnAddRoom;
            this.btnAddRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.Parent = this.btnAddRoom;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddRoom.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddRoom.Location = new System.Drawing.Point(30, 20);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.ShadowDecoration.Parent = this.btnAddRoom;
            this.btnAddRoom.Size = new System.Drawing.Size(232, 98);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.Click += new System.EventHandler(this.BtnAdd_customer_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Employee1);
            this.panel2.Controls.Add(this.customer_Details1);
            this.panel2.Controls.Add(this.uC_CheckIn1);
            this.panel2.Controls.Add(this.uC_CustomerRegistration1);
            this.panel2.Controls.Add(this.uC_AddRom1);
            this.panel2.Location = new System.Drawing.Point(20, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2113, 981);
            this.panel2.TabIndex = 1;
            // 
            // uC_CheckIn1
            // 
            this.uC_CheckIn1.BackColor = System.Drawing.Color.White;
            this.uC_CheckIn1.Location = new System.Drawing.Point(8, 3);
            this.uC_CheckIn1.Name = "uC_CheckIn1";
            this.uC_CheckIn1.Size = new System.Drawing.Size(1828, 893);
            this.uC_CheckIn1.TabIndex = 2;
            // 
            // uC_CustomerRegistration1
            // 
            this.uC_CustomerRegistration1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRegistration1.Location = new System.Drawing.Point(8, 0);
            this.uC_CustomerRegistration1.Name = "uC_CustomerRegistration1";
            this.uC_CustomerRegistration1.Size = new System.Drawing.Size(1806, 864);
            this.uC_CustomerRegistration1.TabIndex = 1;
            // 
            // uC_AddRom1
            // 
            this.uC_AddRom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRom1.Location = new System.Drawing.Point(17, 0);
            this.uC_AddRom1.Name = "uC_AddRom1";
            this.uC_AddRom1.Size = new System.Drawing.Size(1819, 911);
            this.uC_AddRom1.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.White;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMinimize.Location = new System.Drawing.Point(12, 81);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(60, 63);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(11, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(60, 63);
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // customer_Details1
            // 
            this.customer_Details1.BackColor = System.Drawing.Color.White;
            this.customer_Details1.Location = new System.Drawing.Point(8, 0);
            this.customer_Details1.Name = "customer_Details1";
            this.customer_Details1.Size = new System.Drawing.Size(1828, 911);
            this.customer_Details1.TabIndex = 3;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.White;
            this.uC_Employee1.Location = new System.Drawing.Point(8, 3);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1819, 882);
            this.uC_Employee1.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1939, 1106);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btn_CustomerDeteils;
        private Guna.UI2.WinForms.Guna2Button btn_CheckOut;
        private Guna.UI2.WinForms.Guna2Button btn_Customer_Registration;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private System.Windows.Forms.Panel MovingPanel;
        private All_Users_Control.UC_AddRom uC_AddRom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_Users_Control.UC_CustomerRegistration uC_CustomerRegistration1;
        private All_Users_Control.UC_CheckIn uC_CheckIn1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_Users_Control.Customer_Details customer_Details1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_Users_Control.UC_Employee uC_Employee1;
    }
}