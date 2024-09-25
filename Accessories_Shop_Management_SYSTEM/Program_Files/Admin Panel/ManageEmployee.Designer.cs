namespace Program_Files.Admin_Panel
{
    partial class ManageEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.AddLbl = new System.Windows.Forms.Label();
            this.FnameTxt = new System.Windows.Forms.TextBox();
            this.SalaryLbl = new System.Windows.Forms.Label();
            this.LnameTxt = new System.Windows.Forms.TextBox();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.LNameLbl = new System.Windows.Forms.Label();
            this.SalTxt = new System.Windows.Forms.TextBox();
            this.FNameLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.MngEmpLbl = new System.Windows.Forms.Label();
            this.dgvShowEmployee = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.pnlEdit);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.BackBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MngEmpLbl);
            this.panel1.Controls.Add(this.dgvShowEmployee);
            this.panel1.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1631, 881);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(846, 636);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 51);
            this.btnDelete.TabIndex = 116;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Crimson;
            this.btnReload.Location = new System.Drawing.Point(566, 633);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(108, 51);
            this.btnReload.TabIndex = 115;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Crimson;
            this.btnEdit.Location = new System.Drawing.Point(438, 633);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 51);
            this.btnEdit.TabIndex = 114;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.pictureBox19);
            this.pnlEdit.Controls.Add(this.AddressTxt);
            this.pnlEdit.Controls.Add(this.AddLbl);
            this.pnlEdit.Controls.Add(this.FnameTxt);
            this.pnlEdit.Controls.Add(this.SalaryLbl);
            this.pnlEdit.Controls.Add(this.LnameTxt);
            this.pnlEdit.Controls.Add(this.PhoneLbl);
            this.pnlEdit.Controls.Add(this.EmailTxt);
            this.pnlEdit.Controls.Add(this.EmailLbl);
            this.pnlEdit.Controls.Add(this.PhoneTxt);
            this.pnlEdit.Controls.Add(this.LNameLbl);
            this.pnlEdit.Controls.Add(this.SalTxt);
            this.pnlEdit.Controls.Add(this.FNameLbl);
            this.pnlEdit.Controls.Add(this.pictureBox8);
            this.pnlEdit.Controls.Add(this.pictureBox18);
            this.pnlEdit.Controls.Add(this.pictureBox11);
            this.pnlEdit.Controls.Add(this.pictureBox16);
            this.pnlEdit.Controls.Add(this.pictureBox15);
            this.pnlEdit.Location = new System.Drawing.Point(23, 208);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(382, 418);
            this.pnlEdit.TabIndex = 113;
            // 
            // AddressTxt
            // 
            this.AddressTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddressTxt.Location = new System.Drawing.Point(198, 297);
            this.AddressTxt.Margin = new System.Windows.Forms.Padding(2);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(174, 26);
            this.AddressTxt.TabIndex = 112;
            // 
            // AddLbl
            // 
            this.AddLbl.AutoSize = true;
            this.AddLbl.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.AddLbl.Location = new System.Drawing.Point(69, 297);
            this.AddLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddLbl.Name = "AddLbl";
            this.AddLbl.Size = new System.Drawing.Size(84, 22);
            this.AddLbl.TabIndex = 85;
            this.AddLbl.Text = "Address";
            // 
            // FnameTxt
            // 
            this.FnameTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FnameTxt.Location = new System.Drawing.Point(198, 24);
            this.FnameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.FnameTxt.Name = "FnameTxt";
            this.FnameTxt.Size = new System.Drawing.Size(174, 26);
            this.FnameTxt.TabIndex = 110;
            // 
            // SalaryLbl
            // 
            this.SalaryLbl.AutoSize = true;
            this.SalaryLbl.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.SalaryLbl.Location = new System.Drawing.Point(69, 357);
            this.SalaryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SalaryLbl.Name = "SalaryLbl";
            this.SalaryLbl.Size = new System.Drawing.Size(70, 22);
            this.SalaryLbl.TabIndex = 87;
            this.SalaryLbl.Text = "Salary";
            // 
            // LnameTxt
            // 
            this.LnameTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LnameTxt.Location = new System.Drawing.Point(198, 94);
            this.LnameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.LnameTxt.Name = "LnameTxt";
            this.LnameTxt.Size = new System.Drawing.Size(174, 26);
            this.LnameTxt.TabIndex = 109;
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.PhoneLbl.Location = new System.Drawing.Point(69, 231);
            this.PhoneLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(97, 22);
            this.PhoneLbl.TabIndex = 91;
            this.PhoneLbl.Text = "Phone No";
            // 
            // EmailTxt
            // 
            this.EmailTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmailTxt.Location = new System.Drawing.Point(198, 166);
            this.EmailTxt.Margin = new System.Windows.Forms.Padding(2);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(174, 26);
            this.EmailTxt.TabIndex = 108;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.EmailLbl.Location = new System.Drawing.Point(69, 164);
            this.EmailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(63, 22);
            this.EmailLbl.TabIndex = 92;
            this.EmailLbl.Text = "Email";
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PhoneTxt.Location = new System.Drawing.Point(198, 231);
            this.PhoneTxt.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(174, 26);
            this.PhoneTxt.TabIndex = 107;
            // 
            // LNameLbl
            // 
            this.LNameLbl.AutoSize = true;
            this.LNameLbl.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.LNameLbl.Location = new System.Drawing.Point(69, 91);
            this.LNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNameLbl.Name = "LNameLbl";
            this.LNameLbl.Size = new System.Drawing.Size(113, 22);
            this.LNameLbl.TabIndex = 93;
            this.LNameLbl.Text = "Last_Name";
            // 
            // SalTxt
            // 
            this.SalTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SalTxt.Location = new System.Drawing.Point(198, 357);
            this.SalTxt.Margin = new System.Windows.Forms.Padding(2);
            this.SalTxt.Name = "SalTxt";
            this.SalTxt.Size = new System.Drawing.Size(174, 26);
            this.SalTxt.TabIndex = 106;
            // 
            // FNameLbl
            // 
            this.FNameLbl.AutoSize = true;
            this.FNameLbl.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.FNameLbl.Location = new System.Drawing.Point(69, 21);
            this.FNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FNameLbl.Name = "FNameLbl";
            this.FNameLbl.Size = new System.Drawing.Size(115, 22);
            this.FNameLbl.TabIndex = 94;
            this.FNameLbl.Text = "First_Name";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SaveBtn.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SaveBtn.Location = new System.Drawing.Point(691, 633);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(129, 54);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // MngEmpLbl
            // 
            this.MngEmpLbl.AutoSize = true;
            this.MngEmpLbl.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngEmpLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.MngEmpLbl.Location = new System.Drawing.Point(182, 77);
            this.MngEmpLbl.Name = "MngEmpLbl";
            this.MngEmpLbl.Size = new System.Drawing.Size(341, 49);
            this.MngEmpLbl.TabIndex = 1;
            this.MngEmpLbl.Text = "Manage Employee";
            // 
            // dgvShowEmployee
            // 
            this.dgvShowEmployee.AllowUserToAddRows = false;
            this.dgvShowEmployee.AllowUserToDeleteRows = false;
            this.dgvShowEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.FirstName,
            this.LastName,
            this.Email,
            this.PhoneNumber,
            this.Nid,
            this.Gender,
            this.Age,
            this.DOB,
            this.JoiningDate,
            this.Salary,
            this.Address,
            this.AssignedBy});
            this.dgvShowEmployee.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvShowEmployee.Location = new System.Drawing.Point(438, 234);
            this.dgvShowEmployee.Name = "dgvShowEmployee";
            this.dgvShowEmployee.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowEmployee.RowHeadersVisible = false;
            this.dgvShowEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvShowEmployee.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowEmployee.Size = new System.Drawing.Size(1098, 382);
            this.dgvShowEmployee.TabIndex = 0;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "User Id";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Nid
            // 
            this.Nid.DataPropertyName = "Nid";
            this.Nid.HeaderText = "Nid";
            this.Nid.Name = "Nid";
            this.Nid.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // JoiningDate
            // 
            this.JoiningDate.DataPropertyName = "joiningDate";
            this.JoiningDate.HeaderText = "Joinig Date";
            this.JoiningDate.Name = "JoiningDate";
            this.JoiningDate.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // AssignedBy
            // 
            this.AssignedBy.DataPropertyName = "AssignedBy";
            this.AssignedBy.HeaderText = "Assigned By";
            this.AssignedBy.Name = "AssignedBy";
            this.AssignedBy.ReadOnly = true;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox19.BackgroundImage")));
            this.pictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox19.Location = new System.Drawing.Point(12, 11);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(39, 32);
            this.pictureBox19.TabIndex = 105;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox8.Location = new System.Drawing.Point(12, 347);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(39, 32);
            this.pictureBox8.TabIndex = 96;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox18.BackgroundImage")));
            this.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox18.Location = new System.Drawing.Point(12, 81);
            this.pictureBox18.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(39, 32);
            this.pictureBox18.TabIndex = 104;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox11.Location = new System.Drawing.Point(13, 287);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(39, 32);
            this.pictureBox11.TabIndex = 98;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox16.BackgroundImage")));
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox16.Location = new System.Drawing.Point(13, 154);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(39, 32);
            this.pictureBox16.TabIndex = 103;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox15.BackgroundImage")));
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox15.Location = new System.Drawing.Point(13, 221);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(39, 32);
            this.pictureBox15.TabIndex = 102;
            this.pictureBox15.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackBtn.Location = new System.Drawing.Point(1462, 44);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(79, 82);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(23, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 126);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 793);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageEmployee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvShowEmployee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MngEmpLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedBy;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.TextBox FnameTxt;
        private System.Windows.Forms.TextBox LnameTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.TextBox SalTxt;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label FNameLbl;
        private System.Windows.Forms.Label LNameLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label SalaryLbl;
        private System.Windows.Forms.Label AddLbl;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDelete;
    }
}