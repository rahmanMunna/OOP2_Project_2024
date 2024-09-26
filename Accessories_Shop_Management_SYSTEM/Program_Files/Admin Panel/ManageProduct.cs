using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program_Files.Classes;
using Program_Files.Classes;
using Program_Files.Dashboard;


namespace Program_Files.Admin_Panel
{
    public partial class ManageProduct : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=MUNNA\\SQLEXPRESS;Initial Catalog=Accessories_Management_Shop;Integrated Security=True");
        private DataTable table = new DataTable();

        private AdminDashboard adminDashboard;
        
        
        public ManageProduct()
        {
            InitializeComponent();
            this.PopulateGridView();
            this.PopulateComponentComboBox();
        }

        public ManageProduct(dynamic adminDashBoard) : this()
        {
            this.adminDashboard = adminDashBoard;
        }

        private void PopulateGridView(string query = "Select * from Product2TB")
        {                       
            dgvProductList.DataSource = DBAccess.ExecuteQuery(query);
            
        }

        private void PopulateComboBoxes(ComboBox cmbBox,string query)
        {
            DataTable table1 = new DataTable();
            table1 = DBAccess.ExecuteQuery(query);

            foreach(DataRow row in table1.Rows)
            {
                cmbBox.Items.Add(row[0].ToString());  
            }
        }

        private void PopulateComponentComboBox()
        {    
            string query = "SELECT ComponentName FROM Product2TB GROUP BY ComponentName";
            this.PopulateComboBoxes(cmbComponent,query); 
        }
   
        private void cmbComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridView();
            cmbModel.Items.Clear();
            cmbBrandName.Items.Clear();
            string query = "Select BrandName from Product2TB where ComponentName = '" + cmbComponent.Text + "' Group BY BrandName";
            this.PopulateComboBoxes(cmbBrandName,query);

        }

        private void cmbBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            string query = "Select Model from Product2TB where BrandName = '" + cmbBrandName.Text + "' Group BY Model";
            this.PopulateComboBoxes(cmbModel, query);
        }

        private void PopulateQuantity()
        {
            for(int i = 0; i < 200; i++)
            {
                cmbQuantity.Items.Add(i);
            }
        }

        private bool IsValid()
        {
            bool valid = true;

            foreach(Control control in pnlUpdateInfo.Controls)
            {
                if(control is TextBox && control.Text.Length == 0)
                {
                    valid = false; break;
                }
                else if(control is ComboBox && control.Text.Length == 0)
                {
                    valid = false; break;
                }

            }

            return valid;
        }
        private void ClearAllFields()
        {
            foreach(Control control in pnlUpdateInfo.Controls)
            {
                if(control is TextBox )
                {
                    control.Text = "";
                }
                else if(control is ComboBox )
                {
                    ComboBox comboBox = (ComboBox)control;  
                    comboBox.SelectedIndex = -1;
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new AddProduct().Visible = true;
            this.Hide();
        }
    
        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from Product2TB where ComponentName = '"+cmbComponent.Text+"' and BrandName = '"+cmbBrandName.Text+"' and Model = '"+cmbModel.Text+"'; ";
            this.PopulateGridView(query);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.PopulateGridView();
            cmbBrandName.Items.Clear();
            cmbModel.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvProductList.Rows.Count > 0)
                {
                    int index = dgvProductList.CurrentCell.RowIndex;
                    string selectedBarcode = dgvProductList.Rows[index].Cells["Barcode"].Value.ToString();

                    DialogResult result = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Check which button was clicked
                    if (result == DialogResult.Yes)
                    {
                        string query = "delete from Product2TB where Barcode = '" + selectedBarcode + "' ";
                        int rowAffected = DBAccess.ExecuteDMLQuery(query);
                        MessageBox.Show("Product has Been Deleted");
                        this.PopulateGridView();
                    }
                    else if (result == DialogResult.No)
                    {
                       return;
                    }

                    
                }
                else
                {
                    MessageBox.Show("No Product Available");
                }
            }
            catch (Exception ex) { }
        }


        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvProductList.Rows.Count > 0)
                {
                    this.pnlUpdateInfo.Enabled = true;
                    this.btnEdit.Enabled = false;
                    this.PopulateQuantity();

                    int index = dgvProductList.CurrentCell.RowIndex;

                    int discount = Convert.ToInt32(dgvProductList.Rows[index].Cells["Discount"].Value);
                    int regularPrice = Convert.ToInt32(dgvProductList.Rows[index].Cells["RegularPrice"].Value);


                    cmbWarranty.Text = dgvProductList.Rows[index].Cells["Warranty"].Value.ToString();
                    cmbStatus.Text = dgvProductList.Rows[index].Cells["Status"].Value.ToString();
                    //txtDiscount.Text = dgvProductList.Rows[index].Cells["Discount"].Value.ToString();
                   // txtRegularPrice.Text = dgvProductList.Rows[index].Cells["RegularPrice"].Value.ToString();
                    txtDiscount.Text = discount.ToString();
                    txtRegularPrice.Text = regularPrice.ToString();
                }
                else
                {
                    MessageBox.Show("No Product Available to Update");
                }
            }

            catch (Exception ex) { }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.pnlUpdateInfo.Enabled = false;
            this.btnEdit.Enabled = true;

            try
            {
                if(IsValid())
                {
                    int index = dgvProductList.CurrentCell.RowIndex;
                    string barcode = dgvProductList.Rows[index].Cells["Barcode"].Value.ToString();

                    int presentQuantity = Convert.ToInt32(dgvProductList.Rows[index].Cells["Quantity"].Value);
                    int addedQuantity = Convert.ToInt32(cmbQuantity.Text);
                    int updatedQuantity = presentQuantity + addedQuantity;
                    string updatedStatus = cmbStatus.Text;

                    int updatedDiscount = Convert.ToInt32(txtDiscount.Text);
                    int updatedRegularPrice = Convert.ToInt32(txtRegularPrice.Text);
                    int updatedPrice = (int)(Convert.ToDouble(updatedDiscount / 100) * Convert.ToDouble(updatedRegularPrice) + Convert.ToDouble(updatedRegularPrice));
                    string updatedWarranty = cmbWarranty.Text;  

                    

                    DialogResult result = MessageBox.Show("\"Are you Sure To update Information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Check which button was clicked
                    if (result == DialogResult.Yes)
                    {
                        int rowAffected;
                        if(updatedQuantity < 5)
                        {
                            string query = "UPDATE Product2TB SET  Quantity = " + updatedQuantity + " ,RegularPrice = " + updatedRegularPrice + ", Status = '" + updatedStatus + "',Discount= " + updatedDiscount + ", UpdatedPrice = " + updatedPrice + " ,Warranty = "+ updatedWarranty + ",OutOfStockStatus = "+1+"  WHERE Barcode = '" + barcode + "';";
                            rowAffected = DBAccess.ExecuteDMLQuery(query);
                        }
                        else
                        {
                            string query = "UPDATE Product2TB SET  Quantity = " + updatedQuantity + " ,RegularPrice = " + updatedRegularPrice + ", Status = '" + updatedStatus + "',Discount= " + updatedDiscount + ", UpdatedPrice = " + updatedPrice + " ,Warranty = " + updatedWarranty + " ,OutOfStockStatus = 0  WHERE Barcode = '" + barcode + "';";
                            rowAffected = DBAccess.ExecuteDMLQuery(query);  
                        }


                        if(rowAffected > 0 )
                        {
                            MessageBox.Show("Prodict Information has been Updated!");
                            this.PopulateGridView();
                        }
                        else if(rowAffected == 0)
                        {
                            MessageBox.Show("Prodict Information Couldn't Updated!");
                        }


                    }
                    else if (result == DialogResult.No)
                    {
                       return;
                    }

                }
                else
                {
                    MessageBox.Show("Please enter all Information");
                }

                this.ClearAllFields();

                
            }
            catch (Exception ex) { }

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.pnlUpdateInfo.Enabled = false;
            this.btnEdit.Enabled = true;

            this.cmbBrandName.SelectedIndex = -1;
            this.cmbModel.SelectedIndex = -1;
            this.cmbComponent.SelectedIndex = -1;
            this.cmbStatus.SelectedIndex = -1;
            this.cmbQuantity.SelectedIndex = -1;    
            this.cmbWarranty.SelectedIndex = -1;    
            txtDiscount.Text = string.Empty;
            txtRegularPrice.Text = string.Empty;    

            this.PopulateGridView();
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.adminDashboard.Show();
            this.Hide();
        }

        private void txtSearchByProduct_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from Product2TB where CONCAT(ComponentName,BrandName,model) like '%"+txtSearchByProduct.Text+"%' ;";
            this.PopulateGridView(query);
        }

        private void txtSearchByQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtSearchByQuantity.Text.Length != 0)
                {
                    string query = "Select * from Product2TB where quantity >= " + Convert.ToInt32(txtSearchByQuantity.Text) + " ;";
                    this.PopulateGridView(query);
                }
                else
                {
                    
                    this.PopulateGridView();
                }
            }
            catch (Exception ex) { }
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFrom.Text.Length != 0)
                {
                    string query = "Select * from Product2TB where updatedPrice >= " + Convert.ToInt32(txtFrom.Text) + " ;";
                    this.PopulateGridView(query);
                }
                else
                {

                    this.PopulateGridView();
                }
                

            }
            catch (Exception ex) { }
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFrom.Text.Length != 0)
                {
                    if (txtTo.Text.Length != 0)
                    {
                        string query = "Select * from Product2TB where updatedPrice <= " + Convert.ToInt32(txtTo.Text) + "and updatedPrice >=  "+Convert.ToInt32(txtFrom.Text)+" ;";
                        this.PopulateGridView(query);
                    }
                    else
                    {

                        string query = "Select * from Product2TB where updatedPrice >= " + Convert.ToInt32(txtFrom.Text) + " ;";
                        this.PopulateGridView(query);
                    }

                }
                else
                {
                    this.PopulateGridView();
                    MessageBox.Show("Enter Starting Price First");
                    txtTo.Text = string.Empty;      
                }


            }
            catch (Exception ex) { }
        }

   
    }
}
