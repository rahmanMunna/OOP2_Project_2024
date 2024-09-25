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

        private AdminDashboard adminDashboard;
        public ManageEmployee()
        {
            InitializeComponent();

            this.PopulateGridview();
            dgvShowEmployee.AutoGenerateColumns = false;
        }
        //private SqlConnection connection = new SqlConnection("Data Source=SHUVRO\\SQLEXPRESS;Initial Catalog=Accessories_Management_Shop;Integrated Security=True;Encrypt=False");



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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowEmployee.Rows.Count > 0)
                {
                    this.panel1.Enabled = true;
                    this.EditBtn.Enabled = false;


                    int index = dgvShowEmployee.CurrentCell.RowIndex;

                    int firstname = Convert.ToInt32(dgvShowEmployee.Rows[index].Cells["First Name"].Value);
                    int lastname = Convert.ToInt32(dgvShowEmployee.Rows[index].Cells["Last Name"].Value);
                    int email = Convert.ToInt32(dgvShowEmployee.Rows[index].Cells["Email"].Value);
                    int phoneno = Convert.ToInt32(dgvShowEmployee.Rows[index].Cells["Phone Number"].Value);

                    int gender = Convert.ToInt32(dgvShowEmployee.Rows[index].Cells["Gender"].Value);
                    int dob = Convert.ToInt32(dgvShowEmployee.Rows[index].Cells["DOB"].Value);
                    int joindate = Convert.ToInt32(dgvShowEmployee.Rows[index].Cells["Joindate"].Value);
                    int Salary = Convert.ToInt32(dgvShowEmployee.Rows[index].Cells["Salary"].Value);
                    int address = Convert.ToInt32(dgvShowEmployee.Rows[index].Cells["Address"].Value);
                    int age = Convert.ToInt32(dgvShowEmployee.Rows[index].Cells["Age"].Value);


                    FnameTxt.Text = firstname.ToString();
                    LnameTxt.Text = lastname.ToString();
                    EmailTxt.Text = email.ToString();
                    PhoneTxt.Text = phoneno.ToString();
                    rbFemale.Text = gender.ToString();
                    rbMale.Text = gender.ToString();
                    DOBDtp.Text = dob.ToString();
                    JoindateDtp.Text = joindate.ToString();
                    SalTxt.Text = Salary.ToString();
                    AddressTxt.Text = address.ToString();
                    cmbAge.Text = age.ToString();
                }
                else
                {
                    MessageBox.Show("Missing Information!");
                }
            }

            catch (Exception ex) { }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                    if ( FnameTxt.Text == " " || LnameTxt.Text == " " ||  PhoneTxt.Text == " " || cmbAge.Text == " " || AddressTxt.Text == " " || SalTxt.Text == "" || EmailTxt.Text == "")
                   {
                       MessageBox.Show("Missing Information!");
                   }
                   else
                  {
                       Con.Open();
                        string Query = "update ETBL set Serial_No='" + "',First_Name='" + FnameTxt.Text + "',Last_Name='" + LnameTxt.Text + "',Phone_No='" + PhoneTxt.Text + "',Age='" + cmbAge.Text + "',Email='" + EmailTxt.Text + "',Password='" + "',Address='" + AddressTxt.Text + "',Salary='" + SalTxt.Text + "',Gender='" + rbMale.ToString() + rbFemale.ToString() + "',Date_Of_Birth='" + DOBDtp.Value.Date + "',Joindate='" + JoindateDtp.Value.Date + "',Position='" +  "',Assigned_By='" + "';";
                        SqlCommand cmd = new SqlCommand(Query, Con);
                       cmd.ExecuteNonQuery();
                        Con.Close();
                        MessageBox.Show("Data Updated Successfully!");
                       
                    }
                }
                catch (Exception ex)
                {
                   MessageBox.Show (ex.Message);
               }
                finally
                {
                    Con.Close();
                }
        }
    }
}

