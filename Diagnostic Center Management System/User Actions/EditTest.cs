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
    public partial class EditTest : UserControl
    {
        private DataAccess Da { get; set; }
        public EditTest()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(String sql = "Select * from Tests;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvEditTest.AutoGenerateColumns = false;
            this.dgvEditTest.DataSource = ds.Tables[0];
        }

        private void SearchTests_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from Tests where TestName like'%" + this.SearchTests.Text + "%';";
            this.PopulateGridView(sql);
        }

        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.UpdateTestName.Text) || String.IsNullOrEmpty(this.UpdateDepartment.Text) || String.IsNullOrEmpty(this.UpdateISO.Text) || String.IsNullOrEmpty(this.UpdatePrice.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ClearContent()
        {

            this.UpdateTestId.Text = " ";
            this.UpdateTestName.Clear();
            this.UpdateDepartment.Clear();
            this.UpdateISO.Clear();
            this.UpdatePrice.Clear();


        }

        private void RemoveTestBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEditTest.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a Test to remove");
                    return;
                }
                var deleteTestId = this.dgvEditTest.CurrentRow.Cells["TestId"].Value.ToString();
                var delteTestName = this.dgvEditTest.CurrentRow.Cells["TestName"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to remove " + delteTestName + " from the system?", "Remove Test", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var sql = "delete from Tests where TestId = '" + deleteTestId + "';";
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
                this.PopulateGridView();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Unexpected Error Occured");
            }
        }

        private void dgvEditTest_DoubleClick(object sender, EventArgs e)
        {
            this.UpdateTestId.Text = this.dgvEditTest.CurrentRow.Cells["TestId"].Value.ToString();
            this.UpdateTestName.Text = this.dgvEditTest.CurrentRow.Cells["TestName"].Value.ToString();
            this.UpdateDepartment.Text = this.dgvEditTest.CurrentRow.Cells["TestDepartment"].Value.ToString();
            this.UpdateISO.Text = this.dgvEditTest.CurrentRow.Cells["TestISO"].Value.ToString();
            this.UpdatePrice.Text = this.dgvEditTest.CurrentRow.Cells["TestPrice"].Value.ToString();
            
        }

        private void MakeChangesTest_Click(object sender, EventArgs e)
        {
            try
             {
                if (!this.IsValidToAdd())
                {
                    int ISO = int.Parse(this.UpdateISO.Text);
                    int PRICE = int.Parse(this.UpdatePrice.Text);
                    var updateID = this.dgvEditTest.CurrentRow.Cells["TestId"].Value.ToString();
                    var updateName = this.dgvEditTest.CurrentRow.Cells["TestName"].Value.ToString();
                    DialogResult result = MessageBox.Show("Are you sure you want to make changes to " + updateName + "Test on the system?", "Update Test", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        var sql = "Update Tests set TestName = '" + this.UpdateTestName.Text + "', Department = '" + this.UpdateDepartment.Text + "',ISO = '" + ISO + "', TestPrice = '" + PRICE + "' where TestId = '" + updateID + "';";

                        var flag = this.Da.ExecuteDMLQuery(sql);

                        if (flag == 1)
                        {
                            MessageBox.Show("Receptionist information Updated!");
                        }
                        else
                        {
                            MessageBox.Show("Receptionist Information was not updated");
                        }


                    }
                    else if (result == DialogResult.No)
                    {
                        return;
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
