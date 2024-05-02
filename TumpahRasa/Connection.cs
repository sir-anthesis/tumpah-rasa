using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TumpahRasa
{
    public class Connection
    {
        public SqlConnection myConnection = new SqlConnection();

        public Connection()
        {

        }

        public void OpenCon()
        {
            try
            {
                myConnection.ConnectionString = GlobalVariable.connString;
                myConnection.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CloseCon()
        {
            try
            {
                myConnection.ConnectionString = GlobalVariable.connString;
                myConnection.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}