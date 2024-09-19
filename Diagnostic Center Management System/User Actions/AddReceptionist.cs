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
    public partial class AddReceptionist : UserControl
    {
        private DataAccess Da { get; set; }
        public AddReceptionist()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        private void PopulateGridView(String sql = "Select * from Users where Role = 'Receptionist';")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvCurrentReceptionists.AutoGenerateColumns = false;
            this.dgvCurrentReceptionists.DataSource = ds.Tables[0];
        }

        private void AutoIdGenerate()
        {

            var sql = "Select UserID from Users where Role = 'Receptionist' order by UserID desc";
            var dt = this.Da.ExecuteQueryTable(sql); 
            var oldID = dt.Rows[0][0].ToString();
            string[] s = oldID.Split('-');
            int temp = Convert.ToInt32(s[1]);
            var newID = "r-" + (++temp).ToString("d3");
            this.NewReceptionistID.Text = newID;    
        }

        private void ClearContent()
        {

            this.ReceptionistID.Text = " ";
            this.ReceptionistName.Clear();
            this.ReceptionistAge.Clear();
            this.ReceptionistSalary.Clear();
            this.ReceptionistPassword.Clear();
            this.ReceptionistConfPass.Clear();

            this.AutoIdGenerate();

        }

        private bool IsValidToAdd()
        {
            if(String.IsNullOrEmpty(this.ReceptionistName.Text) || String.IsNullOrEmpty(this.ReceptionistAge.Text) || String.IsNullOrEmpty(this.ReceptionistSalary.Text) || String.IsNullOrEmpty(this.ReceptionistPassword.Text))
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
            if(this.ReceptionistPassword.Text == this.ReceptionistConfPass.Text) 
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void ReceptionistAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToAdd())
                {
                    if (this.PasswordMatch())
                    {

                      int Salary = int.Parse(this.ReceptionistSalary.Text);
                      var sql = "Insert into Users values('" + this.NewReceptionistID.Text + "' , '" + this.ReceptionistPassword.Text + "','Receptionist','" + this.ReceptionistName.Text + "','" + this.ReceptionistAge.Text + "','" + Salary + "');";

                      var flag = this.Da.ExecuteDMLQuery(sql);

                      if (flag == 1)
                      {
                          MessageBox.Show("New Receptionist Added!");
                      }
                      else
                      {
                          MessageBox.Show("Failed to add new Receptionist");
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
            catch (Exception exc)
            {
                MessageBox.Show("Unexpected Error Occured");
            }
            }
        }
    }

