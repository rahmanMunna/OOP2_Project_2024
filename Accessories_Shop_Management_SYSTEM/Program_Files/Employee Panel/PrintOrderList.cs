using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Program_Files.Employee_Panel
{
    public partial class PrintOrderList : Form
    {
        private SellProduct Product
        { get; set; }  

        private DataTable table;
           


        public PrintOrderList()
        {
            InitializeComponent();
        }

        private void PrintOrderList_Load(object sender, EventArgs e)
        {
            
        }
        public PrintOrderList(SellProduct product,DataTable recivedTable) : this()
        {
            this.Product = product;
            this.table = recivedTable;  
            this.dgvPrintOrderList.DataSource = recivedTable;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Product.Visible = true;
            //this.Hide();
            Application.Exit();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("D:/Invoice.pdf", FileMode.Create));
            document.Open();
            Paragraph p = new Paragraph("==========================================================================");
            //Paragraph p1 = new Paragraph("Product Name                                             Quantity                       Price                            Discount");

            document.Add(p);
           


            string customerName = txtCustomerName.Text;
            string customerPhoneNumber = txtPhone.Text;

            foreach (DataGridViewRow row in this.dgvPrintOrderList.Rows)
            {
                string productName = row.Cells["Product Name"].Value.ToString();
                string quantity = row.Cells["Quantity"].Value.ToString();
                string price = row.Cells["Price"].Value.ToString();
                string discount = row.Cells["Discount"].Value.ToString();
                
                document.Add(new Paragraph(productName + "--------------------------------" + quantity + "------------------------" + price + "------------------- " + discount));


            }
            document.Close();



        }
    }
}
