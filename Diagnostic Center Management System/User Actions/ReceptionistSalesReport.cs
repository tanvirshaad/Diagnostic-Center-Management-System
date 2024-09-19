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
    public partial class ReceptionistSalesReport : UserControl
    {
        private DataAccess Da { get; set; }
        private string receptionistId { get; set; }
        public ReceptionistSalesReport(string receptionistID)
        {
            InitializeComponent();
            this.receptionistId = receptionistID;
            this.Da = new DataAccess();
            this.PopulateGridView(receptionistID);
        }


        private void PopulateGridView(string receptionistId)
        {
            string sql = "select Users.UserID , Users.Name ,Users.Age, Users.Role , Users.Salary , (select sum(Invoices.NetAmount) from Invoices where Invoices.ReceptionistID = '" + receptionistId + "') as Total_Earning from Users where Users.UserID = '" + receptionistId + "';";
        
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvEmpPerformance.AutoGenerateColumns = false;
            this.dgvEmpPerformance.DataSource = ds.Tables[0];

        }
    }
}
