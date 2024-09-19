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
    public partial class ViewInvoices : UserControl
    {

        private DataAccess Da { get; set; }

        private string invoiceID;
        public ViewInvoices()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateAvailableInvoiceGridView();
        }

        private void PopulateAvailableInvoiceGridView(String sql = "select Invoices.*, Users.UserID , Users.Name from Invoices , Users where Invoices.ReceptionistID = Users.UserID")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvInvoices.DataSource = ds.Tables[0];
        }

        private void PopulateInvoiceTestsGridView(String invoiceID)
        {
            var sql = "select Tests.TestId, Tests.TestName , Tests.Department, Tests.Iso, Tests.TestPrice from Tests, TestInvoices where TestInvoices.TestId = Tests.TestId and TestInvoices.InvoiceId = '" + invoiceID + "';";
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvInvoiceTests.AutoGenerateColumns = false;
            this.dgvInvoiceTests.DataSource = ds.Tables[0];

        }


        private void SetInvoiceInfo(string invoiceId)
        {
            string sql = "select Invoices.*, Users.UserID , Users.Name from Invoices , Users where Invoices.ReceptionistID = Users.UserID AND Invoices.InvoiceId = '" + invoiceId + "';";

            var ds = this.Da.ExecuteQuery(sql);

            this.InvoiceIdlbl2.Text = Convert.ToString(ds.Tables[0].Rows[0]["InvoiceId"]);
            this.InvoiceDatelbl2.Text = Convert.ToString(ds.Tables[0].Rows[0]["InvoiceIssueDate"]);
            this.PatientNamelbl.Text = Convert.ToString(ds.Tables[0].Rows[0]["PatientName"]);
            this.PatientAgelbl.Text = Convert.ToString(ds.Tables[0].Rows[0]["PatientAge"]);
            this.PatientPhonelbl.Text = Convert.ToString(ds.Tables[0].Rows[0]["PatientPhoneNo"]);
            this.PatientAddresslbl.Text = Convert.ToString(ds.Tables[0].Rows[0]["PatientAddress"]);
            this.PatientGenderlbl.Text = Convert.ToString(ds.Tables[0].Rows[0]["PatientGender"]);
            this.ReferredBylbl.Text = Convert.ToString(ds.Tables[0].Rows[0]["ReferredBy"]);
            this.GrossAmountlbl.Text = Convert.ToString(ds.Tables[0].Rows[0]["GrossAmount"]);
            this.NetAmountlbl.Text = Convert.ToString(ds.Tables[0].Rows[0]["NetAmount"]);
            this.Discountlbl.Text = Convert.ToString(Convert.ToInt32(ds.Tables[0].Rows[0]["GrossAmount"]) - Convert.ToInt32(ds.Tables[0].Rows[0]["NetAmount"]));
        }
        private void ClearContent2()
        {

            this.InvoiceIdlbl2.Text = " ";
            this.PatientNamelbl.Text = " ";
            this.PatientAgelbl.Text = " ";
            this.PatientPhonelbl.Text = " ";
            this.PatientNamelbl.Text = " ";
            this.PatientAddresslbl.Text = " ";
            this.ReferredBylbl.Text = " ";
            this.PatientGenderlbl.Text = " ";


        }

        private void dgvInvoices_DoubleClick(object sender, EventArgs e)
        {
            this.invoiceID = this.dgvInvoices.CurrentRow.Cells["InvoicesId"].Value.ToString();
            ClearContent2();
            SetInvoiceInfo(invoiceID);
            PopulateInvoiceTestsGridView(invoiceID);
        }

        private void RemoveInvoice_Click(object sender, EventArgs e)
        {
            try
            {


                if (this.dgvInvoices.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a Test to remove");
                    return;
                }
                var deleteInvoiceId = this.dgvInvoices.CurrentRow.Cells["InvoicesId"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to remove " + deleteInvoiceId + " from the system?", "Remove Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var sql = "delete from Invoices where InvoiceId = '" + deleteInvoiceId + "';";
                    var sql2 = "delete from TestInvoices where InvoiceId='" + deleteInvoiceId + "';";
                    this.Da.ExecuteDMLQuery(sql2);
                    var flag = this.Da.ExecuteDMLQuery(sql);
                    if (flag == 1)
                    {
                        MessageBox.Show("Test removed Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Test was not removed");
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
                this.PopulateAvailableInvoiceGridView();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Unexpected Error Occured");
            }
        }

        private void SearchInvoicesView_TextChanged(object sender, EventArgs e)
        {
            var sql = "select Invoices.*, Users.UserID , Users.Name from Invoices , Users where Invoices.ReceptionistID = Users.UserID AND InvoiceId like'%" + this.SearchInvoicesView.Text + "%'";
            {
                PopulateAvailableInvoiceGridView(sql);

            }
        }
    }
}

