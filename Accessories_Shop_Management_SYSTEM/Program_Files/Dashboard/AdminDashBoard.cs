using Program_Files.Admin_Panel;
using Program_Files.Classes;
using Program_Files.Employee_Panel;
using Program_Files.Login_Panel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Files.Dashboard
{
    public partial class AdminDashboard : Form
    {
        private Button btnAddEmployee;
        private Button btnManageProduct;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button CrossBtn;
        private LoginFrame loginFrame;
        internal dynamic User {  get; set; }    

        public AdminDashboard()
        {
            InitializeComponent();
            this.CheckNotificatino();
        }
        public AdminDashboard(LoginFrame loginFrame,dynamic user) : this()
        {
            this.loginFrame = loginFrame;
            this.User = user;
            this.lblUserName.Text = this.User.UserName;
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckNotificatino()
        {
            try
            {
                string query = "Select UpdatePasswordRequestStatus from UserTB where userid = 'A-Rahman-6' ";
                int status = Convert.ToInt32(DBAccess.ExecuteQuery(query).Rows[0][0]);


                if (status == 1)
                {
                    btnNotification.Text = "1";
                    this.btnNotification.Enabled = true;
                }
                else
                {
                    btnNotification.Text = "0";
                    this.btnNotification.Enabled = false;
                }
            }
            catch (Exception ex) { }
            

        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
           
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new AddProduct(this).Visible = true;
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.loginFrame.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            new AddEmployee(this).Visible = true;   
            this.Hide();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT CONCAT(ComponentName, '-', BrandName, '-', Model) AS ProductName FROM Product2TB where OutOfStockStatus = 1";
                DataTable dt = DBAccess.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    string name = "";
                    foreach (DataRow row in dt.Rows)
                    {
                        name = name + row["ProductName"].ToString() + ", ";
                    }
                    MessageBox.Show(name + " Is Ruuning out Of Stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("All Products are in Good ", "Exclamatory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex) { }
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            new ManageProduct(this).Show(); 
            this.Hide();
        }

        private void btnUpdatePasword_Click(object sender, EventArgs e)
        {
            new UpdatePassword(this).Show();
            this.Hide();
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            new ManageEmployee(this).Show();    
            this.Hide();    
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            new ShowInvoice(this).Show();
            this.Hide();    
        }
    }
}
