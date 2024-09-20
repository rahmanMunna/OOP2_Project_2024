using Program_Files.Admin_Panel;
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
        private Button ViewBtn;
        private Button logoutBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button CrossBtn;
        private Label label1;
        private LoginFrame loginFrame;
        public AdminDashboard()
        {
            InitializeComponent();
        }
        public AdminDashboard(LoginFrame loginFrame) : this()
        {
            this.loginFrame = loginFrame;
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            this.loginFrame.Visible = true;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            new AddEmployee(this).Visible = true;   
            this.Hide();
        }
    }
}
