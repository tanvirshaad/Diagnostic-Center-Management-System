using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace Diagnostic_Center_Management_System
{
    
    public partial class CreateInvoice : UserControl
    {
        string path = @"C:\Users\Public\Invoice.txt";

        private string receptionistID;
        private DataAccess Da { get; set; }

        private string invoiceID { get; set; }

        private string date { get; set; }

        private string TIID { get; set; }





        public CreateInvoice()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateAvailableTestGridView();
            this.AutoIdGenerate();
            this.SetDate();
            //this.ClearContent2();
           // this.PopulateInvoiceTestsGridView(invoiceID);


        }

        public CreateInvoice(string ReceptionistId)
        {
            InitializeComponent();
            this.receptionistID = ReceptionistId;
            this.Da = new DataAccess();
            this.PopulateAvailableTestGridView();
            this.AutoIdGenerate();
            this.SetDate();
            //this.ClearContent2();
            // this.PopulateInvoiceTestsGridView(invoiceID);


        }

        private void PopulateAvailableTestGridView(String sql = "Select * from Tests;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvAvailableTests.AutoGenerateColumns = false;
            this.dgvAvailableTests.DataSource = ds.Tables[0];

        }

        private void PopulateInvoiceTestsGridView(String invoiceID)
        {
            var sql = "select Tests.TestId, Tests.TestName , Tests.Department, Tests.Iso, Tests.TestPrice from Tests, TestInvoices where TestInvoices.TestId = Tests.TestId and TestInvoices.InvoiceId = '" +invoiceID+ "';";
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvInvoice.AutoGenerateColumns = false;
            this.dgvInvoice.DataSource = ds.Tables[0];

        }

        private void Sum(String invoiceID)
        {
            var sql = "select sum(Tests.TestPrice) as result from Tests, TestInvoices where TestInvoices.TestId = Tests.TestId and TestInvoices.InvoiceId = '" + invoiceID + "';";
            var ds = this.Da.ExecuteQuery(sql);
            int result = ds.Tables[0].Rows[0].Field<int>("result");
            this.GrossAmountlbl.Text = result.ToString();


        }

        private void DiscountCalculation(int GrossAmount , string discountPercentage)
        {
            double fraction = Convert.ToDouble(discountPercentage) / 100;
            double discount = (GrossAmount * fraction);
            var total = (Convert.ToDouble(GrossAmount) - discount);
            this.Discountlbl.Text = discount.ToString();
            this.NetAmountlbl.Text = total.ToString();
        }

        private void AutoIdGenerate()
        {

            var sql = "Select InvoiceId from Invoices order by InvoiceId desc";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldID = dt.Rows[0][0].ToString();
            string[] s = oldID.Split('-');
            int temp = Convert.ToInt32(s[1]);
            var newID = "I-" + (++temp).ToString("d3");
            this.InvoiceIDlbl1.Text = newID;
            this.InvoiceIdlbl2.Text = newID;
            this.invoiceID = newID;
        }
        private void AutoTIIDGenerate()
        {

            var sql = "select TIID from TestInvoices order by TIID desc";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldID = dt.Rows[0][0].ToString();
            string[] s = oldID.Split('-');
            int temp = Convert.ToInt32(s[1]);
            var newID = "TI-" + (++temp).ToString("d3");
            this.TIID = newID;
 
        }

        private void SetDate()
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            this.InvoiceDatelbl1.Text = sqlFormattedDate;
            this.InvoiceDatelbl2.Text = sqlFormattedDate;
            this.date = sqlFormattedDate;

        }

        private void SetInvoiceInfo()
        {
            this.InvoiceIdlbl2.Text = this.invoiceID;
            this.PatientNamelbl.Text = this.PatientNametxt.Text;
            this.PatientAgelbl.Text = this.PatientAgetxt.Text;
            this.PatientPhonelbl.Text = this.PatientNumbertxt.Text;
            this.PatientAddresslbl.Text = this.PatientAddresstxt.Text;
            this.PatientGenderlbl.Text = this.PatientGendertxt.Text;
            this.ReferredBylbl.Text = this.Referredbytxt.Text;
        }

        private void ClearContent1()
        {

            this.InvoiceIDlbl1.Text = " ";
            this.PatientNametxt.Clear();
            this.PatientAgetxt.Clear();
            this.PatientNumbertxt.Clear();
            this.PatientAddresstxt.Clear();
            this.Referredbytxt.Clear();
            this.discountpercentagetxt.Clear();


        }

        private void ClearContent2()
        {

            this.InvoiceIdlbl2.Text = " ";
            this.PatientNamelbl.Text = " ";
            this.PatientAgelbl.Text =  " ";
            this.PatientPhonelbl.Text = " ";
            this.PatientNamelbl.Text = " ";
            this.PatientAddresslbl.Text = " ";
            this.ReferredBylbl.Text = " ";  
            this.PatientGenderlbl.Text = " ";   


        }

        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.PatientNametxt.Text) || String.IsNullOrEmpty(this.PatientAgetxt.Text) || String.IsNullOrEmpty(this.PatientNumbertxt.Text) || String.IsNullOrEmpty(this.PatientGendertxt.Text) || String.IsNullOrEmpty(this.PatientAddresstxt.Text)|| String.IsNullOrEmpty(this.Referredbytxt.Text) || String.IsNullOrEmpty(this.discountpercentagetxt.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label37_MouseHover(object sender, EventArgs e)
        {
            label37.Font = new Font(label37.Font.Name, label37.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label37_MouseEnter(object sender, EventArgs e)
        {
            label37.Font = new Font(label37.Font.Name, label37.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label37_MouseLeave(object sender, EventArgs e)
        {
            label37.Font = new Font(label37.Font.Name, label37.Font.SizeInPoints, FontStyle.Regular);
        }

        private void AddInformation_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToAdd())
                {
                    this.DiscountCalculation(Convert.ToInt32(this.GrossAmountlbl.Text), this.discountpercentagetxt.Text);
                    int patientAge = int.Parse(this.PatientAgetxt.Text);
                    int discountPercentage = int.Parse(this.discountpercentagetxt.Text);
                    int netAmount = int.Parse(this.NetAmountlbl.Text);
                    int grossAmount = int.Parse(GrossAmountlbl.Text);
                    var sql = "Insert into Invoices values('" +this.invoiceID+ "' , '" + this.PatientNametxt.Text + "','" + this.PatientAddresstxt.Text + "'," + discountPercentage + "," + patientAge + "," + netAmount + ",'" + this.PatientNumbertxt.Text + "'," + grossAmount + ",'" + this.PatientGendertxt.Text + "','" + this.date+ "','" + this.Referredbytxt.Text + "','" +receptionistID+"');";
                    this.Da.ExecuteDMLQuery(sql);



                    this.SetInvoiceInfo();
                    this.ClearContent1();
                    



                }
                else
                {
                    MessageBox.Show("Please fill all the required fields");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error Occured");
            }

        }

        private void dgvAvailableTests_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string TestID = this.dgvAvailableTests.CurrentRow.Cells[0].Value.ToString();
                string sql = "Select * from TestInvoices where TestId = '" +TestID+ "' and InvoiceId = '" +this.invoiceID+ "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("This Test Already Exists on the invoice!", "Create Invoice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        return;

                    }
                }
                else
                {
                    AutoTIIDGenerate();
                    var InvoiceTestSQL = "Insert into TestInvoices Values('" + this.TIID + "','" + this.dgvAvailableTests.CurrentRow.Cells[0].Value.ToString() + "','" + this.invoiceID + "');";
                    this.Da.ExecuteDMLQuery(InvoiceTestSQL);

                    this.ClearContent2();


                    this.Sum(invoiceID);
                    this.PopulateInvoiceTestsGridView(invoiceID);
                    this.SetInvoiceInfo();



                }

            }
            catch (Exception exec)
            {
                MessageBox.Show("Unexpected Error Occured on double click");
            }
            
            }

        private void dgvInvoice_DoubleClick(object sender, EventArgs e)
        {
            try 
            {

                if (this.dgvInvoice.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a Test to remove");
                    return;
                }
                var deleteTestId = this.dgvInvoice.CurrentRow.Cells["InvoiceTestId"].Value.ToString();
                var delteTestName = this.dgvInvoice.CurrentRow.Cells["InvoiceTestName"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to remove " + delteTestName + " Test from the Invoice?", "Remove Test", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var sql = "delete from TestInvoices where TestId = '" + deleteTestId + "' and InvoiceId = '" +invoiceID+"';";
                    var flag = this.Da.ExecuteDMLQuery(sql);
                    if (flag == 1)
                    {
                        MessageBox.Show("Test removed Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Test was not removed");
                    }
                    PopulateInvoiceTestsGridView(invoiceID);    
                }
                else if (result == DialogResult.No)
                {
                    return;
                }

            }
            catch(Exception ex) 
            {

                MessageBox.Show("Unexpected Error Occured on double click 2");
            }
        }

        private void label37_Click(object sender, EventArgs e)
        {
            if(!File.Exists(path))
            {
                using (StreamWriter streamWriter = File.CreateText(path))
                {
                    streamWriter.WriteLine("Patient name: " + this.PatientNamelbl.Text);
                    streamWriter.WriteLine("Patient Age: " + this.PatientAgelbl.Text);
                    streamWriter.WriteLine("Total bill: " + this.NetAmountlbl.Text);
                    
                }
                    

            }
        }
    }
}
