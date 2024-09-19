namespace Diagnostic_Center_Management_System
{
    partial class EditTest
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchTests = new System.Windows.Forms.TextBox();
            this.RemoveTestBtn = new FontAwesome.Sharp.IconButton();
            this.dgvEditTest = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UpdateTestId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdatePrice = new System.Windows.Forms.TextBox();
            this.UpdateISO = new System.Windows.Forms.TextBox();
            this.UpdateDepartment = new System.Windows.Forms.TextBox();
            this.UpdateTestName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MakeChangesTest = new FontAwesome.Sharp.IconButton();
            this.TestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditTest)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 850);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.SearchTests);
            this.panel2.Controls.Add(this.RemoveTestBtn);
            this.panel2.Controls.Add(this.dgvEditTest);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(30, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 809);
            this.panel2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(12, 113);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Search Test:";
            // 
            // SearchTests
            // 
            this.SearchTests.BackColor = System.Drawing.Color.Azure;
            this.SearchTests.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTests.Location = new System.Drawing.Point(148, 113);
            this.SearchTests.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SearchTests.Name = "SearchTests";
            this.SearchTests.Size = new System.Drawing.Size(226, 35);
            this.SearchTests.TabIndex = 25;
            this.SearchTests.TextChanged += new System.EventHandler(this.SearchTests_TextChanged);
            // 
            // RemoveTestBtn
            // 
            this.RemoveTestBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RemoveTestBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveTestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RemoveTestBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.RemoveTestBtn.FlatAppearance.BorderSize = 0;
            this.RemoveTestBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveTestBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveTestBtn.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            this.RemoveTestBtn.IconColor = System.Drawing.Color.DimGray;
            this.RemoveTestBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RemoveTestBtn.IconSize = 35;
            this.RemoveTestBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveTestBtn.Location = new System.Drawing.Point(245, 735);
            this.RemoveTestBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RemoveTestBtn.Name = "RemoveTestBtn";
            this.RemoveTestBtn.Padding = new System.Windows.Forms.Padding(11, 0, 19, 0);
            this.RemoveTestBtn.Size = new System.Drawing.Size(205, 65);
            this.RemoveTestBtn.TabIndex = 25;
            this.RemoveTestBtn.Text = "Remove Test";
            this.RemoveTestBtn.UseVisualStyleBackColor = false;
            this.RemoveTestBtn.Click += new System.EventHandler(this.RemoveTestBtn_Click);
            // 
            // dgvEditTest
            // 
            this.dgvEditTest.AllowUserToAddRows = false;
            this.dgvEditTest.AllowUserToDeleteRows = false;
            this.dgvEditTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEditTest.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEditTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestId,
            this.TestName,
            this.TestDepartment,
            this.TestISO,
            this.TestPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditTest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEditTest.Location = new System.Drawing.Point(26, 170);
            this.dgvEditTest.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEditTest.Name = "dgvEditTest";
            this.dgvEditTest.ReadOnly = true;
            this.dgvEditTest.RowHeadersWidth = 51;
            this.dgvEditTest.RowTemplate.Height = 24;
            this.dgvEditTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditTest.Size = new System.Drawing.Size(641, 548);
            this.dgvEditTest.TabIndex = 15;
            this.dgvEditTest.DoubleClick += new System.EventHandler(this.dgvEditTest_DoubleClick);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(166, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 44);
            this.label8.TabIndex = 14;
            this.label8.Text = "Select a test to edit";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.UpdateTestId);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.UpdatePrice);
            this.panel3.Controls.Add(this.UpdateISO);
            this.panel3.Controls.Add(this.UpdateDepartment);
            this.panel3.Controls.Add(this.UpdateTestName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.MakeChangesTest);
            this.panel3.Location = new System.Drawing.Point(750, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 809);
            this.panel3.TabIndex = 1;
            // 
            // UpdateTestId
            // 
            this.UpdateTestId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateTestId.AutoSize = true;
            this.UpdateTestId.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTestId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UpdateTestId.Location = new System.Drawing.Point(291, 173);
            this.UpdateTestId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpdateTestId.Name = "UpdateTestId";
            this.UpdateTestId.Size = new System.Drawing.Size(82, 25);
            this.UpdateTestId.TabIndex = 34;
            this.UpdateTestId.Text = "Test ID:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(135, 539);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 33;
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
            this.label4.Location = new System.Drawing.Point(135, 446);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 32;
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
            this.label3.Location = new System.Drawing.Point(135, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 31;
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
            this.label2.Location = new System.Drawing.Point(134, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 30;
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
            this.label1.Location = new System.Drawing.Point(134, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Test ID:";
            // 
            // UpdatePrice
            // 
            this.UpdatePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdatePrice.BackColor = System.Drawing.Color.Azure;
            this.UpdatePrice.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePrice.Location = new System.Drawing.Point(296, 539);
            this.UpdatePrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UpdatePrice.Name = "UpdatePrice";
            this.UpdatePrice.Size = new System.Drawing.Size(155, 40);
            this.UpdatePrice.TabIndex = 28;
            // 
            // UpdateISO
            // 
            this.UpdateISO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateISO.BackColor = System.Drawing.Color.Azure;
            this.UpdateISO.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateISO.Location = new System.Drawing.Point(296, 446);
            this.UpdateISO.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UpdateISO.Name = "UpdateISO";
            this.UpdateISO.Size = new System.Drawing.Size(238, 40);
            this.UpdateISO.TabIndex = 27;
            // 
            // UpdateDepartment
            // 
            this.UpdateDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateDepartment.BackColor = System.Drawing.Color.Azure;
            this.UpdateDepartment.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDepartment.Location = new System.Drawing.Point(296, 345);
            this.UpdateDepartment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UpdateDepartment.Name = "UpdateDepartment";
            this.UpdateDepartment.Size = new System.Drawing.Size(238, 40);
            this.UpdateDepartment.TabIndex = 26;
            // 
            // UpdateTestName
            // 
            this.UpdateTestName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateTestName.BackColor = System.Drawing.Color.Azure;
            this.UpdateTestName.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTestName.Location = new System.Drawing.Point(296, 248);
            this.UpdateTestName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UpdateTestName.Name = "UpdateTestName";
            this.UpdateTestName.Size = new System.Drawing.Size(317, 40);
            this.UpdateTestName.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(155, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(450, 44);
            this.label7.TabIndex = 16;
            this.label7.Text = "Update Test Information";
            // 
            // MakeChangesTest
            // 
            this.MakeChangesTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MakeChangesTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MakeChangesTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MakeChangesTest.Cursor = System.Windows.Forms.Cursors.Default;
            this.MakeChangesTest.FlatAppearance.BorderSize = 0;
            this.MakeChangesTest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeChangesTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MakeChangesTest.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.MakeChangesTest.IconColor = System.Drawing.Color.DimGray;
            this.MakeChangesTest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MakeChangesTest.IconSize = 35;
            this.MakeChangesTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MakeChangesTest.Location = new System.Drawing.Point(275, 700);
            this.MakeChangesTest.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MakeChangesTest.Name = "MakeChangesTest";
            this.MakeChangesTest.Padding = new System.Windows.Forms.Padding(11, 0, 19, 0);
            this.MakeChangesTest.Size = new System.Drawing.Size(205, 65);
            this.MakeChangesTest.TabIndex = 24;
            this.MakeChangesTest.Text = "Make Changes";
            this.MakeChangesTest.UseVisualStyleBackColor = false;
            this.MakeChangesTest.Click += new System.EventHandler(this.MakeChangesTest_Click);
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
            // TestDepartment
            // 
            this.TestDepartment.DataPropertyName = "Department";
            this.TestDepartment.HeaderText = "Department";
            this.TestDepartment.MinimumWidth = 6;
            this.TestDepartment.Name = "TestDepartment";
            this.TestDepartment.ReadOnly = true;
            this.TestDepartment.Width = 110;
            // 
            // TestISO
            // 
            this.TestISO.DataPropertyName = "Iso";
            this.TestISO.HeaderText = "ISO";
            this.TestISO.MinimumWidth = 6;
            this.TestISO.Name = "TestISO";
            this.TestISO.ReadOnly = true;
            this.TestISO.Width = 110;
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
            // EditTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditTest";
            this.Size = new System.Drawing.Size(1730, 850);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditTest)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvEditTest;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton MakeChangesTest;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton RemoveTestBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SearchTests;
        private System.Windows.Forms.Label UpdateTestId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UpdatePrice;
        private System.Windows.Forms.TextBox UpdateISO;
        private System.Windows.Forms.TextBox UpdateDepartment;
        private System.Windows.Forms.TextBox UpdateTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestISO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestPrice;
    }
}
