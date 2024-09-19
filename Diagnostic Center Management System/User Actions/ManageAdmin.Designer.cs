namespace Diagnostic_Center_Management_System
{
    partial class ManageAdmin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AdminRemoveBtn = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminSearchBox = new System.Windows.Forms.TextBox();
            this.dgvCurrentAdmins = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.AdminConfPass = new System.Windows.Forms.TextBox();
            this.AdminAddBtn = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.NewAdminID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReceptionistID = new System.Windows.Forms.Label();
            this.AdminPassword = new System.Windows.Forms.TextBox();
            this.AdminName = new System.Windows.Forms.TextBox();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentAdmins)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 850);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.AdminRemoveBtn);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.AdminSearchBox);
            this.panel3.Controls.Add(this.dgvCurrentAdmins);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(750, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 809);
            this.panel3.TabIndex = 1;
            // 
            // AdminRemoveBtn
            // 
            this.AdminRemoveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AdminRemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.AdminRemoveBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.AdminRemoveBtn.FlatAppearance.BorderSize = 0;
            this.AdminRemoveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminRemoveBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdminRemoveBtn.IconChar = FontAwesome.Sharp.IconChar.PersonCircleMinus;
            this.AdminRemoveBtn.IconColor = System.Drawing.Color.DimGray;
            this.AdminRemoveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AdminRemoveBtn.IconSize = 35;
            this.AdminRemoveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminRemoveBtn.Location = new System.Drawing.Point(245, 732);
            this.AdminRemoveBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AdminRemoveBtn.Name = "AdminRemoveBtn";
            this.AdminRemoveBtn.Padding = new System.Windows.Forms.Padding(11, 0, 19, 0);
            this.AdminRemoveBtn.Size = new System.Drawing.Size(230, 65);
            this.AdminRemoveBtn.TabIndex = 30;
            this.AdminRemoveBtn.Text = "Remove Administrator";
            this.AdminRemoveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AdminRemoveBtn.UseVisualStyleBackColor = false;
            this.AdminRemoveBtn.Click += new System.EventHandler(this.AdminRemoveBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(29, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Double click on a user to modify user information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(29, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Search by Name:";
            // 
            // AdminSearchBox
            // 
            this.AdminSearchBox.BackColor = System.Drawing.Color.Azure;
            this.AdminSearchBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSearchBox.Location = new System.Drawing.Point(223, 87);
            this.AdminSearchBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AdminSearchBox.Name = "AdminSearchBox";
            this.AdminSearchBox.Size = new System.Drawing.Size(226, 32);
            this.AdminSearchBox.TabIndex = 28;
            this.AdminSearchBox.TextChanged += new System.EventHandler(this.AdminSearchBox_TextChanged);
            // 
            // dgvCurrentAdmins
            // 
            this.dgvCurrentAdmins.AllowUserToAddRows = false;
            this.dgvCurrentAdmins.AllowUserToDeleteRows = false;
            this.dgvCurrentAdmins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCurrentAdmins.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrentAdmins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCurrentAdmins.ColumnHeadersHeight = 30;
            this.dgvCurrentAdmins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.EmpName,
            this.Role,
            this.Password});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurrentAdmins.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCurrentAdmins.Location = new System.Drawing.Point(26, 170);
            this.dgvCurrentAdmins.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCurrentAdmins.Name = "dgvCurrentAdmins";
            this.dgvCurrentAdmins.ReadOnly = true;
            this.dgvCurrentAdmins.RowHeadersWidth = 51;
            this.dgvCurrentAdmins.RowTemplate.Height = 24;
            this.dgvCurrentAdmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentAdmins.Size = new System.Drawing.Size(631, 548);
            this.dgvCurrentAdmins.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(174, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(354, 41);
            this.label8.TabIndex = 14;
            this.label8.Text = "List of Administrators";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.AdminConfPass);
            this.panel2.Controls.Add(this.AdminAddBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.NewAdminID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ReceptionistID);
            this.panel2.Controls.Add(this.AdminPassword);
            this.panel2.Controls.Add(this.AdminName);
            this.panel2.Location = new System.Drawing.Point(30, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 809);
            this.panel2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(93, 458);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Confirm Password:";
            // 
            // AdminConfPass
            // 
            this.AdminConfPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminConfPass.BackColor = System.Drawing.Color.Azure;
            this.AdminConfPass.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminConfPass.Location = new System.Drawing.Point(309, 458);
            this.AdminConfPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AdminConfPass.Name = "AdminConfPass";
            this.AdminConfPass.Size = new System.Drawing.Size(298, 37);
            this.AdminConfPass.TabIndex = 3;
            // 
            // AdminAddBtn
            // 
            this.AdminAddBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AdminAddBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AdminAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.AdminAddBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.AdminAddBtn.FlatAppearance.BorderSize = 0;
            this.AdminAddBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdminAddBtn.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.AdminAddBtn.IconColor = System.Drawing.Color.DimGray;
            this.AdminAddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AdminAddBtn.IconSize = 35;
            this.AdminAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminAddBtn.Location = new System.Drawing.Point(250, 700);
            this.AdminAddBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AdminAddBtn.Name = "AdminAddBtn";
            this.AdminAddBtn.Padding = new System.Windows.Forms.Padding(11, 0, 19, 0);
            this.AdminAddBtn.Size = new System.Drawing.Size(205, 65);
            this.AdminAddBtn.TabIndex = 4;
            this.AdminAddBtn.Text = "Add Admininstrator";
            this.AdminAddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AdminAddBtn.UseVisualStyleBackColor = false;
            this.AdminAddBtn.Click += new System.EventHandler(this.AdminAddBtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(150, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(407, 41);
            this.label7.TabIndex = 12;
            this.label7.Text = "Add New Administrator";
            // 
            // NewAdminID
            // 
            this.NewAdminID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewAdminID.AutoSize = true;
            this.NewAdminID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAdminID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NewAdminID.Location = new System.Drawing.Point(305, 269);
            this.NewAdminID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewAdminID.Name = "NewAdminID";
            this.NewAdminID.Size = new System.Drawing.Size(25, 23);
            this.NewAdminID.TabIndex = 11;
            this.NewAdminID.Text = "...";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(93, 388);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(93, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // ReceptionistID
            // 
            this.ReceptionistID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceptionistID.AutoSize = true;
            this.ReceptionistID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceptionistID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReceptionistID.Location = new System.Drawing.Point(93, 269);
            this.ReceptionistID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReceptionistID.Name = "ReceptionistID";
            this.ReceptionistID.Size = new System.Drawing.Size(77, 23);
            this.ReceptionistID.TabIndex = 6;
            this.ReceptionistID.Text = "User ID:";
            // 
            // AdminPassword
            // 
            this.AdminPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminPassword.BackColor = System.Drawing.Color.Azure;
            this.AdminPassword.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPassword.Location = new System.Drawing.Point(309, 388);
            this.AdminPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AdminPassword.Name = "AdminPassword";
            this.AdminPassword.Size = new System.Drawing.Size(298, 37);
            this.AdminPassword.TabIndex = 2;
            // 
            // AdminName
            // 
            this.AdminName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminName.BackColor = System.Drawing.Color.Azure;
            this.AdminName.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminName.Location = new System.Drawing.Point(309, 320);
            this.AdminName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(298, 37);
            this.AdminName.TabIndex = 1;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserID";
            this.UserId.HeaderText = "User ID";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 80;
            // 
            // EmpName
            // 
            this.EmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpName.DataPropertyName = "Name";
            this.EmpName.HeaderText = "Name";
            this.EmpName.MinimumWidth = 6;
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 110;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 150;
            // 
            // ManageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ManageAdmin";
            this.Size = new System.Drawing.Size(1730, 850);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentAdmins)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvCurrentAdmins;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AdminConfPass;
        private FontAwesome.Sharp.IconButton AdminAddBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label NewAdminID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ReceptionistID;
        private System.Windows.Forms.TextBox AdminPassword;
        private System.Windows.Forms.TextBox AdminName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdminSearchBox;
        private FontAwesome.Sharp.IconButton AdminRemoveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}
