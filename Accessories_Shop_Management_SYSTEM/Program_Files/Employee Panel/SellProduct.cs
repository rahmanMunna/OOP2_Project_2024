using System;
using System.Data;
using System.Windows.Forms;

namespace Program_Files.Employee_Panel
{
    public partial class SellProduct : Form
    {
        private DataTable dt1 = new DataTable();
        private DataTable dt2= new DataTable();
        private DataTable passDataTable= new DataTable();

        private string ProductName
        {
            get; set;   
        }
        public SellProduct()
        {
            InitializeComponent();
        }

        private void ResizeOfDataFridView()
        {
           for(int i=0;i<7;i++)
            {
                if(i == 2)
                {
                    continue;
                }
                dgvShowOrderList.Columns[i].Width = 240;
            }
            dgvShowOrderList.Columns[2].Width = 400;

            for (int i = 0; i < 11; i++)
            {
                
                dgvShowProduct.Columns[i].Width = 155;
            }
        }
        private void AddCollumn()
        {
            dt1.Columns.Add("Serial",typeof(int));
            dt1.Columns.Add("Product Id");
            dt1.Columns.Add("Component");
            dt1.Columns.Add("Brand Name");
            dt1.Columns.Add("Model");
            dt1.Columns.Add("Additional information");
            dt1.Columns.Add("Status");
            dt1.Columns.Add("Available Quantity",typeof(int));
            dt1.Columns.Add("Regular Price",typeof(int));
            dt1.Columns.Add("Discount",typeof(int));
            dt1.Columns.Add("Updated Price",typeof(int));


            dt2.Columns.Add("Serial",typeof(int));
            dt2.Columns.Add("Product ID");
            dt2.Columns.Add("Product Name");
            dt2.Columns.Add("Quantity");
            dt2.Columns.Add("Price per unit");
            dt2.Columns.Add("Total Discount");
            dt2.Columns.Add("Total Price");

            passDataTable.Columns.Add("Product Name");
            passDataTable.Columns.Add("Quantity");
            passDataTable.Columns.Add("Price");
            passDataTable.Columns.Add("Discount");

        }
        
        private void AddRowsProduct()
        {
            dt1.Rows.Add(1,"p-01","Proccessor","AMD","Ryzen 5600X","6 core,12 threades","Availabale",10,13000,0,13000);
            dt1.Rows.Add(2,"p-02","Proccessor","Intel","13900K","32 core,64 threades","Availabale",20,72000,50,36000);
            dt1.Rows.Add(3,"p-03","Proccessor","AMD","Ryzen 5700G","8 core,16 threades","Availabale",10,19000,0,19000);
        }
        
        private void SellProduct_Load(object sender, EventArgs e)
        {
            this.AddCollumn();
            
            dgvShowOrderList.DataSource = dt2;
            
            dgvShowProduct.DataSource = dt1;
            this.ResizeOfDataFridView();

            this.AddRowsProduct();
        }

        private void showQuantity(int lastNumber)
        {
            for(int i=1; i<=lastNumber; i++)
            {
                cmbQuantity.Items.Add(i);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {                
            try
            {
               if(cmbQuantity.Text.Length >0)
                {
                    int index = dgvShowProduct.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dgvShowProduct.Rows[index];
                    this.ProductName = selectedRow.Cells["Component"].Value + "-" + selectedRow.Cells["Brand Name"].Value + "-" + selectedRow.Cells["Model"].Value;
                    //this.showQuantity(Convert.ToInt32(selectedRow.Cells["Available Quantity"].Value));
                    int quantity = Convert.ToInt32(cmbQuantity.Text);
                    int availableQuantity = Convert.ToInt32(selectedRow.Cells["Available Quantity"].Value);

                    if (quantity <= availableQuantity)
                    {                        
                        int discountAmountPerUnit = Convert.ToInt32(selectedRow.Cells["Regular Price"].Value) - Convert.ToInt32(selectedRow.Cells["Updated Price"].Value);
                        int disCoountTotal = discountAmountPerUnit * quantity;
                        int totalPrice = Convert.ToInt32(selectedRow.Cells["Regular Price"].Value) * quantity - disCoountTotal;
                        selectedRow.Cells["Available Quantity"].Value = (availableQuantity - quantity);

                        dt2.Rows.Add(1, selectedRow.Cells["Product Id"].Value.ToString(), this.ProductName, quantity.ToString(), selectedRow.Cells["Regular Price"].Value.ToString(), disCoountTotal.ToString(), totalPrice.ToString());
                        cmbQuantity.SelectedIndex = -1;
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
            catch(Exception ex) {  }


        }
       private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = dgvShowOrderList.CurrentCell.RowIndex;


            foreach (DataGridViewRow row in dgvShowProduct.Rows)
            {
                if (row.Cells["Product Id"].Value.ToString() == dgvShowOrderList.Rows[index].Cells["Product Id"].Value.ToString())
                {
                    int x = Convert.ToInt32(dgvShowOrderList.Rows[index].Cells["Quantity"].Value);
                    row.Cells["Available Quantity"].Value = (Convert.ToInt32(row.Cells["Available Quantity"].Value) + x).ToString();

                }
            }
            dgvShowOrderList.Rows.RemoveAt(index);

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvShowOrderList.Rows)
            {
                string name = row.Cells["Product Name"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                int price = Convert.ToInt32(row.Cells["Price Per Unit"].Value) * quantity;
                int discount = Convert.ToInt32(row.Cells["Total Discount"].Value);

                passDataTable.Rows.Add(name.ToString(),quantity.ToString(),price.ToString(),discount.ToString());
            }


            new PrintOrderList(this,passDataTable).Visible = true;
            this.Visible = false;
        }
    }
}
