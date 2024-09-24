using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program_Files.Employee_Panel;
using Program_Files.Login_Panel;

namespace Program_Files.Employee_Panel
{
    public partial class EmployeeDashboard : Form
    {
        private dynamic loginFrame;
        private dynamic user; 
        public EmployeeDashboard()
        {
            InitializeComponent();
        }
        public EmployeeDashboard(dynamic loginFrame,dynamic user) : this() 
        {
            this.loginFrame = loginFrame;
            this.user = user;
            this.lblShowName.Text = user.Username;
        }

        private void BtnProductList_Click(object sender, EventArgs e)
        {
            new SellProduct(this).Show();
            this.Hide();
        }

        private void BtnUpdatePass_Click(object sender, EventArgs e)
        {
            new UpdatePassword(this).Show();
            this.Hide();

        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            new LoginFrame().Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
