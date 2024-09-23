using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Program_Files.Classes
{
    internal static class DBAccess
    {
        private static SqlConnection connection {  get; set; }  

        static DBAccess()
        {
            DBAccess.connection = new SqlConnection("Data Source=MUNNA\\SQLEXPRESS;Initial Catalog=Accessories_Management_Shop;Integrated Security=True");
            connection.Open();
        }
        
       
        public static DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            connection.Close();
            return dt;

        }

        public static int ExecuteDMLQuery(string query)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            int r = cmd.ExecuteNonQuery();
            connection.Close();
            return r;
        }
        public static SqlDataReader GetDataByGroup(string columnName,string value)
        {
            string query = "";
            if(columnName == "Model")
            {
                query = "Select Model from Product2TB where BrandName = @value Group BY Model";
            }
            else if(columnName == "BrandName")
            {
                query = "Select BrandName from Product2TB where ComponentName = @value Group BY BrandName";
            }

            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@value", value);
            SqlDataReader reader = cmd.ExecuteReader();
            connection.Close();

            return reader;
        }
        
    }
}
