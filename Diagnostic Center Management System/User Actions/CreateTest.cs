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

namespace Diagnostic_Center_Management_System
{
    public partial class CreateTest : UserControl
    {
        private DataAccess Da { get; set; }
        public CreateTest()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();
        }
        private void PopulateGridView(String sql = "Select * from Tests;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvCreateTestList.AutoGenerateColumns = false;
            this.dgvCreateTestList.DataSource = ds.Tables[0];
        }

        private void AutoIdGenerate()
        {

            var sql = "Select TestId from Tests order by TestId desc";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldID = dt.Rows[0][0].ToString();
            string[] s = oldID.Split('-');
            int temp = Convert.ToInt32(s[1]);
            var newID = "t-" + (++temp).ToString("d3");
            this.TestIdLabel.Text = newID;
        }

        private void ClearContent()
        {

            this.TestIdLabel.Text = " ";
            this.TestNametxt.Clear();
            this.TestDepartmentTxt.Clear();
            this.TestISOtxt.Clear();
            this.TestPricetxt.Clear();

            this.AutoIdGenerate();

        }

        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.TestNametxt.Text) || String.IsNullOrEmpty(this.TestDepartmentTxt.Text) || String.IsNullOrEmpty(this.TestISOtxt.Text) || String.IsNullOrEmpty(this.TestPricetxt.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CreateNewTestBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!this.IsValidToAdd())
                {
                    int TestPrice = int.Parse(this.TestPricetxt.Text);
                    int TestISO = int.Parse(this.TestISOtxt.Text);
                    var sql = "Insert into Tests values('" + this.TestIdLabel.Text + "' , '" + this.TestNametxt.Text + "','" + this.TestDepartmentTxt.Text + "'," +TestISO+ "," +TestPrice+ ");";

                    var flag = this.Da.ExecuteDMLQuery(sql);

                    if (flag == 1)
                    {
                        MessageBox.Show("New Test Added!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new Test");
                    }
                    this.ClearContent();

                    this.PopulateGridView();

                }
                else
                { 
                    MessageBox.Show("Please fill all the required fields");
                    return;
                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Unexpected Error Occured");
            }
        }
    }
}
