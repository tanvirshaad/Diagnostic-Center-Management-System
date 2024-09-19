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
    public partial class ManageAdmin : UserControl
    {   
        private DataAccess Da { get ; set; }    
        public ManageAdmin()
        {
            InitializeComponent();
            Da = new DataAccess();  
            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        private void AutoIdGenerate()
        {
            var sql = "Select UserID from Users where Role = 'Admin' order by UserID desc";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldID = dt.Rows[0][0].ToString();
            string[] s = oldID.Split('-');
            int temp = Convert.ToInt32(s[1]);
            var newID = "a-" + (++temp).ToString("d3");
            this.NewAdminID.Text = newID;
        }
        private void PopulateGridView(String sql = "Select * from Users where Role = 'Admin';")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvCurrentAdmins.AutoGenerateColumns = false;
            this.dgvCurrentAdmins.DataSource = ds.Tables[0];
        }

        private void ClearContent()
        {

            this.NewAdminID.Text = " ";
            this.AdminName.Clear();
            this.AdminPassword.Clear();
            this.AdminConfPass.Clear();
            this.AutoIdGenerate();

        }

        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.AdminName.Text) || String.IsNullOrEmpty(this.AdminPassword.Text) || String.IsNullOrEmpty(this.AdminConfPass.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool PasswordMatch()
        {
            if (this.AdminPassword.Text == this.AdminConfPass.Text)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        private void AdminAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToAdd())
                {
                    if (this.PasswordMatch())
                    {

                        var sql = "Insert into Users (UserID , Password , Role , Name ) values('" + this.NewAdminID.Text + "' , '" + this.AdminPassword.Text + "','Admin' , '" +this.AdminName.Text+ "' );";

                        var flag = this.Da.ExecuteDMLQuery(sql);

                        if (flag == 1)
                        {
                            MessageBox.Show("New Admin Added!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add new Admin");
                        }

                        this.ClearContent();

                        this.PopulateGridView();
                    }
                    else
                    {
                        MessageBox.Show("Password does not match with Confirm Password");
                        return;
                    }
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

        private void AdminSearchBox_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from Users where Name like'%" + this.AdminSearchBox.Text + "%' and Role = 'Admin';";
            this.PopulateGridView(sql);
        }

        private void AdminRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvCurrentAdmins.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a receptionist to remove");
                    return;
                }
                var deleteID = this.dgvCurrentAdmins.CurrentRow.Cells["UserId"].Value.ToString();
                var delteName = this.dgvCurrentAdmins.CurrentRow.Cells["EmpName"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to remove " + delteName + " from the system?", "Remove Receptionist", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var sql = "delete from Users where UserID = '" + deleteID + "';";
                    var flag = this.Da.ExecuteDMLQuery(sql);
                    if (flag == 1)
                    {
                        MessageBox.Show("Admin removed Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Admin was not removed");
                    }
                }
                else if (result == DialogResult.No)
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
    }
}
