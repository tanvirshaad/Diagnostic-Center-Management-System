using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagnostic_Center_Management_System
{
    public partial class AdminSalesReport : UserControl
    {
        private DataAccess Da { get; set; }

        public AdminSalesReport()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select Users.UserID , Users.Name ,Users.Age, Users.Role , Users.Salary , (select sum(Invoices.NetAmount) from Invoices where Invoices.ReceptionistID = Users.UserID) as Total_Earning from Users where Users.Role = 'Receptionist'")
        {
         var ds = this.Da.ExecuteQuery(sql);
         this.dgvEmpPerformance.AutoGenerateColumns = false;
         this.dgvEmpPerformance.DataSource = ds.Tables[0];

        }
    }
}
