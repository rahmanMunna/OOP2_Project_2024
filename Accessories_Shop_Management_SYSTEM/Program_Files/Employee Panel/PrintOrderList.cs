using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Files.Employee_Panel
{
    public partial class PrintOrderList : Form
    {
        private SellProduct Product
        { get; set; }  

        
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
            this.dgvPrintOrderList.DataSource = recivedTable;

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
    }
}
