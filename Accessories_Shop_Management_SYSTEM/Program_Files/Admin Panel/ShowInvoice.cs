using Program_Files.Classes;
using Program_Files.Dashboard;
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
    public partial class ShowInvoice : Form
    {
        private AdminDashboard adminDashboard {  get; set; }    
        public ShowInvoice()
        {
            InitializeComponent();
            this.PopulateGridView();
            this.CalculateTotalRevenue();
        }

        public ShowInvoice(dynamic dashboard) : this()
        {
            this.adminDashboard = dashboard;    
        }

        private void PopulateGridView(string query = "select * from InvoiceTb")
        {
            DataTable dt = DBAccess.ExecuteQuery(query);
            dgvInvoice.DataSource = dt;
        }
        private void ShowInvoice_Load(object sender, EventArgs e)
        {

        }
        private void CalculateTotalRevenue()
        {
            string query = "SELECT SUM(NetTotal) FROM InvoiceTb;";
            string revenue = DBAccess.ExecuteQuery(query).Rows[0][0].ToString();

            lblRevenue.Text = revenue;
        }

        private void txtSearchByPice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchByPice.Text.Length != 0)
                {
                    string query = "Select * from InvoiceTb where NetTotal >= " + Convert.ToInt32(txtSearchByPice.Text) + " ;";
                    this.PopulateGridView(query);
                }
                else
                {

                    this.PopulateGridView();
                }
            }
            catch (Exception ex) { }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.adminDashboard.Show();
            this.Hide();
        }
    }
}
