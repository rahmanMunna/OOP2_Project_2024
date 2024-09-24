using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program_Files.Classes;

namespace Program_Files.Login_Panel
{
    public partial class LoginFrame : Form
    {
        private User user;

        private string Password {  get; set; }
        private string UserId { get; set; }

        private string Role {  get; set; }  
        public LoginFrame()
        {
            InitializeComponent();
            
        } 

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.UserId = txtUserId.Text;   
            this.Password = txtPassword.Text;

            try
            {
                if(this.UserId.Length > 0 && this.Password.Length > 0 )
                {
                    string query = "select password,role, from UserTB where userid = '" + this.UserId + "'";
                    DataTable table = DBAccess.ExecuteQuery(query);
                    
                    if (table.Rows.Count > 0)
                    {
                        this.Role = table.Rows[0][1].ToString();
                        if (table.Rows[0][0].ToString() == this.Password)
                        {
                            MessageBox.Show("Login SuccesFull");
                            if (Role == "Admin")
                            {
                                MessageBox.Show("You are Admin");
                            }
                            else
                            {
                                MessageBox.Show("You are Employee");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Passworrd");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid User ID");
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill all the required Field");
                }
            }
            catch (Exception ex) { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar= true;    
            }
        }
    }
}
