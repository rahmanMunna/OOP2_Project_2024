using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Program_Files
{
    public partial class EmpInfoInsert : Form
    {
        public EmpInfoInsert()
        {
            InitializeComponent();
            //DisplayEmp();
        }
        //readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source =(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\HP\OneDrive\Microsoft Teams Chat Files\Documents\EmpTbl.mdf;Integrated Security = True; Connect Timeout = 30");

        //private void DisplayEmp() 
        //{
        //    try
        //    {
        //        Con.Open();
        //        string Query = "select * from ETBL";
        //        SqlDataAdapter sda = new SqlDataAdapter (Query, Con);
        //        SqlCommandBuilder builder = new SqlCommandBuilder (sda);
        //        var x = new DataSet();
        //        sda.Fill (x);
        //        EmpDataGrd.DataSource = x.Tables[0];
        //        Con.Close();
        //    }
        //    catch (Exception ex) 
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        Con.Close();
        //    }
        //}
        private void EmpInsertCrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
          
        }

        //private void AddBtn_Click(object sender, EventArgs e)
        //{
        //  try
        //    {
        //        if (SerialTxt.Text == " " || IdTxt.Text==" " ||FnameTxt.Text==" " || LnameTxt.Text==" " || PassTxt.Text==" " || PhoneTxt.Text==" " || AgeTxt.Text==" " || AddressTxt.Text == " " || SalTxt.Text == "" || EmailTxt.Text == "")
        //        {
        //            MessageBox.Show("Missing Information!");
        //        }
        //        else
        //        {
        //            Con.Open ();
        //            string Query = "insert into ETBL values('"+SerialTxt.Text+ "','"+IdTxt.Text+ "','"+FnameTxt.Text+ "','"+LnameTxt.Text+ "','"+PhoneTxt.Text+ "','"+AgeTxt.Text+ "','"+EmailTxt.Text+ "','" + PassTxt.Text+ "','" + AddressTxt.Text+ "','"+SalTxt.Text+"','"+GenderCbx.SelectedItem.ToString()+ "','"+DOBDtp.Value.Date+ "','"+JoindateDtp.Value.Date+ "','"+PositionCbx.SelectedItem.ToString()+ "','"+AssignedCbx.SelectedItem.ToString()+ "',)";
        //            SqlCommand cmd = new SqlCommand(Query, Con);
        //            cmd.ExecuteNonQuery();
        //            Con.Close();
        //            MessageBox.Show("Data Inserted Successfully!");
        //            DisplayEmp();
        //        }
        //    }
        //    catch(Exception ex) 
        //    {
        //        MessageBox.Show (ex.Message);
        //    }
        //    finally
        //    {
        //        Con.Close();
        //    }
        //}

        private void AddAge()
        {
            for (int i = 16; i < 35; i++)
            {
                cmbAge.Items.Add(i);    
            }
        }
        private void EmpInfoInsert_Load(object sender, EventArgs e)
        {
            //DisplayEmp();
            this.AddAge();
        }

        //private void DeleteBtn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (IdTxt.Text == "")
        //        {
        //            MessageBox.Show("Enter Employee ID");
        //        }
        //        else
        //        {
        //            Con.Open();
        //            string Query = "delete From ETBL WHERE UserID = '" + IdTxt.Text + "';";
        //            SqlCommand cmd = new SqlCommand (Query, Con);
        //            cmd.ExecuteNonQuery();
        //           Con.Close ();
        //            MessageBox.Show("Data Deleted Successfully");
        //            DisplayEmp();
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show (ex.Message);
        //    }
        //    finally
        //    {
        //        Con.Close();
        //    }
        //}

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            
            PhoneTxt.Text = " ";
            EmailTxt.Text = " ";
            FnameTxt.Text = " ";
            LnameTxt.Text = " ";
            //AgeTxt.Text = " ";
            AddressTxt.Text = " ";
            SalTxt.Text = " ";
            
            cmbPossition.Text = " ";
            //AssignedCbx.Text = " ";
            DOBDtp.Text = " ";
            JoindateDtp.Text = " ";
            


        }

        //private void UpdateBtn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        if (SerialTxt.Text == " " || IdTxt.Text == " " || FnameTxt.Text == " " || LnameTxt.Text == " " || PassTxt.Text == " " || PhoneTxt.Text == " " || AgeTxt.Text == " " || AddressTxt.Text == " " || SalTxt.Text == "" || EmailTxt.Text == "")
        //        {
        //            MessageBox.Show("Missing Information!");
        //        }
        //        else
        //        {
        //            Con.Open();
        //            string Query = "update ETBL set Serial_No='" + SerialTxt.Text + "',UserID='" + IdTxt.Text + "',First_Name='" + FnameTxt.Text + "',Last_Name='" + LnameTxt.Text + "',Phone_No='" + PhoneTxt.Text + "',Age='" + AgeTxt.Text + "',Email='" + EmailTxt.Text + "',Password='" + PassTxt.Text + "',Address='" + AddressTxt.Text + "',Salary='" + SalTxt.Text + "',Gender='" + GenderCbx.SelectedItem.ToString() + "',Date_Of_Birth='" + DOBDtp.Value.Date + "',Joindate='" + JoindateDtp.Value.Date + "',Position='" + PositionCbx.SelectedItem.ToString() + "',Assigned_By='" + AssignedCbx.SelectedItem.ToString() + "';";
        //            SqlCommand cmd = new SqlCommand(Query, Con);
        //            cmd.ExecuteNonQuery();
        //            Con.Close();
        //            MessageBox.Show("Data Updated Successfully!");
        //            DisplayEmp();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show (ex.Message);
        //    }
        //    finally
        //    {
        //        Con.Close();
        //    }
        //}

        private void EmpDataGrd_DoubleClick(object sender, EventArgs e)
        {
            
            FnameTxt.Text = EmpDataGrd.SelectedRows[0].Cells[2].Value.ToString();
            LnameTxt.Text = EmpDataGrd.SelectedRows[0].Cells[3].Value.ToString();
            EmailTxt.Text = EmpDataGrd.SelectedRows[0].Cells[4].Value.ToString();
            PhoneTxt.Text = EmpDataGrd.SelectedRows[0].Cells[5].Value.ToString();
            
            //AgeTxt.Text = EmpDataGrd.SelectedRows[0].Cells[7].Value.ToString();
            DOBDtp.Text = EmpDataGrd.SelectedRows[0].Cells[8].Value.ToString();
            AddressTxt.Text = EmpDataGrd.SelectedRows[0].Cells[9].Value.ToString();
            JoindateDtp.Text = EmpDataGrd.SelectedRows[0].Cells[10].Value.ToString();
           
            SalTxt.Text = EmpDataGrd.SelectedRows[0].Cells[12].Value.ToString();
            cmbPossition.Text = EmpDataGrd.SelectedRows[0].Cells[13].Value.ToString();
           // AssignedCbx.Text = EmpDataGrd.SelectedRows[0].Cells[14].Value.ToString();
           
        }

        
        private void ClearAllFields()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    control.Text.Clone();
                }
                else if(control is ComboBox)
                {
                    ComboBox cmb = (ComboBox)control;
                    cmb.SelectedIndex = -1;
                }
                else if(control is RadioButton)
                {
                    //RadioButton radio = (RadioButton)control;
                    //radio.Checked = radio.Checked;
                         
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.ClearAllFields();
        }
    }
}
