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
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOrderList = new System.Windows.Forms.Panel();
            this.lblShowGrandTotal = new System.Windows.Forms.Label();
            this.lblShowTotalDiscount = new System.Windows.Forms.Label();
            this.lblShowTotal = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCustomerInfo = new System.Windows.Forms.Panel();
            this.rbBkash = new System.Windows.Forms.RadioButton();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintOrderList)).BeginInit();
            this.pnlOrderList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrintOrderList
            // 
            this.dgvPrintOrderList.AllowUserToAddRows = false;
            this.dgvPrintOrderList.AllowUserToDeleteRows = false;
            this.dgvPrintOrderList.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvPrintOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrintOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Quantity,
            this.TotalPrice,
            this.TotalDiscount});
            this.dgvPrintOrderList.Location = new System.Drawing.Point(24, 23);
            this.dgvPrintOrderList.Name = "dgvPrintOrderList";
            this.dgvPrintOrderList.ReadOnly = true;
            this.dgvPrintOrderList.Size = new System.Drawing.Size(940, 364);
            this.dgvPrintOrderList.TabIndex = 0;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // TotalDiscount
            // 
            this.TotalDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalDiscount.HeaderText = "Total DIscount";
            this.TotalDiscount.Name = "TotalDiscount";
            this.TotalDiscount.ReadOnly = true;
            // 
            // pnlOrderList
            // 
            this.pnlOrderList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlOrderList.Controls.Add(this.lblShowGrandTotal);
            this.pnlOrderList.Controls.Add(this.lblShowTotalDiscount);
            this.pnlOrderList.Controls.Add(this.lblShowTotal);
            this.pnlOrderList.Controls.Add(this.lblGrandTotal);
            this.pnlOrderList.Controls.Add(this.lblDiscount);
            this.pnlOrderList.Controls.Add(this.lblTotal);
            this.pnlOrderList.Controls.Add(this.dgvPrintOrderList);
            this.pnlOrderList.Location = new System.Drawing.Point(66, 163);
            this.pnlOrderList.Name = "pnlOrderList";
            this.pnlOrderList.Size = new System.Drawing.Size(995, 569);
            this.pnlOrderList.TabIndex = 1;
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
            // lblGrandTotal
            // 
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(30, 525);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(170, 33);
            this.lblGrandTotal.TabIndex = 3;
            this.lblGrandTotal.Text = "Grand Total";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(513, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 88);
            this.panel2.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(61, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(361, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Order List";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCustomerInfo
            // 
            this.pnlCustomerInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCustomerInfo.Controls.Add(this.rbBkash);
            this.pnlCustomerInfo.Controls.Add(this.rbCard);
            this.pnlCustomerInfo.Controls.Add(this.rbCash);
            this.pnlCustomerInfo.Controls.Add(this.lblPayment);
            this.pnlCustomerInfo.Controls.Add(this.txtPhoneNumber);
            this.pnlCustomerInfo.Controls.Add(this.txtCustomerName);
            this.pnlCustomerInfo.Controls.Add(this.lblPhone);
            this.pnlCustomerInfo.Controls.Add(this.lblCustomerName);
            this.pnlCustomerInfo.Location = new System.Drawing.Point(1091, 172);
            this.pnlCustomerInfo.Name = "pnlCustomerInfo";
            this.pnlCustomerInfo.Size = new System.Drawing.Size(342, 496);
            this.pnlCustomerInfo.TabIndex = 5;
            // 
            // rbBkash
            // 
            this.rbBkash.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBkash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbBkash.Image = global::Program_Files.Properties.Resources.BKash__1_;
            this.rbBkash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbBkash.Location = new System.Drawing.Point(119, 447);
            this.rbBkash.Name = "rbBkash";
            this.rbBkash.Size = new System.Drawing.Size(109, 27);
            this.rbBkash.TabIndex = 14;
            this.rbBkash.TabStop = true;
            this.rbBkash.Text = "Bkash";
            this.rbBkash.UseVisualStyleBackColor = true;
            // 
            // rbCard
            // 
            this.rbCard.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbCard.Image = global::Program_Files.Properties.Resources.icons8_card_32;
            this.rbCard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbCard.Location = new System.Drawing.Point(185, 399);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(112, 27);
            this.rbCard.TabIndex = 13;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "Card";
            this.rbCard.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbCash.Image = global::Program_Files.Properties.Resources.icons8_cash_32;
            this.rbCash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbCash.Location = new System.Drawing.Point(45, 396);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(99, 32);
            this.rbCash.TabIndex = 12;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // lblPayment
            // 
            this.lblPayment.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(39, 345);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(258, 33);
            this.lblPayment.TabIndex = 11;
            this.lblPayment.Text = "Payment Mehtode";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(45, 254);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(252, 44);
            this.txtPhoneNumber.TabIndex = 10;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(45, 90);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(252, 44);
            this.txtCustomerName.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(39, 196);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(216, 33);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(39, 39);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(216, 33);
            this.lblCustomerName.TabIndex = 7;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Program_Files.Properties.Resources.icons8_back_button_32_2;
            this.btnBack.Location = new System.Drawing.Point(45, 33);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 50);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Cornsilk;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnConfirm.Image = global::Program_Files.Properties.Resources.icons8_checkmark_32;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirm.Location = new System.Drawing.Point(1136, 688);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(257, 51);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrderDate.Location = new System.Drawing.Point(1158, 127);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(235, 22);
            this.dtpOrderDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1091, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date :";
            // 
            // PrintOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1458, 790);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.pnlCustomerInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlOrderList);
            this.MaximizeBox = false;
            this.Name = "PrintOrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintOrderList";
            this.Load += new System.EventHandler(this.PrintOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintOrderList)).EndInit();
            this.pnlOrderList.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlCustomerInfo.ResumeLayout(false);
            this.pnlCustomerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrintOrderList;
        private System.Windows.Forms.Panel pnlOrderList;
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
        private System.Windows.Forms.Panel pnlCustomerInfo;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.RadioButton rbBkash;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDiscount;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label label1;
    }
}