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
using System.Data.SqlClient;
using Program_Files.Classes;

namespace Program_Files.Admin_Panel
{
    public partial class ManageEmployee : Form

    {
        private SqlConnection Con = new SqlConnection("Data Source=SHUVRO\\SQLEXPRESS;Initial Catalog=Accessories_Management_Shop;Integrated Security=True;Encrypt=False");
        private DataTable table = new DataTable();

        private string Id {  get; set; }    

        private AdminDashboard adminDashboard;
        public ManageEmployee()
        {
            InitializeComponent();
            this.pnlEdit.Enabled = false;
            this.PopulateGridview();
            dgvShowEmployee.AutoGenerateColumns = false;

        }

        public ManageEmployee(dynamic dashboard) : this()
        {
            this.adminDashboard = dashboard;
        }
       
        private void PopulateGridview(string query = "Select UserID,FirstName,LastName,Email,PhoneNumber,Nid,Gender,Age,Dob,JoiningDate,Salary,Address,ASsignedBy from UserTB where Role = 'Employee' ")
        {
            DataTable dt = DBAccess.ExecuteQuery(query);
            dgvShowEmployee.DataSource = dt;

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.adminDashboard.Show();
        }

       
        private void CLearAllField()
        {
            foreach(Control control in pnlEdit.Controls)
            {
                if(control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {

            try
            {

                if (dgvShowEmployee.Rows.Count > 0)
                {
                    
                    string query = "update UserTB set FirstName = '" + FnameTxt.Text + "',LastName = '" + LnameTxt.Text + "',email = '" + EmailTxt.Text + "',PhoneNumber = '" + PhoneTxt.Text + "',Salary = " + Convert.ToInt32(SalTxt.Text) + ",Address = '" + AddressTxt.Text + "' where UserId = '" + this.Id + "'";
                    int rowAffected = DBAccess.ExecuteDMLQuery(query);

                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Information Updated Succesfully");
                        this.PopulateGridview();
                        this.pnlEdit.Enabled = false;
                        this.CLearAllField();
                    }
                    else
                    {
                        MessageBox.Show("Information Can't be updated");
                    }



                }
                else
                {
                    MessageBox.Show("No Product Available to Update");
                }
            }

            catch (Exception ex) { }

        }

       
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowEmployee.Rows.Count > 0)
                {
                    this.pnlEdit.Enabled = true;
                    this.btnEdit.Enabled = false;


                    int index = dgvShowEmployee.CurrentCell.RowIndex;

                    this.Id = dgvShowEmployee.Rows[index].Cells["UserId"].Value.ToString();

                    FnameTxt.Text = dgvShowEmployee.Rows[index].Cells["FirstName"].Value.ToString();
                    LnameTxt.Text = dgvShowEmployee.Rows[index].Cells["LastName"].Value.ToString();
                    EmailTxt.Text = dgvShowEmployee.Rows[index].Cells["Email"].Value.ToString();
                    PhoneTxt.Text = dgvShowEmployee.Rows[index].Cells["PhoneNumber"].Value.ToString();
                    AddressTxt.Text = dgvShowEmployee.Rows[index].Cells["Address"].Value.ToString();
                    SalTxt.Text = dgvShowEmployee.Rows[index].Cells["Salary"].Value.ToString();

                }
                else
                {
                    MessageBox.Show("No Product Available to Update");
                }
            }
            catch(Exception ex) { }

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.PopulateGridview();
            this.pnlEdit.Enabled = false;
            this.btnEdit.Enabled = true;
            this.CLearAllField();
        }

        private void dgvShowEmployee_DoubleClick(object sender, EventArgs e)
        {
           int index = dgvShowEmployee.CurrentCell.RowIndex;


        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowEmployee.Rows.Count > 0)
                {
                    int index = dgvShowEmployee.CurrentCell.RowIndex;
                    this.Id = dgvShowEmployee.Rows[index].Cells["UserId"].Value.ToString();

                    DialogResult result = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Check which button was clicked
                    if (result == DialogResult.Yes)
                    {
                        string query = "delete from UserTB where UserId = '" + this.Id + "' ";
                        int rowAffected = DBAccess.ExecuteDMLQuery(query);
                        MessageBox.Show("Product has Been Deleted");
                        this.PopulateGridview();
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }


                }
                else
                {
                    MessageBox.Show("No Product Available");
                }
            }
            catch (Exception ex) { }
        }
    }
}

