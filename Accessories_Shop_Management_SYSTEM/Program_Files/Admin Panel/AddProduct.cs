using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Program_Files.Admin_Panel
{
    public partial class AddProduct : Form
    {
        private DataTable dt = new DataTable();
        private string barcode;

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
            dt.Columns.Add("Serial",typeof(int));
            dt.Columns.Add("Barcode");
            dt.Columns.Add("Type");
            dt.Columns.Add("BrandName");
            dt.Columns.Add("Model");
            dt.Columns.Add("Capacity");
            dt.Columns.Add("Frequency");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Buying Price");
            dt.Columns.Add("Discount");
            dt.Columns.Add("Regular Price");
            dt.Columns.Add("Updated Price");
            dt.Columns.Add("Status");
            dt.Columns.Add("Assign Date");
            dt.Columns.Add("Added By");
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

        private void AddProduct_Load(object sender, EventArgs e)
        {
            this.AddQuantiyValue();
            this.AddTableColumn();
        }

        private void cmbType_SelectedValueChanged(object sender, EventArgs e)
        {
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    this.Serial = 1;
                    Random rn = new Random();
                    this.Barcode = rn.Next(10000, 100000).ToString();
                    double updatedPrice = this.CalculateUpdatedPrice(Convert.ToDouble(txtDiscount.Text), Convert.ToDouble(txtRegularPrices.Text));

                    dt.Rows.Add(this.Serial, this.Barcode, cmbType.Text, cmbBrandName.Text, cmbModel.Text, cmbCapacity.Text, cmbFrequency.Text, cmbQuantity.Text, txtBuyingPrice.Text, txtDiscount.Text, txtRegularPrices.Text, updatedPrice.ToString(), cmbStatus.Text, dtpAssignDate.Text, "Munna");
                    dgvAddProduct.DataSource = dt;
                }
                catch (Exception ex) { }
            }

            else if (!IsValid())
            {
                MessageBox.Show("Fill all the required Field");                
            }
            

        }
    }
}
