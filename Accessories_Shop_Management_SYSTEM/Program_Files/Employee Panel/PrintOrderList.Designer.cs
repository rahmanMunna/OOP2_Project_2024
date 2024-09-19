namespace Program_Files.Employee_Panel
{
    partial class PrintOrderList
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
            this.dgvPrintOrderList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblShowTotal = new System.Windows.Forms.Label();
            this.lblShowTotalDiscount = new System.Windows.Forms.Label();
            this.lblShowGrandTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintOrderList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrintOrderList
            // 
            this.dgvPrintOrderList.AllowUserToAddRows = false;
            this.dgvPrintOrderList.AllowUserToDeleteRows = false;
            this.dgvPrintOrderList.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvPrintOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrintOrderList.Location = new System.Drawing.Point(24, 23);
            this.dgvPrintOrderList.Name = "dgvPrintOrderList";
            this.dgvPrintOrderList.ReadOnly = true;
            this.dgvPrintOrderList.Size = new System.Drawing.Size(940, 364);
            this.dgvPrintOrderList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblShowGrandTotal);
            this.panel1.Controls.Add(this.lblShowTotalDiscount);
            this.panel1.Controls.Add(this.lblShowTotal);
            this.panel1.Controls.Add(this.lblGrandTotal);
            this.panel1.Controls.Add(this.lblDiscount);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.dgvPrintOrderList);
            this.panel1.Location = new System.Drawing.Point(247, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 569);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(513, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 88);
            this.panel2.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(85, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(307, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Order List";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Cornsilk;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnConfirm.Location = new System.Drawing.Point(599, 741);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(257, 51);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Program_Files.Properties.Resources.icons8_back_button_32_2;
            this.btnBack.Location = new System.Drawing.Point(72, 741);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 50);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(30, 418);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(127, 33);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total (+)";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(30, 472);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(230, 33);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Total DIscount (-)";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(30, 525);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(170, 33);
            this.lblGrandTotal.TabIndex = 3;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // lblShowTotal
            // 
            this.lblShowTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTotal.Location = new System.Drawing.Point(837, 418);
            this.lblShowTotal.Name = "lblShowTotal";
            this.lblShowTotal.Size = new System.Drawing.Size(127, 33);
            this.lblShowTotal.TabIndex = 4;
            this.lblShowTotal.Text = "00";
            this.lblShowTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShowTotalDiscount
            // 
            this.lblShowTotalDiscount.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTotalDiscount.Location = new System.Drawing.Point(837, 472);
            this.lblShowTotalDiscount.Name = "lblShowTotalDiscount";
            this.lblShowTotalDiscount.Size = new System.Drawing.Size(127, 33);
            this.lblShowTotalDiscount.TabIndex = 5;
            this.lblShowTotalDiscount.Text = "00";
            this.lblShowTotalDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShowGrandTotal
            // 
            this.lblShowGrandTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowGrandTotal.Location = new System.Drawing.Point(837, 524);
            this.lblShowGrandTotal.Name = "lblShowGrandTotal";
            this.lblShowGrandTotal.Size = new System.Drawing.Size(127, 33);
            this.lblShowGrandTotal.TabIndex = 6;
            this.lblShowGrandTotal.Text = "00";
            this.lblShowGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PrintOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1465, 821);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "PrintOrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintOrderList";
            this.Load += new System.EventHandler(this.PrintOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintOrderList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrintOrderList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblShowTotal;
        private System.Windows.Forms.Label lblShowGrandTotal;
        private System.Windows.Forms.Label lblShowTotalDiscount;
    }
}