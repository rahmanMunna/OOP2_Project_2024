using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program_Files.Classes;
using Program_Files.Dashboard;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using Org.BouncyCastle.Asn1.Icao;


namespace Program_Files.Admin_Panel
{
    public partial class AddProduct : Form
    {
        private DataTable dt = new DataTable();
        private string barcode;
        private ComponentList component = new ComponentList();
        private AdminDashboard adminDashboard;
        private int serialNo;
        //private Random random = new Random();

        private SqlConnection connection = new SqlConnection("Data Source=MUNNA\\SQLEXPRESS;Initial Catalog=Accessories_Management_Shop;Integrated Security=True");

        

        private int Serial {  get; set; }   
        private string Barcode
        {
            get { return this.barcode; }
            set 
            {
                this.barcode = "p-" + value + "-" + this.Serial.ToString();
            }
        }

        //for numbering
        private void AddQuantiyValue()
        {
            for(int c =1;c<500;c++)
            {
                this.cmbQuantity.Items.Add(c);
            }
        }
        
        //preparing DataTable for Grid
        private void AddTableColumn()
        {
            //dt.Columns.Add("Serial",typeof(int));
            dt.Columns.Add("Barcode");
            dt.Columns.Add("Component");
            dt.Columns.Add("BrandName");
            dt.Columns.Add("Model");
            dt.Columns.Add("Capacity");
            dt.Columns.Add("Frequency");
            dt.Columns.Add("Warranty");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Buying Price");           
            dt.Columns.Add("Regular Price");
            dt.Columns.Add("Discount");
            dt.Columns.Add("Updated Price");
            dt.Columns.Add("Status");
            dt.Columns.Add("Assign Date");
            dt.Columns.Add("Added By");
           
        }

        //internal void Exist(params string[]value)
        //{
        //    connection.Open();
        //    string query = "SELECT ComponentName,BrandName,Model,Capacity,Frequency FROM Product2TB WHERE ComponentName = @componen";
        //    SqlCommand cmd = new SqlCommand();
        //}
        internal int GetLastRowSerialNo()
        {

            connection.Open();
            string query = "SELECT TOP 1  SerialNo from Product2TB ORDER BY SerialNo DESC";
            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                var x = cmd.ExecuteScalar();
                connection.Close();
                return (int)x;
            }
            catch(Exception ex)
            {
                return 1;
            }
            
        }
        public double CalculateUpdatedPrice(double discunt,double regularPrice)
        {
            return regularPrice - (discunt) / 100 * regularPrice;
          
        }

        //VAlidation
        private bool IsValid()
        {
            bool valid = true;
            foreach (Control control in this.pnlFields.Controls)
            {
                if (control is TextBox && control.Text.Length == 0) 
                {
                       valid = false;
                       break;
          
                }
                else if (control is ComboBox && control.Text.Length == 0)
                {
                    valid = false;
                    break;

                }
                else if (control is DateTimePicker && control.Text.Length == 0)
                {
                    valid = false;
                    break;

                }

            }
            return valid;
        }
        public AddProduct()
        {
            InitializeComponent();
        }
        public AddProduct(AdminDashboard adminDashboard) : this()
        {
           this.adminDashboard = adminDashboard;
        }
        private void AddProduct_Load(object sender, EventArgs e)
        {
            this.AddQuantiyValue();
            this.AddTableColumn();
            serialNo = this.GetLastRowSerialNo();
            this.dgvAddProduct.DataSource = dt;
        }
        
        internal void ShowModel(string selectedBrand)
        {
            string componentName = cmbType.Text.ToLower();

            if(componentName == "proccessor")
            {
                List<string> models = component.processors[selectedBrand];

                foreach (var model in models)
                {
                    cmbModel.Items.Add(model);
                }

            }
            else if(componentName == "gpu")
            {
                List<string> models = component.gpus[selectedBrand];

                foreach (var model in models)
                {
                    cmbModel.Items.Add(model);
                }
            }
            else if (componentName == "ram")
            {
                List<string> models = component.ram[selectedBrand];

                foreach (var model in models)
                {
                    cmbModel.Items.Add(model);
                }
            }
            else if (componentName == "ssd")
            {
                List<string> models = component.ssds[selectedBrand];

                foreach (var model in models)
                {
                    cmbModel.Items.Add(model);
                }

            }
            else if (componentName == "keyboard")
            {
                List<string> models = component.keyboards[selectedBrand];

                foreach (var model in models)
                {
                    cmbModel.Items.Add(model);
                }
            }

            else if (componentName == "mouse")
            {
                List<string> models = component.mouse[selectedBrand];

                foreach (var model in models)
                {
                    cmbModel.Items.Add(model);
                }
            }
            else if (componentName == "motherboard")
            {
                List<string> models = component.motherboards[selectedBrand];

                foreach (var model in models)
                {
                    cmbModel.Items.Add(model);
                }
            }
            else if (componentName == "monitor")
            {
                List<string> models = component.monitors[selectedBrand];

                foreach (var model in models)
                {
                    cmbModel.Items.Add(model);
                }
            }
        }
       
        internal void ShowBrandName(string selectedItem)
        {
            cmbBrandName.SelectedIndex = -1;
            if (selectedItem == "proccessor")
            {
                
                foreach (var keys in component.processors)
                {
                    
                    cmbBrandName.Items.Add(keys.Key);
                }
                
            }
            else if (selectedItem == "gpu")
            {
                
                foreach (var keys in component.gpus)
                {
                    cmbBrandName.Items.Add(keys.Key);
                }
            }
            else if (selectedItem == "mouse")
            {
                
                foreach (var keys in component.mouse)
                {
                    cmbBrandName.Items.Add(keys.Key);
                }
            }
            else if (selectedItem == "keyboard")
            {
                
                foreach (var keys in component.keyboards)
                {
                    cmbBrandName.Items.Add(keys.Key);
                }
            }
            else if (selectedItem == "monitor")
            {
                
                foreach (var keys in component.monitors)
                {
                    cmbBrandName.Items.Add(keys.Key);
                }
            }
            else if (selectedItem == "ram")
            {
                
                foreach (var keys in component.ram)
                {
                    cmbBrandName.Items.Add(keys.Key);
                }
            }
            else if (selectedItem == "ssd")
            {
               
                foreach (var keys in component.ssds)
                {
                    cmbBrandName.Items.Add(keys.Key);
                }
            }
            else if (selectedItem == "motherboard")
            {
                
                foreach (var keys in component.motherboards)
                {
                    cmbBrandName.Items.Add(keys.Key);
                }
            }
            else
            {
                cmbBrandName.SelectedIndex = -1;
            }
        }
        private void cmbType_SelectedValueChanged(object sender, EventArgs e)
        {

            cmbBrandName.Items.Clear();
            string selectedItem = this.cmbType.Text.ToLower();
            if (this.cmbType.Text == "RAM" || this.cmbType.Text == "SSD")
            {
                this.pnlAdditional.Visible = true;
                if(this.cmbType.Text == "SSD")
                {
                    this.cmbFrequency.Enabled = false;
                    this.lblFrequency.Enabled = false;
                }
            }
            else
            {
                this.pnlAdditional.Visible = false;
            }

            this.ShowBrandName(selectedItem);
           //this.cmbBrandName.SelectedIndex = -1;
            
            


        }

        internal void ClearAllField()
        {
            foreach(Control control in pnlFields.Controls)
            {
                if(control is TextBox)
                {
                    control.Text = string.Empty;    
                }
                else if(control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = -1;
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {                                      
                    this.Serial = serialNo;
                    serialNo++;
                    Random rn = new Random();
                    this.Barcode = rn.Next(10000, 100000).ToString();
                    double updatedPrice = this.CalculateUpdatedPrice(Convert.ToDouble(txtDiscount.Text), Convert.ToDouble(txtRegularPrices.Text));

                    dt.Rows.Add(this.Barcode, cmbType.Text, cmbBrandName.Text, cmbModel.Text, cmbCapacity.Text, cmbFrequency.Text,cmbWarranty.Text, cmbQuantity.Text, txtBuyingPrice.Text,  txtRegularPrices.Text, txtDiscount.Text, updatedPrice.ToString(), cmbStatus.Text, dtpAssignDate.Text, "Munna");
                    dgvAddProduct.DataSource = dt;

                    this.ClearAllField();

                    

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (!IsValid())
            {
                MessageBox.Show("Fill all the required Field");                
            }


            

        }

        private void cmbBrandName_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            this.ShowModel(cmbBrandName.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.adminDashboard.Visible  = true;
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (dgvAddProduct.Rows.Count >1)
            {
                try
                {

                   
                    for(int i = 0;i < dgvAddProduct.Rows.Count-1;i++) 
                    {
                        MessageBox.Show(dgvAddProduct.RowCount.ToString());
                        MessageBox.Show(dgvAddProduct.Rows.Count.ToString());
                        string query = "INSERT INTO Product2TB values(@barcode,@component,@brandName,@model,@capacity,@frequency,@warranty,@quantity,@buyingPrice,@regularPrice,@discount,@updatedPrice,@status,@addedBy,@assignDate,@outOfStock)";

                        connection.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, connection);
                        DataGridViewRow row = dgvAddProduct.Rows[i];
                        MessageBox.Show(row.Cells[0].Value.ToString());
                        

                        sqlCommand.Parameters.AddWithValue("@barcode", row.Cells["Barcode"].Value.ToString());
                        sqlCommand.Parameters.AddWithValue("@component", row.Cells["Component"].Value.ToString());
                        sqlCommand.Parameters.AddWithValue("@brandName", row.Cells["BrandName"].Value.ToString());
                        sqlCommand.Parameters.AddWithValue("@model", row.Cells["Model"].Value.ToString());
                        sqlCommand.Parameters.AddWithValue("@capacity", row.Cells["Capacity"].Value.ToString());
                        sqlCommand.Parameters.AddWithValue("@frequency", row.Cells["Frequency"].Value.ToString());
                        sqlCommand.Parameters.AddWithValue("@warranty", Convert.ToInt32(row.Cells["Warranty"].Value));
                        sqlCommand.Parameters.AddWithValue("@quantity", Convert.ToInt32(row.Cells["Quantity"].Value));
                        sqlCommand.Parameters.AddWithValue("@buyingPrice", Convert.ToInt32(row.Cells["buying Price"].Value));
                        sqlCommand.Parameters.AddWithValue("@regularPrice", Convert.ToInt32(row.Cells["Regular Price"].Value));
                        sqlCommand.Parameters.AddWithValue("@discount", Convert.ToInt32(row.Cells["Discount"].Value));
                        sqlCommand.Parameters.AddWithValue("@updatedPrice", Convert.ToInt32(row.Cells["Updated Price"].Value));
                        sqlCommand.Parameters.AddWithValue("@status", row.Cells["Status"].Value.ToString());
                        sqlCommand.Parameters.AddWithValue("@assignDate", row.Cells["Assign Date"].Value.ToString()) ;
                        sqlCommand.Parameters.AddWithValue("@addedBy", row.Cells["Added By"].Value.ToString());

                        if (Convert.ToInt32(row.Cells["Quantity"].Value) > 5)
                        {
                            sqlCommand.Parameters.AddWithValue("@outOfStock", 0);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@outOfStock", 1);
                        }
                      
                        sqlCommand.ExecuteNonQuery();                       
                        connection.Close();
                        
                
                    }

                    MessageBox.Show("All Products are Inserted To DataBase Successfully!!!");
                    ((DataTable)dgvAddProduct.DataSource).Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }

            else
            {
                MessageBox.Show("No Data Available for Insert");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
