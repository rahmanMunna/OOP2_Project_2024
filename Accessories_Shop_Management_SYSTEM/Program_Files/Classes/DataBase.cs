using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Program_Files.Classes
{
    internal class DataBase
    {
        public DataBase() { }   

        internal void InsertTOTable(string connectionString,string tableName,List<string>value,params string[] accessors)
        {
            //SqlConnection  con = new SqlConnection(connectionString);
            //con.Open();
            //string query = "INSERT INTO " + tableName + " values(";
            //foreach (var variable in accessors)
            //{
            //    query = query + variable + ",";
            //}
            //query = query + ")";

            //SqlCommand cmd = new SqlCommand(query,con);

            //foreach(var val in value)
            //{
               
            //}

        }
    }
}
