using Program_Files.Classes;
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
    public partial class UpdatePassword : Form
    {
        internal dynamic DashBoard {  get; set; }  
        public UpdatePassword(dynamic board)
        {
            InitializeComponent();
            this.DashBoard = board;
        }

        

        private void UpdatePassword_Load(object sender, EventArgs e)
        {
            
        }

        
        private void btnconfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select Password from UserTB where userID = 'E-Maria-7'";
                string oldPassword = DBAccess.ExecuteQuery(query).Rows[0][0].ToString();

                if (oldPassword == txtOldPassword.Text)
                {
                    if (txtNewPassword.Text == txtConfirmPassword.Text)
                    {
                        string query2 = "Update UserTB set password = '" + txtConfirmPassword.Text + "' where userID = 'E-Maria-7' ";
                        int rowAffected = DBAccess.ExecuteDMLQuery(query2);

                        if (rowAffected == 1)
                        {
                            MessageBox.Show("Password has been Updated!");
                        }
                        else
                        {
                            MessageBox.Show("Password couldn't been Updated!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("New Password and Confirm  Password didn't match");
                    }
                }
                else
                {
                    MessageBox.Show("Your Old Password Didn't Match");
                }
            }
            catch (Exception ex) { }
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.DashBoard.Show();

            
        }
    }
}
