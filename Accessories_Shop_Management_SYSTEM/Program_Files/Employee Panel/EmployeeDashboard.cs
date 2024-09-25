using Program_Files.Classes;
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

namespace Program_Files.Employee_Panel
{
    public partial class EmployeeDashBoard : Form
    {
        private LoginFrame loginFrame;
        public User User;
        public EmployeeDashBoard()
        {
            InitializeComponent();
        }
        public EmployeeDashBoard(LoginFrame login,User user) : this()
        {
            this.loginFrame = login;
            this.User = user;
            this.lblUserName.Text = "Welcome " + this.User.UserName;
        }
        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnProductList_Click(object sender, EventArgs e)
        {
            new SellProduct(this).Show();
            this.Hide();    
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            new UpdatePassword(this).Show();    
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.loginFrame.Show(); 
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
