using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using Program_Files.Classes;

namespace Program_Files.Employee_Panel
{
    public partial class SellProduct : Form
    {
        private DataTable dt1 = new DataTable();
        private DataTable dt2= new DataTable();
        private DataTable passTable = new DataTable();

        internal Dictionary<string, int> UpdatedProductList = new Dictionary<string, int>();     
        internal int TotalOrederPrice {  get; set; }   
        internal int TotalGotDiscount {  get; set; }    
        internal int TotalQuantity {  get; set; }
        internal int GrandTotal {  get; set; }  

        
        internal int SerialNumber { get; set; }
        
        internal dynamic EmployeeDashboard { get; set; }
        


        private string ProductName
        {
            get; set;   
        }
        public SellProduct()
        {
            InitializeComponent();
            this.PopulateGridView();
            this.PopulateComponentComboBox();

            this.TotalOrederPrice = 0; 
            this.TotalQuantity = 0;
            this.GrandTotal = 0;
            this.TotalGotDiscount = 0;
            this.SerialNumber  = 0; 

        }

        public SellProduct(dynamic dashboard) : this()
        {
            this.EmployeeDashboard = dashboard;
        }

        private void PopulateGridView(string query = "SELECT SerialNo,Barcode,ComponentName,BrandName,Model,Capacity,Frequency,Status,Quantity,RegularPrice,Discount,UpdatedPrice FROM Product2TB WHERE Status = 'Available';")
        {
            dt1 = DBAccess.ExecuteQuery(query);
            dgvShowProduct.DataSource = dt1;
        }

        private void PopulateComboBoxes(ComboBox cmbBox, string query)
        {
            DataTable table1 = new DataTable();
            table1 = DBAccess.ExecuteQuery(query);

            foreach (DataRow row in table1.Rows)
            {
                cmbBox.Items.Add(row[0].ToString());
            }
        }

        private void PopulateComponentComboBox()
        {
            string query = "SELECT ComponentName FROM Product2TB GROUP BY ComponentName";
            this.PopulateComboBoxes(cmbComponent, query);
        }
       

        private void showQuantity(int lastNumber)
        {
            for(int i=1; i<=lastNumber; i++)
            {
                cmbQuantity.Items.Add(i);
            }
        }

        private void ShowTotal()
        {
            this.lblShowTotal.Text = this.TotalOrederPrice.ToString();
            this.lblShowQuantity.Text = this.TotalQuantity.ToString();
            this.lblShowDiscount.Text = this.TotalGotDiscount.ToString();
            this.lblShowGrandTotal.Text = this.GrandTotal.ToString();
        }

        private void PopulatePassTableColumn()
        {
            passTable.Columns.Add("Name");
            passTable.Columns.Add("Quantity");
            passTable.Columns.Add("Totgal Price");
            passTable.Columns.Add("Total Discount");
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbQuantity.Text.Length > 0)
                {
                    this.SerialNumber = SerialNumber + 1;

                    int index = dgvShowProduct.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dgvShowProduct.Rows[index];
                    this.ProductName = selectedRow.Cells["ComponentName"].Value + "-" + selectedRow.Cells["BrandName"].Value + "-" + selectedRow.Cells["Model"].Value;
                    
                    int quantity = Convert.ToInt32(cmbQuantity.Text);
                    int availableQuantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);

                    if (quantity <= availableQuantity)
                    {

                        int discountAmountPerUnit = Convert.ToInt32((Convert.ToDouble(selectedRow.Cells["Discount"].Value) / 100) * Convert.ToDouble(selectedRow.Cells["RegularPrice"].Value));
                        
                        int disCountTotal = discountAmountPerUnit * quantity;
                        int totalPrice = Convert.ToInt32(selectedRow.Cells["RegularPrice"].Value) * quantity;
                        selectedRow.Cells["Quantity"].Value = (availableQuantity - quantity);

                        this.UpdatedProductList.Add(selectedRow.Cells["Barcode"].Value.ToString(), (availableQuantity - quantity));

                        

                        //creating a new row
                        int rowIndex = dgvShowOrderList.Rows.Add();
                        
                        dgvShowOrderList.Rows[rowIndex].Cells[0].Value = this.SerialNumber.ToString();
                        dgvShowOrderList.Rows[rowIndex].Cells[1].Value = selectedRow.Cells["Barcode"].Value.ToString();
                        dgvShowOrderList.Rows[rowIndex].Cells[2].Value = this.ProductName;
                        dgvShowOrderList.Rows[rowIndex].Cells[3].Value = quantity.ToString();
                        dgvShowOrderList.Rows[rowIndex].Cells[4].Value = selectedRow.Cells["RegularPrice"].Value.ToString();                      
                        dgvShowOrderList.Rows[rowIndex].Cells[5].Value = totalPrice.ToString();
                        dgvShowOrderList.Rows[rowIndex].Cells[6].Value = disCountTotal.ToString();

                        cmbQuantity.SelectedIndex = -1;

                        //updating Calculation
                        this.TotalOrederPrice += totalPrice;
                        this.TotalQuantity += quantity;
                        this.TotalGotDiscount += disCountTotal;
                        this.GrandTotal = this.TotalOrederPrice - this.TotalGotDiscount;

                        //show to label
                        this.ShowTotal();
                        

                    }
                    else
                    {
                        MessageBox.Show("Not enough Unit available");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Quantity");
                }

            }
            catch (Exception ex) { }


        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvShowOrderList.Rows.Count > 0)
                {
                    int index = dgvShowOrderList.CurrentCell.RowIndex;

                    int totalPrice = Convert.ToInt32(dgvShowOrderList.Rows[index].Cells["TotalPrice"].Value);
                    int quantity = Convert.ToInt32(dgvShowOrderList.Rows[index].Cells["pQuantity"].Value);
                    int disCountTotal = Convert.ToInt32(dgvShowOrderList.Rows[index].Cells["TotalDiscount"].Value);

                    //returning back the quantity to main list
                    foreach (DataGridViewRow row in dgvShowProduct.Rows)
                    {
                        if (row.Cells["Barcode"].Value.ToString() == dgvShowOrderList.Rows[index].Cells["pBarcode"].Value.ToString())
                        {
                            row.Cells["Quantity"].Value = (Convert.ToInt32(row.Cells["Quantity"].Value) + quantity).ToString();

                        }
                    }

                    dgvShowOrderList.Rows.RemoveAt(index);
                    MessageBox.Show("Product Has been Removed");

                    //updating Calculation
                    this.TotalOrederPrice -= totalPrice;
                    this.TotalQuantity -= quantity;
                    this.TotalGotDiscount -= disCountTotal;
                    this.GrandTotal = this.TotalOrederPrice - this.TotalGotDiscount;

                    //show to label
                    this.ShowTotal();
                }
                else
                {
                    MessageBox.Show("No Product Available for Remove");
                }
            }

            catch (Exception ex) { }

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowOrderList.Rows.Count > 0)
                {
                    this.PopulatePassTableColumn();

                    foreach (DataGridViewRow row in dgvShowOrderList.Rows)
                    {
                        string name = row.Cells["pName"].Value.ToString();
                        int quantity = Convert.ToInt32(row.Cells["pQuantity"].Value);
                        int price = Convert.ToInt32(row.Cells["PricePerUnit"].Value) * quantity;
                        int discount = Convert.ToInt32(row.Cells["TotalDiscount"].Value);

                        
                        passTable.Rows.Add(name.ToString(),quantity.ToString(),price.ToString(),discount.ToString());

                    }



                    new PrintOrderList(EmployeeDashboard, this, passTable, TotalOrederPrice, TotalGotDiscount, GrandTotal).Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("No Product has been Selected");
                }

                   
            }
            catch(Exception ex) {
            
                MessageBox.Show(ex.Message);
            } 
            
        }



        //Show Quantity in cmbBox based on selecting product;
        private void dgvShowProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbQuantity.Items.Clear();

            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvShowProduct.Rows[index];
            int maxQuantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);

            for(int i=1; i <= maxQuantity; i++)
            {
                cmbQuantity.Items.Add(i);
            }
        }
      
        private void cmbComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridView();
            cmbModel.Items.Clear();
            cmbBrandName.Items.Clear();
            string query = "Select BrandName from Product2TB where ComponentName = '" + cmbComponent.Text + "' Group BY BrandName";
            this.PopulateComboBoxes(cmbBrandName, query);
        }

        private void cmbBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            string query = "Select Model from Product2TB where BrandName = '" + cmbBrandName.Text + "' Group BY Model";
            this.PopulateComboBoxes(cmbModel, query);
        }
        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select SerialNo,Barcode,ComponentName,BrandName,Model,Capacity,Frequency,Status,Quantity,RegularPrice,Discount,UpdatedPrice from Product2TB where ComponentName = '" + cmbComponent.Text + "' and BrandName = '" + cmbBrandName.Text + "' and Model = '" + cmbModel.Text + "'; ";
            this.PopulateGridView(query);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            cmbBrandName.Items.Clear();
            cmbModel.Items.Clear(); 
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SellProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.EmployeeDashboard.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
