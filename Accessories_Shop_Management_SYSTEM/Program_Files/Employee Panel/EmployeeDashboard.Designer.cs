namespace Program_Files.Employee_Panel
{
    partial class EmployeeDashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.BtnProductList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pnlTitle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 480);
            this.panel1.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Khaki;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.lblUserName);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(924, 94);
            this.pnlTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblTitle.Location = new System.Drawing.Point(611, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(165, 94);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Blue;
            this.lblUserName.Location = new System.Drawing.Point(105, 36);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(206, 27);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Employee Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnUpdatePassword);
            this.panel2.Controls.Add(this.BtnProductList);
            this.panel2.Location = new System.Drawing.Point(2, 99);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 381);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Program_Files.Properties.Resources.icons9_user_96;
            this.pictureBox1.Location = new System.Drawing.Point(3, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 81);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Program_Files.Properties.Resources.Employee;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(282, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(642, 380);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Image = global::Program_Files.Properties.Resources.icons8_logout_96;
            this.button1.Location = new System.Drawing.Point(86, 177);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 123);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logout";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnUpdatePassword.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnUpdatePassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnUpdatePassword.Image = global::Program_Files.Properties.Resources.icons8_password_961;
            this.btnUpdatePassword.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdatePassword.Location = new System.Drawing.Point(150, 15);
            this.btnUpdatePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(107, 139);
            this.btnUpdatePassword.TabIndex = 3;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdatePassword.UseVisualStyleBackColor = false;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // BtnProductList
            // 
            this.BtnProductList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnProductList.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnProductList.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductList.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnProductList.Image = global::Program_Files.Properties.Resources.icons8_bullet_list_961;
            this.BtnProductList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProductList.Location = new System.Drawing.Point(25, 15);
            this.BtnProductList.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProductList.Name = "BtnProductList";
            this.BtnProductList.Size = new System.Drawing.Size(107, 139);
            this.BtnProductList.TabIndex = 0;
            this.BtnProductList.Text = " Product List";
            this.BtnProductList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnProductList.UseVisualStyleBackColor = false;
            this.BtnProductList.Click += new System.EventHandler(this.BtnProductList_Click);
            // 
            // EmployeeDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 471);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDashboard";
            this.panel1.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnProductList;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}