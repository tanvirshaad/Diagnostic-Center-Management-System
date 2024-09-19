namespace Diagnostic_Center_Management_System
{
    partial class AddReceptionist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCurrentReceptionists = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ReceptionistConfPass = new System.Windows.Forms.TextBox();
            this.ReceptionistAddBtn = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.NewReceptionistID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReceptionistID = new System.Windows.Forms.Label();
            this.ReceptionistPassword = new System.Windows.Forms.TextBox();
            this.ReceptionistSalary = new System.Windows.Forms.TextBox();
            this.ReceptionistAge = new System.Windows.Forms.TextBox();
            this.ReceptionistName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentReceptionists)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.dgvCurrentReceptionists);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(750, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 809);
            this.panel3.TabIndex = 1;
            // 
            // dgvCurrentReceptionists
            // 
            this.dgvCurrentReceptionists.AllowUserToAddRows = false;
            this.dgvCurrentReceptionists.AllowUserToDeleteRows = false;
            this.dgvCurrentReceptionists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCurrentReceptionists.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrentReceptionists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurrentReceptionists.ColumnHeadersHeight = 30;
            this.dgvCurrentReceptionists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.EmpName,
            this.Age,
            this.Role,
            this.Salary,
            this.Password});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurrentReceptionists.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurrentReceptionists.Location = new System.Drawing.Point(25, 92);
            this.dgvCurrentReceptionists.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCurrentReceptionists.Name = "dgvCurrentReceptionists";
            this.dgvCurrentReceptionists.ReadOnly = true;
            this.dgvCurrentReceptionists.RowHeadersWidth = 51;
            this.dgvCurrentReceptionists.RowTemplate.Height = 24;
            this.dgvCurrentReceptionists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentReceptionists.Size = new System.Drawing.Size(641, 693);
            this.dgvCurrentReceptionists.TabIndex = 15;
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
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 50;
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
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Width = 110;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 110;
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
            this.label8.Size = new System.Drawing.Size(360, 44);
            this.label8.TabIndex = 14;
            this.label8.Text = "List of receptionists";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.ReceptionistConfPass);
            this.panel2.Controls.Add(this.ReceptionistAddBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.NewReceptionistID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ReceptionistID);
            this.panel2.Controls.Add(this.ReceptionistPassword);
            this.panel2.Controls.Add(this.ReceptionistSalary);
            this.panel2.Controls.Add(this.ReceptionistAge);
            this.panel2.Controls.Add(this.ReceptionistName);
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
            this.label9.Location = new System.Drawing.Point(93, 537);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Confirm Password:";
            // 
            // ReceptionistConfPass
            // 
            this.ReceptionistConfPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceptionistConfPass.BackColor = System.Drawing.Color.Azure;
            this.ReceptionistConfPass.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceptionistConfPass.Location = new System.Drawing.Point(309, 537);
            this.ReceptionistConfPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ReceptionistConfPass.Name = "ReceptionistConfPass";
            this.ReceptionistConfPass.Size = new System.Drawing.Size(298, 40);
            this.ReceptionistConfPass.TabIndex = 14;
            // 
            // ReceptionistAddBtn
            // 
            this.ReceptionistAddBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ReceptionistAddBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReceptionistAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ReceptionistAddBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReceptionistAddBtn.FlatAppearance.BorderSize = 0;
            this.ReceptionistAddBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceptionistAddBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReceptionistAddBtn.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.ReceptionistAddBtn.IconColor = System.Drawing.Color.DimGray;
            this.ReceptionistAddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReceptionistAddBtn.IconSize = 35;
            this.ReceptionistAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReceptionistAddBtn.Location = new System.Drawing.Point(250, 700);
            this.ReceptionistAddBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ReceptionistAddBtn.Name = "ReceptionistAddBtn";
            this.ReceptionistAddBtn.Padding = new System.Windows.Forms.Padding(11, 0, 19, 0);
            this.ReceptionistAddBtn.Size = new System.Drawing.Size(205, 65);
            this.ReceptionistAddBtn.TabIndex = 13;
            this.ReceptionistAddBtn.Text = "Add New Receptionist";
            this.ReceptionistAddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReceptionistAddBtn.UseVisualStyleBackColor = false;
            this.ReceptionistAddBtn.Click += new System.EventHandler(this.ReceptionistAddBtn_Click);
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
            this.label7.Size = new System.Drawing.Size(424, 44);
            this.label7.TabIndex = 12;
            this.label7.Text = "Add New Receptionist";
            // 
            // NewReceptionistID
            // 
            this.NewReceptionistID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewReceptionistID.AutoSize = true;
            this.NewReceptionistID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewReceptionistID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NewReceptionistID.Location = new System.Drawing.Point(305, 195);
            this.NewReceptionistID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewReceptionistID.Name = "NewReceptionistID";
            this.NewReceptionistID.Size = new System.Drawing.Size(30, 25);
            this.NewReceptionistID.TabIndex = 11;
            this.NewReceptionistID.Text = "...";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(93, 467);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(93, 393);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(93, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Age:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(93, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
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
            this.ReceptionistID.Location = new System.Drawing.Point(93, 195);
            this.ReceptionistID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReceptionistID.Name = "ReceptionistID";
            this.ReceptionistID.Size = new System.Drawing.Size(88, 25);
            this.ReceptionistID.TabIndex = 6;
            this.ReceptionistID.Text = "User ID:";
            // 
            // ReceptionistPassword
            // 
            this.ReceptionistPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceptionistPassword.BackColor = System.Drawing.Color.Azure;
            this.ReceptionistPassword.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceptionistPassword.Location = new System.Drawing.Point(309, 467);
            this.ReceptionistPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ReceptionistPassword.Name = "ReceptionistPassword";
            this.ReceptionistPassword.Size = new System.Drawing.Size(298, 40);
            this.ReceptionistPassword.TabIndex = 4;
            // 
            // ReceptionistSalary
            // 
            this.ReceptionistSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceptionistSalary.BackColor = System.Drawing.Color.Azure;
            this.ReceptionistSalary.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceptionistSalary.Location = new System.Drawing.Point(309, 393);
            this.ReceptionistSalary.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ReceptionistSalary.Name = "ReceptionistSalary";
            this.ReceptionistSalary.Size = new System.Drawing.Size(192, 40);
            this.ReceptionistSalary.TabIndex = 3;
            // 
            // ReceptionistAge
            // 
            this.ReceptionistAge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceptionistAge.BackColor = System.Drawing.Color.Azure;
            this.ReceptionistAge.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceptionistAge.Location = new System.Drawing.Point(309, 320);
            this.ReceptionistAge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ReceptionistAge.Name = "ReceptionistAge";
            this.ReceptionistAge.Size = new System.Drawing.Size(95, 40);
            this.ReceptionistAge.TabIndex = 2;
            // 
            // ReceptionistName
            // 
            this.ReceptionistName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceptionistName.BackColor = System.Drawing.Color.Azure;
            this.ReceptionistName.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceptionistName.Location = new System.Drawing.Point(309, 246);
            this.ReceptionistName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ReceptionistName.Name = "ReceptionistName";
            this.ReceptionistName.Size = new System.Drawing.Size(298, 40);
            this.ReceptionistName.TabIndex = 1;
            // 
            // AddReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddReceptionist";
            this.Size = new System.Drawing.Size(1730, 850);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentReceptionists)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvCurrentReceptionists;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ReceptionistAddBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label NewReceptionistID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ReceptionistID;
        private System.Windows.Forms.TextBox ReceptionistPassword;
        private System.Windows.Forms.TextBox ReceptionistSalary;
        private System.Windows.Forms.TextBox ReceptionistAge;
        private System.Windows.Forms.TextBox ReceptionistName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ReceptionistConfPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}
