using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Diagnostic_Center_Management_System
{
    public partial class AdminDashboard : Form
    {
        string userId;
        public AdminDashboard(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void BtnColorClear()
        {
            this.iconButton1.BackColor = System.Drawing.Color.LightCyan;
          
            this.iconButton2.BackColor = System.Drawing.Color.LightCyan;

            this.iconButton3.BackColor = System.Drawing.Color.LightCyan;

            this.iconButton4.BackColor = System.Drawing.Color.LightCyan;

            this.iconButton7.BackColor = System.Drawing.Color.LightCyan;

            this.iconButton5.BackColor = System.Drawing.Color.Pink;

            this.iconButton9.BackColor = System.Drawing.Color.LightCyan;

            this.AdminViewSalesReport.BackColor = System.Drawing.Color.LightCyan;

            this.ViewInvoices.BackColor = System.Drawing.Color.LightCyan;



        }




        private void iconButton8_Click(object sender, EventArgs e)
        {
            LoggedOut lo = new LoggedOut();
            lo.Show();
            this.Hide();
            this.BtnColorClear();   
            this.iconButton8.BackColor = System.Drawing.Color.PaleTurquoise;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            CreateTest ct = new CreateTest();
            this.adminPanel.Controls.Add(ct);
            this.BtnColorClear();
            this.iconButton1.BackColor = System.Drawing.Color.PaleTurquoise;


        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            EditTest et = new EditTest();
            this.adminPanel.Controls.Add(et);
            this.BtnColorClear();
            this.iconButton2.BackColor = System.Drawing.Color.PaleTurquoise;


        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            AddReceptionist ar = new AddReceptionist();
            this.adminPanel.Controls.Add(ar);
            this.BtnColorClear();
            this.iconButton3.BackColor = System.Drawing.Color.PaleTurquoise;


        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            ManageReceptionists mr = new ManageReceptionists();
            this.adminPanel.Controls.Add(mr);
            this.BtnColorClear();
            this.iconButton4.BackColor = System.Drawing.Color.PaleTurquoise;


        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            UpdatePassword up = new UpdatePassword(this.userId);
            this.adminPanel.Controls.Add(up);
            this.BtnColorClear();
            this.iconButton9.BackColor = System.Drawing.Color.PaleTurquoise;

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            this.adminPanel.Controls.Add(panel5);
            this.BtnColorClear(); 
        }

        private void iconButton7_Click_1(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            this.adminPanel.Controls.Add(panel5);
            this.BtnColorClear();
            this.iconButton7.BackColor = System.Drawing.Color.PaleTurquoise;


        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AdminViewSalesReport_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            AdminSalesReport asr = new AdminSalesReport();
            this.adminPanel.Controls.Add(asr);
            this.BtnColorClear();
            this.AdminViewSalesReport.BackColor = System.Drawing.Color.PaleTurquoise;


        }

        private void ViewInvoices_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            ViewInvoices vi = new ViewInvoices();
            this.adminPanel.Controls.Add(vi);
            this.BtnColorClear();
            this.ViewInvoices.BackColor = System.Drawing.Color.PaleTurquoise;

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            ManageAdmin ma = new ManageAdmin();
            this.adminPanel.Controls.Add(ma);
            this.BtnColorClear();
            this.iconButton5.BackColor = System.Drawing.Color.LightCoral;
        }
    }
}
