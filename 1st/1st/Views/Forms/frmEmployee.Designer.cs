namespace _1st.Views.Forms
{
    partial class frmEmployee
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.lblState = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRegTime = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRegDate = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRegUser = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNotes = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtُEmpName = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSallary = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtAttendDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNationalID = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.HeaderPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtُEmpName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSallary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationalID.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Controls.Add(this.btnClose);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(867, 34);
            this.HeaderPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(746, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "بطاقة الموظفين";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::_1st.Properties.Resources.CloseWhite25;
            this.btnClose.Location = new System.Drawing.Point(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(12)))), ((int)(((byte)(66)))));
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(47, 4);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(774, 3);
            this.FooterPanel.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.FooterPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 789);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 10);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Sans Arabic", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(718, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "الموظفين";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(12)))), ((int)(((byte)(36)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(35, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(87)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(116, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox2);
            this.panelControl1.Controls.Add(this.label12);
            this.panelControl1.Controls.Add(this.txtNationalID);
            this.panelControl1.Controls.Add(this.txtAttendDate);
            this.panelControl1.Controls.Add(this.separatorControl2);
            this.panelControl1.Controls.Add(this.lblState);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Controls.Add(this.txtNotes);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txtُEmpName);
            this.panelControl1.Controls.Add(this.txtAddress);
            this.panelControl1.Controls.Add(this.txtPhone);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.txtSallary);
            this.panelControl1.Location = new System.Drawing.Point(12, 87);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(845, 696);
            this.panelControl1.TabIndex = 20;
            // 
            // separatorControl2
            // 
            this.separatorControl2.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl2.Location = new System.Drawing.Point(783, 28);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(20, 260);
            this.separatorControl2.TabIndex = 21;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.lblState.Location = new System.Drawing.Point(66, 13);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(33, 18);
            this.lblState.TabIndex = 20;
            this.lblState.Text = "جدبد";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRegTime);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtRegDate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtRegUser);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(24, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات التسجيل";
            // 
            // txtRegTime
            // 
            this.txtRegTime.Enabled = false;
            this.txtRegTime.Location = new System.Drawing.Point(42, 58);
            this.txtRegTime.Name = "txtRegTime";
            this.txtRegTime.Properties.Appearance.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.txtRegTime.Properties.Appearance.Options.UseFont = true;
            this.txtRegTime.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtRegTime.Size = new System.Drawing.Size(256, 24);
            this.txtRegTime.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.label11.Location = new System.Drawing.Point(299, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "توقيت التسجيل";
            // 
            // txtRegDate
            // 
            this.txtRegDate.Enabled = false;
            this.txtRegDate.Location = new System.Drawing.Point(393, 58);
            this.txtRegDate.Name = "txtRegDate";
            this.txtRegDate.Properties.Appearance.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.txtRegDate.Properties.Appearance.Options.UseFont = true;
            this.txtRegDate.Size = new System.Drawing.Size(256, 24);
            this.txtRegDate.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.label10.Location = new System.Drawing.Point(663, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "تاريخ التسجيل";
            // 
            // txtRegUser
            // 
            this.txtRegUser.Enabled = false;
            this.txtRegUser.Location = new System.Drawing.Point(393, 24);
            this.txtRegUser.Name = "txtRegUser";
            this.txtRegUser.Properties.Appearance.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.txtRegUser.Properties.Appearance.Options.UseFont = true;
            this.txtRegUser.Size = new System.Drawing.Size(256, 24);
            this.txtRegUser.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.label9.Location = new System.Drawing.Point(650, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "القائم بالتسجيل";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(66, 249);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Properties.Appearance.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.txtNotes.Properties.Appearance.Options.UseFont = true;
            this.txtNotes.Size = new System.Drawing.Size(695, 24);
            this.txtNotes.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.label3.Location = new System.Drawing.Point(642, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "أسم الموظف بالكامل";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.label8.Location = new System.Drawing.Point(640, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "ملاحظات على العميل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.label4.Location = new System.Drawing.Point(693, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "رقم الهاتف";
            // 
            // txtُEmpName
            // 
            this.txtُEmpName.Location = new System.Drawing.Point(460, 33);
            this.txtُEmpName.Name = "txtُEmpName";
            this.txtُEmpName.Properties.Appearance.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.txtُEmpName.Properties.Appearance.Options.UseFont = true;
            this.txtُEmpName.Size = new System.Drawing.Size(301, 24);
            this.txtُEmpName.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(66, 195);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(695, 24);
            this.txtAddress.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(460, 87);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Size = new System.Drawing.Size(301, 24);
            this.txtPhone.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.label7.Location = new System.Drawing.Point(678, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "عنوان الموظف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.label5.Location = new System.Drawing.Point(274, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "تاريخ بداية العمل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.label6.Location = new System.Drawing.Point(722, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "المرتب";
            // 
            // txtSallary
            // 
            this.txtSallary.Location = new System.Drawing.Point(460, 141);
            this.txtSallary.Name = "txtSallary";
            this.txtSallary.Properties.Appearance.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.txtSallary.Properties.Appearance.Options.UseFont = true;
            this.txtSallary.Size = new System.Drawing.Size(301, 24);
            this.txtSallary.TabIndex = 11;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.btnDelete);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Location = new System.Drawing.Point(12, 41);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(845, 40);
            this.panelControl2.TabIndex = 21;
            // 
            // txtAttendDate
            // 
            this.txtAttendDate.CalendarForeColor = System.Drawing.Color.Maroon;
            this.txtAttendDate.Enabled = false;
            this.txtAttendDate.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.txtAttendDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtAttendDate.Location = new System.Drawing.Point(223, 85);
            this.txtAttendDate.Name = "txtAttendDate";
            this.txtAttendDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAttendDate.RightToLeftLayout = true;
            this.txtAttendDate.ShowUpDown = true;
            this.txtAttendDate.Size = new System.Drawing.Size(144, 26);
            this.txtAttendDate.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.label12.Location = new System.Drawing.Point(236, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 18);
            this.label12.TabIndex = 38;
            this.label12.Text = "الرقم القومى (إن وجد )";
            // 
            // txtNationalID
            // 
            this.txtNationalID.Location = new System.Drawing.Point(66, 141);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Properties.Appearance.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.txtNationalID.Properties.Appearance.Options.UseFont = true;
            this.txtNationalID.Size = new System.Drawing.Size(301, 24);
            this.txtNationalID.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DGV);
            this.groupBox2.Font = new System.Drawing.Font("Droid Sans Arabic", 9.75F);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(24, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 296);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "كل الموظفين";
            // 
            // DGV
            // 
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(3, 22);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(773, 271);
            this.DGV.TabIndex = 22;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 799);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerCardFRM";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtُEmpName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSallary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationalID.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtRegTime;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtRegDate;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtRegUser;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtُEmpName;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtSallary;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit txtNationalID;
        private System.Windows.Forms.DateTimePicker txtAttendDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV;
    }
}