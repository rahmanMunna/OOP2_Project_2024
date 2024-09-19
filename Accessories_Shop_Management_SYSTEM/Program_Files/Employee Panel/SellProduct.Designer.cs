namespace Program_Files.Employee_Panel
{
    partial class SellProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbBrandName = new System.Windows.Forms.ComboBox();
            this.cmbComponent = new System.Windows.Forms.ComboBox();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvShowProduct = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlShowProduct = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvShowOrderList = new System.Windows.Forms.DataGridView();
            this.lblPlaceOrderList = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProduct)).BeginInit();
            this.pnlShowProduct.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(642, 11);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(544, 80);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(525, 68);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product List";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbModel);
            this.panel3.Controls.Add(this.cmbBrandName);
            this.panel3.Controls.Add(this.cmbComponent);
            this.panel3.Location = new System.Drawing.Point(28, 103);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 65);
            this.panel3.TabIndex = 1;
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Items.AddRange(new object[] {
            "RAM"});
            this.cmbModel.Location = new System.Drawing.Point(309, 13);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 32);
            this.cmbModel.TabIndex = 2;
            // 
            // cmbBrandName
            // 
            this.cmbBrandName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrandName.FormattingEnabled = true;
            this.cmbBrandName.Location = new System.Drawing.Point(162, 13);
            this.cmbBrandName.Name = "cmbBrandName";
            this.cmbBrandName.Size = new System.Drawing.Size(121, 32);
            this.cmbBrandName.TabIndex = 1;
            // 
            // cmbComponent
            // 
            this.cmbComponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComponent.FormattingEnabled = true;
            this.cmbComponent.Location = new System.Drawing.Point(12, 13);
            this.cmbComponent.Name = "cmbComponent";
            this.cmbComponent.Size = new System.Drawing.Size(121, 32);
            this.cmbComponent.TabIndex = 0;
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuantity.FormattingEnabled = true;
            this.cmbQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "10",
            "11",
            "12",
            "13"});
            this.cmbQuantity.Location = new System.Drawing.Point(23, 14);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(121, 32);
            this.cmbQuantity.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbQuantity);
            this.panel1.Location = new System.Drawing.Point(1618, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 65);
            this.panel1.TabIndex = 1;
            // 
            // dgvShowProduct
            // 
            this.dgvShowProduct.AllowUserToAddRows = false;
            this.dgvShowProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvShowProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowProduct.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvShowProduct.Location = new System.Drawing.Point(18, 14);
            this.dgvShowProduct.Name = "dgvShowProduct";
            this.dgvShowProduct.ReadOnly = true;
            this.dgvShowProduct.Size = new System.Drawing.Size(1721, 248);
            this.dgvShowProduct.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1625, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 47);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlShowProduct
            // 
            this.pnlShowProduct.Controls.Add(this.btnAdd);
            this.pnlShowProduct.Controls.Add(this.dgvShowProduct);
            this.pnlShowProduct.Location = new System.Drawing.Point(28, 183);
            this.pnlShowProduct.Margin = new System.Windows.Forms.Padding(2);
            this.pnlShowProduct.Name = "pnlShowProduct";
            this.pnlShowProduct.Size = new System.Drawing.Size(1751, 329);
            this.pnlShowProduct.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.dgvShowOrderList);
            this.panel2.Location = new System.Drawing.Point(28, 589);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1751, 289);
            this.panel2.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(1592, 227);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(147, 47);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvShowOrderList
            // 
            this.dgvShowOrderList.AllowUserToAddRows = false;
            this.dgvShowOrderList.AllowUserToDeleteRows = false;
            this.dgvShowOrderList.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvShowOrderList.ColumnHeadersHeight = 40;
            this.dgvShowOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowOrderList.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvShowOrderList.Location = new System.Drawing.Point(18, 14);
            this.dgvShowOrderList.Name = "dgvShowOrderList";
            this.dgvShowOrderList.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowOrderList.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvShowOrderList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvShowOrderList.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvShowOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowOrderList.Size = new System.Drawing.Size(1721, 195);
            this.dgvShowOrderList.TabIndex = 0;
            // 
            // lblPlaceOrderList
            // 
            this.lblPlaceOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceOrderList.Location = new System.Drawing.Point(47, 530);
            this.lblPlaceOrderList.Name = "lblPlaceOrderList";
            this.lblPlaceOrderList.Size = new System.Drawing.Size(264, 46);
            this.lblPlaceOrderList.TabIndex = 1;
            this.lblPlaceOrderList.Text = "Placed Order List : ";
            this.lblPlaceOrderList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(1444, 117);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(169, 37);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(793, 906);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(223, 47);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::Program_Files.Properties.Resources.icons8_back_button_32_2;
            this.btnBack.Location = new System.Drawing.Point(28, 917);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 52);
            this.btnBack.TabIndex = 7;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // SellProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1814, 981);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPlaceOrderList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlShowProduct);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "SellProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellProduct";
            this.Load += new System.EventHandler(this.SellProduct_Load);
            this.pnlTitle.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProduct)).EndInit();
            this.pnlShowProduct.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbBrandName;
        private System.Windows.Forms.ComboBox cmbComponent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvShowProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlShowProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvShowOrderList;
        private System.Windows.Forms.Label lblPlaceOrderList;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnBack;
    }
}