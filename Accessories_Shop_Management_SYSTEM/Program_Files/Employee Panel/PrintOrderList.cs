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
using Program_Files.Classes;

namespace Program_Files.Employee_Panel
{
    public partial class PrintOrderList : Form
    {
        private SellProduct Product
        { get; set; }  
        private dynamic Dashboard { get; set; }
        
        private DataTable table {  get; set; }  
           
        private int BillPrice {  get; set; }
        
        private int BillDiscount { get; set; }  

        private int GrandTotal { get; set; }   
        
        private int SerialNO { get; set; }  

        private string CustomerName { get; set; }
        private string PaymentMethod {  get; set; } 
        private string CustomerPhoneNUmber { get; set; }

        private string ProductId { get; set; }  

        private string invoiceId;
        private string invoiceSerial;
        private string InvoiceId
        {
            set { this.invoiceId = "Invc-" + value + "-" + this.invoiceSerial; }
            get { return this.invoiceId; }
        }

        public PrintOrderList()
        {
            InitializeComponent();
        }

        private void PrintOrderList_Load(object sender, EventArgs e)
        {
            
        }
        public PrintOrderList(dynamic Dashboard,SellProduct product,DataTable recivedTable,int totalPrice,int totalDiscount,int grandTotal) : this()
        {
            this.Product = product;
            this.table = recivedTable;  
            this.BillPrice = totalPrice;
            this.BillDiscount = totalDiscount;
            this.GrandTotal = grandTotal;

            this.SerialNO = 0;

            lblShowTotal.Text = this.BillPrice.ToString();
            lblShowTotalDiscount.Text = this.BillDiscount.ToString();   
            lblShowGrandTotal.Text = this.GrandTotal.ToString();

            this.Dashboard = Dashboard;

            this.PopulateGridView();    


           

        }

        private void PopulateGridView()
        {
            int index;
            for(int r = 0; r < table.Rows.Count; r++)
            {
                index = dgvPrintOrderList.Rows.Add();
                for (int c =0; c < table.Columns.Count; c++)
                {
                    
                    dgvPrintOrderList.Rows[index].Cells[c].Value = table.Rows[r][c];
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Product.Visible = true;
            this.Hide();
            //Application.Exit();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void GenerateReport()
        {
            if (txtCustomerName.Text.Length > 0 && txtPhoneNumber.Text.Length > 0 && (rbBkash.Checked || rbCard.Checked || rbCash.Checked))
            {
                
                if (rbCash.Checked)
                {
                    this.PaymentMethod = rbCash.Text;
                }
                else if (rbBkash.Checked)
                {
                    this.PaymentMethod = rbBkash.Text;
                }
                else if (rbCard.Checked)
                {
                    this.PaymentMethod = rbCard.Text;
                }

                this.CustomerName = txtCustomerName.Text;
                this.CustomerPhoneNUmber = txtPhoneNumber.Text;
                string date = dtpOrderDate.Text;

                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream("D:/C#_Project_2024/Accessories_Shop_Management_SYSTEM/Invoice Reports/"+this.InvoiceId+".pdf", FileMode.Create));
                document.Open();
                Paragraph pTitle = new Paragraph("Invoice Id : "+this.InvoiceId+"\n\n");
                Paragraph p = new Paragraph("==========================================================================\n\n");
                Paragraph p1 = new Paragraph("Customer Name : " + this.CustomerName + "\n\n" + "Customer Phone Number : " + this.CustomerPhoneNUmber + "\n\n" + "Payment Method : " + this.PaymentMethod + "\n\n" + "Date : " + date + "\n\n"+"Sales Person : "+this.Dashboard.User.UserName+"\n\n"+"Bill Prepared By : "+this.Dashboard.User.UserName+"\n\n\n");
                Paragraph p3 = new Paragraph("---------------------------  Product Name - Quantity - Total Price - Total Discount------------------------\n\n");

                document.Add(pTitle);
                document.Add(p);
                document.Add(p1);
                document.Add(p3);

                string customerName = txtCustomerName.Text;
                string customerPhoneNumber = txtPhoneNumber.Text;

                foreach (DataGridViewRow row in this.dgvPrintOrderList.Rows)
                {
                    this.SerialNO = this.SerialNO + 1;
                    string productName = row.Cells["ProductName"].Value.ToString();
                    string quantity = row.Cells["Quantity"].Value.ToString();

                    string price = row.Cells["TotalPrice"].Value.ToString();
                    string discount = row.Cells["TotalDiscount"].Value.ToString();

                    document.Add(new Paragraph(this.SerialNO.ToString() + " ." + productName + "--------------------------------" + quantity + "---------------" + price + "--------------- " + discount));


                }
                Paragraph p5 = new Paragraph("\n\nTotal Price : " + this.BillPrice + "\n\n" + "Total Discount : " + this.BillDiscount + "\n\n" + "Grand Total : " + this.GrandTotal + "\n\n\n");
                Paragraph p6 = new Paragraph("=============================== PAID ===================================");

                document.Add(p5);
                document.Add(p6);
                document.Close();

                MessageBox.Show("Order Confirmed!\n\n Report has been Generated");
            }
            else
            {
                MessageBox.Show("Please Inser Customer Information & Payment Method");
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {

            try
            {
               
                string query = "Select top 1 serialNo from InvoiceTb order By serialNo DESC";


                DataTable table = DBAccess.ExecuteQuery(query);
                int invoiceSerial = (int)(table.Rows[0][0]);
                this.invoiceSerial = (++invoiceSerial).ToString();
                Random random = new Random();
                int randomNumber = random.Next(2000, 50000);
                this.InvoiceId = randomNumber.ToString();

                this.GenerateReport();



                string query2 = "insert into InvoiceTb values('" + this.InvoiceId + "','"+this.Dashboard.User.UserName+"','Paid'," + this.BillPrice + "," + this.BillDiscount + "," + this.GrandTotal + ",'" + dtpOrderDate.Text + "','" + this.CustomerName + "','" + this.CustomerPhoneNUmber + "','"+this.Dashboard.User.UserName+"','" + this.PaymentMethod + "') ;";
                int rowAffected = DBAccess.ExecuteDMLQuery(query2);

                if (rowAffected > 0)
                {
                    MessageBox.Show("Successfully added to DataBase");

                    foreach (var kpv in Product.UpdatedProductList)
                    {
                        string query3 = "Update Product2TB Set Quantity = '" + kpv.Value + "' where Barcode = '" + kpv.Key + "' ";
                        int rowgot = DBAccess.ExecuteDMLQuery(query3);
                        if (rowgot > 0)
                        {
                            MessageBox.Show("Successfully Updated into DB");
                        }
                        else
                        {
                            MessageBox.Show("Unable to update");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Unabled to Insert to DataBase");
                }

                Product.Visible = true;
                this.Hide();
            }

            catch (Exception ex) {
            
                MessageBox.Show(ex.Message);
            }

        }
    }
}
