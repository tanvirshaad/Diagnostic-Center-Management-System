namespace Diagnostic_Center_Management_System
{
    partial class CreateTest
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
            this.dgvCreateTestList = new System.Windows.Forms.DataGridView();
            this.TestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CreateNewTestBtn = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.TestIdLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TestPricetxt = new System.Windows.Forms.TextBox();
            this.TestISOtxt = new System.Windows.Forms.TextBox();
            this.TestDepartmentTxt = new System.Windows.Forms.TextBox();
            this.TestNametxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateTestList)).BeginInit();
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
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.dgvCreateTestList);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(750, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 809);
            this.panel3.TabIndex = 1;
            // 
            // dgvCreateTestList
            // 
            this.dgvCreateTestList.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvCreateTestList.AllowUserToAddRows = false;
            this.dgvCreateTestList.AllowUserToDeleteRows = false;
            this.dgvCreateTestList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCreateTestList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreateTestList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCreateTestList.ColumnHeadersHeight = 35;
            this.dgvCreateTestList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestId,
            this.TestName,
            this.Department,
            this.ISO,
            this.TestPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreateTestList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCreateTestList.Location = new System.Drawing.Point(25, 92);
            this.dgvCreateTestList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCreateTestList.Name = "dgvCreateTestList";
            this.dgvCreateTestList.ReadOnly = true;
            this.dgvCreateTestList.RowHeadersWidth = 51;
            this.dgvCreateTestList.RowTemplate.Height = 24;
            this.dgvCreateTestList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreateTestList.Size = new System.Drawing.Size(641, 693);
            this.dgvCreateTestList.TabIndex = 15;
            // 
            // TestId
            // 
            this.TestId.DataPropertyName = "TestId";
            this.TestId.HeaderText = "Test Id";
            this.TestId.MinimumWidth = 6;
            this.TestId.Name = "TestId";
            this.TestId.ReadOnly = true;
            this.TestId.Width = 110;
            // 
            // TestName
            // 
            this.TestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TestName.DataPropertyName = "TestName";
            this.TestName.HeaderText = "Test Name";
            this.TestName.MinimumWidth = 6;
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Width = 130;
            // 
            // ISO
            // 
            this.ISO.DataPropertyName = "Iso";
            this.ISO.HeaderText = "ISO";
            this.ISO.MinimumWidth = 6;
            this.ISO.Name = "ISO";
            this.ISO.ReadOnly = true;
            this.ISO.Width = 110;
            // 
            // TestPrice
            // 
            this.TestPrice.DataPropertyName = "TestPrice";
            this.TestPrice.HeaderText = "Price";
            this.TestPrice.MinimumWidth = 6;
            this.TestPrice.Name = "TestPrice";
            this.TestPrice.ReadOnly = true;
            this.TestPrice.Width = 110;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(248, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 41);
            this.label8.TabIndex = 14;
            this.label8.Text = "List of tests";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.CreateNewTestBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TestIdLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TestPricetxt);
            this.panel2.Controls.Add(this.TestISOtxt);
            this.panel2.Controls.Add(this.TestDepartmentTxt);
            this.panel2.Controls.Add(this.TestNametxt);
            this.panel2.Location = new System.Drawing.Point(30, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 809);
            this.panel2.TabIndex = 0;
            // 
            // CreateNewTestBtn
            // 
            this.CreateNewTestBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateNewTestBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateNewTestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CreateNewTestBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreateNewTestBtn.FlatAppearance.BorderSize = 0;
            this.CreateNewTestBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewTestBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateNewTestBtn.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.CreateNewTestBtn.IconColor = System.Drawing.Color.DimGray;
            this.CreateNewTestBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CreateNewTestBtn.IconSize = 35;
            this.CreateNewTestBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateNewTestBtn.Location = new System.Drawing.Point(250, 700);
            this.CreateNewTestBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CreateNewTestBtn.Name = "CreateNewTestBtn";
            this.CreateNewTestBtn.Padding = new System.Windows.Forms.Padding(11, 0, 19, 0);
            this.CreateNewTestBtn.Size = new System.Drawing.Size(205, 65);
            this.CreateNewTestBtn.TabIndex = 5;
            this.CreateNewTestBtn.Text = "Create New Test";
            this.CreateNewTestBtn.UseVisualStyleBackColor = false;
            this.CreateNewTestBtn.Click += new System.EventHandler(this.CreateNewTestBtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(192, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 41);
            this.label7.TabIndex = 12;
            this.label7.Text = "Create New Test";
            // 
            // TestIdLabel
            // 
            this.TestIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestIdLabel.AutoSize = true;
            this.TestIdLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestIdLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TestIdLabel.Location = new System.Drawing.Point(285, 180);
            this.TestIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TestIdLabel.Name = "TestIdLabel";
            this.TestIdLabel.Size = new System.Drawing.Size(25, 23);
            this.TestIdLabel.TabIndex = 11;
            this.TestIdLabel.Text = "...";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(129, 546);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(129, 453);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "ISO Code:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(129, 352);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Department:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(128, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Test Name:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(128, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Test ID:";
            // 
            // TestPricetxt
            // 
            this.TestPricetxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestPricetxt.BackColor = System.Drawing.Color.Azure;
            this.TestPricetxt.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestPricetxt.Location = new System.Drawing.Point(290, 546);
            this.TestPricetxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TestPricetxt.Name = "TestPricetxt";
            this.TestPricetxt.Size = new System.Drawing.Size(155, 37);
            this.TestPricetxt.TabIndex = 4;
            // 
            // TestISOtxt
            // 
            this.TestISOtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestISOtxt.BackColor = System.Drawing.Color.Azure;
            this.TestISOtxt.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestISOtxt.Location = new System.Drawing.Point(290, 453);
            this.TestISOtxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TestISOtxt.Name = "TestISOtxt";
            this.TestISOtxt.Size = new System.Drawing.Size(238, 37);
            this.TestISOtxt.TabIndex = 3;
            // 
            // TestDepartmentTxt
            // 
            this.TestDepartmentTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestDepartmentTxt.BackColor = System.Drawing.Color.Azure;
            this.TestDepartmentTxt.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestDepartmentTxt.Location = new System.Drawing.Point(290, 352);
            this.TestDepartmentTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TestDepartmentTxt.Name = "TestDepartmentTxt";
            this.TestDepartmentTxt.Size = new System.Drawing.Size(238, 37);
            this.TestDepartmentTxt.TabIndex = 2;
            // 
            // TestNametxt
            // 
            this.TestNametxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestNametxt.BackColor = System.Drawing.Color.Azure;
            this.TestNametxt.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNametxt.Location = new System.Drawing.Point(290, 255);
            this.TestNametxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TestNametxt.Name = "TestNametxt";
            this.TestNametxt.Size = new System.Drawing.Size(317, 37);
            this.TestNametxt.TabIndex = 1;
            // 
            // CreateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateTest";
            this.Size = new System.Drawing.Size(1730, 850);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateTestList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TestPricetxt;
        private System.Windows.Forms.TextBox TestISOtxt;
        private System.Windows.Forms.TextBox TestDepartmentTxt;
        private System.Windows.Forms.TextBox TestNametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TestIdLabel;
        private FontAwesome.Sharp.IconButton CreateNewTestBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvCreateTestList;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestPrice;
    }
}
