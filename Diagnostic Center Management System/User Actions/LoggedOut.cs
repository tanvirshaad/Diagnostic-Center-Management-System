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
    public partial class LoggedOut : UserControl
    {
        public LoggedOut()
        {
            InitializeComponent();
        }

        private void BackToLoginBtn_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
