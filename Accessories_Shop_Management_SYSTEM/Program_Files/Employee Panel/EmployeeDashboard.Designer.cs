namespace Program_Files.Employee_Panel
{
    partial class EmployeeDashboard
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnUpdatePass = new System.Windows.Forms.Button();
            this.BtnProductList = new System.Windows.Forms.Button();
            this.LblEmployeeInfo = new System.Windows.Forms.Label();
            this.lblShowName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LblEmployeeInfo);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 480);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblShowName);
            this.panel3.Location = new System.Drawing.Point(277, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 411);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.BtnLogOut);
            this.panel2.Controls.Add(this.BtnUpdatePass);
            this.panel2.Controls.Add(this.BtnProductList);
            this.panel2.Location = new System.Drawing.Point(2, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 411);
            this.panel2.TabIndex = 1;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnLogOut.Location = new System.Drawing.Point(36, 212);
            this.BtnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(175, 31);
            this.BtnLogOut.TabIndex = 2;
            this.BtnLogOut.Text = "LogOut";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnUpdatePass
            // 
            this.BtnUpdatePass.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnUpdatePass.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdatePass.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnUpdatePass.Location = new System.Drawing.Point(36, 152);
            this.BtnUpdatePass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnUpdatePass.Name = "BtnUpdatePass";
            this.BtnUpdatePass.Size = new System.Drawing.Size(175, 31);
            this.BtnUpdatePass.TabIndex = 1;
            this.BtnUpdatePass.Text = "Update Password";
            this.BtnUpdatePass.UseVisualStyleBackColor = false;
            this.BtnUpdatePass.Click += new System.EventHandler(this.BtnUpdatePass_Click);
            // 
            // BtnProductList
            // 
            this.BtnProductList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnProductList.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnProductList.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnProductList.Location = new System.Drawing.Point(36, 81);
            this.BtnProductList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnProductList.Name = "BtnProductList";
            this.BtnProductList.Size = new System.Drawing.Size(175, 34);
            this.BtnProductList.TabIndex = 0;
            this.BtnProductList.Text = " Product List";
            this.BtnProductList.UseVisualStyleBackColor = false;
            this.BtnProductList.Click += new System.EventHandler(this.BtnProductList_Click);
            // 
            // LblEmployeeInfo
            // 
            this.LblEmployeeInfo.AutoSize = true;
            this.LblEmployeeInfo.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeeInfo.ForeColor = System.Drawing.Color.Blue;
            this.LblEmployeeInfo.Location = new System.Drawing.Point(244, 6);
            this.LblEmployeeInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEmployeeInfo.Name = "LblEmployeeInfo";
            this.LblEmployeeInfo.Size = new System.Drawing.Size(277, 27);
            this.LblEmployeeInfo.TabIndex = 0;
            this.LblEmployeeInfo.Text = "Employee Information";
            // 
            // lblShowName
            // 
            this.lblShowName.AutoSize = true;
            this.lblShowName.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowName.ForeColor = System.Drawing.Color.Blue;
            this.lblShowName.Location = new System.Drawing.Point(293, 10);
            this.lblShowName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(206, 27);
            this.lblShowName.TabIndex = 3;
            this.lblShowName.Text = "Employee Name";
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 471);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeeDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblEmployeeInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnProductList;
        private System.Windows.Forms.Button BtnUpdatePass;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Label lblShowName;
    }
}