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
    public partial class ManageReceptionists : UserControl
    {
        private DataAccess Da { get; set; }
        public ManageReceptionists()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(String sql = "Select * from Users where Role = 'Receptionist';")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvReceptionists.AutoGenerateColumns = false;
            this.dgvReceptionists.DataSource = ds.Tables[0];
        }

        private void ReceptionistSearchBox_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from Users where Name like'%" +this.ReceptionistSearchBox.Text + "%' and Role = 'Receptionist';";
            this.PopulateGridView(sql);
        }

        private void SearchReceptionist_Click(object sender, EventArgs e)
        {
            string sql = "Select * from Users where Name = '" + this.ReceptionistSearchBox.Text + "' and Role = 'Receptionist';";
            this.PopulateGridView(sql);
        }

        private void ReceptionistRemoveBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                if(this.dgvReceptionists.SelectedRows.Count < 1) 
                {
                   MessageBox.Show("Please select a receptionist to remove");
                    return;
                }
             var deleteID = this.dgvReceptionists.CurrentRow.Cells["UserId"].Value.ToString();
             var delteName = this.dgvReceptionists.CurrentRow.Cells["EmpName"].Value.ToString();

             DialogResult result = MessageBox.Show("Are you sure you want to remove " +delteName+ " from the system?" , "Remove Receptionist" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    var sql = "delete from Users where UserID = '" + deleteID + "';";
                    var flag = this.Da.ExecuteDMLQuery(sql);
                    if(flag == 1)
                    {
                        MessageBox.Show("Receptionist removed Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Receptionist was not removed");
                    }
                }
                else if(result == DialogResult.No)
                {
                    return;
                }
               this.PopulateGridView();
               this.ClearContent();    


            }
            catch (Exception exc)
            {
                MessageBox.Show("Unexpected Error Occured");
            }
        }
        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.ReceptionistNametxt.Text) || String.IsNullOrEmpty(this.ReceptionistAgetxt.Text) || String.IsNullOrEmpty(this.ReceptionistSalarytxt.Text) || String.IsNullOrEmpty(this.ReceptionistPasswordtxt.Text))
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

            this.ReceptionistID.Text = " ";
            this.ReceptionistNametxt.Clear();
            this.ReceptionistAgetxt.Clear();
            this.ReceptionistSalarytxt.Clear();
            this.ReceptionistPasswordtxt.Clear();
            this.ReceptionistConfPasswordtxt.Clear();

        }

        private bool PasswordMatch()
        {
            if (this.ReceptionistPasswordtxt.Text == this.ReceptionistConfPasswordtxt.Text)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void dgvReceptionists_DoubleClick(object sender, EventArgs e)
        {
            this.ReceptionistID.Text = this.dgvReceptionists.CurrentRow.Cells["UserId"].Value.ToString();
            this.ReceptionistNametxt.Text = this.dgvReceptionists.CurrentRow.Cells["EmpName"].Value.ToString();
            this.ReceptionistAgetxt.Text = this.dgvReceptionists.CurrentRow.Cells["Age"].Value.ToString();
            this.ReceptionistSalarytxt.Text = this.dgvReceptionists.CurrentRow.Cells["Salary"].Value.ToString();
            this.ReceptionistPasswordtxt.Text = this.dgvReceptionists.CurrentRow.Cells["Password"].Value.ToString();
            this.ReceptionistConfPasswordtxt.Text = this.dgvReceptionists.CurrentRow.Cells["password"].Value.ToString();
        }

        private void UpdateReceptionist_Click(object sender, EventArgs e)
        {
            try
            {
              if(!this.IsValidToAdd())
                {
                    if (this.PasswordMatch())
                    {
                        int Salary = int.Parse(this.ReceptionistSalarytxt.Text);
                        var updateID = this.dgvReceptionists.CurrentRow.Cells["UserId"].Value.ToString();
                        var updateName = this.dgvReceptionists.CurrentRow.Cells["EmpName"].Value.ToString();
                        DialogResult result = MessageBox.Show("Are you sure you want to make changes to " + updateName + " on the system?", "Update Receptionist", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {

                            var sql = "Update Users set Name = '" + this.ReceptionistNametxt.Text + "', Age = '" + this.ReceptionistAgetxt.Text + "',Salary = '" + Salary + "', Password = '" + this.ReceptionistPasswordtxt.Text + "' where UserID = '" +updateID+ "';";

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
                        else if( result == DialogResult.No ) 
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password does not match with Confirm Password");
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
            catch(Exception exc) 
            {
                
                MessageBox.Show("Unexpected Error Occured");

            }   
        }
    }
}
