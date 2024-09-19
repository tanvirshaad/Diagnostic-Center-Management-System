using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagnostic_Center_Management_System
{
    public partial class UpdatePassword : UserControl
    {
        private DataAccess Da { get; set; }
        private string userId;
        private string oldPassword;
        public UpdatePassword(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.Da = new DataAccess();
            var sql = "Select Password from Users where UserID = '" +userId+ "';";
            var ds = this.Da.ExecuteQuery(sql);
            this.oldPassword = Convert.ToString(ds.Tables[0].Rows[0]["Password"]);
            this.ChngPassUserId.Text = this.userId;
        }

        private bool PrevPasswordMatch()
        {
            if (this.oldPassword == Convert.ToString(this.PrevPassword.Text))
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
            if (this.NewPassword.Text == this.ConfPassword.Text)
            {
                return true;
            }
            else
            {

                return false;
            }

        }

        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.PrevPassword.Text) || String.IsNullOrEmpty(this.NewPassword.Text) || String.IsNullOrEmpty(this.ConfPassword.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToAdd())
                {

                    if (PrevPasswordMatch())
                    {

                        if (PasswordMatch())
                        {
                            DialogResult result = MessageBox.Show("Are you sure you want to update to new password?", "Update Password", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                var sql = "Update Users set Password = '" + this.NewPassword.Text + "' Where UserId = '" + this.userId + "';";

                                var flag = this.Da.ExecuteDMLQuery(sql);
                                if (flag == 1)
                                {

                                    MessageBox.Show("Password has been Updated!");

                                }
                                else
                                {

                                    MessageBox.Show("Password has not been Updated!");
                                }

                            }
                            else if (result == DialogResult.No)
                            {

                                return;

                            }

                        }
                        else
                        {

                            DialogResult result = MessageBox.Show("New password and Confimred password do not match, please try again ", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (result == DialogResult.OK)
                            {
                                return;
                            }

                        }

                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Previous Password is wrong, please try again ", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (result == DialogResult.OK)
                        {
                            return;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error Occured");

            }
        }
    }



}
