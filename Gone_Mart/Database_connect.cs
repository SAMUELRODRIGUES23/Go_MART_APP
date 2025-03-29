using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gone_Mart
{
    class Database_connect
    {
        private SqlConnection con = new SqlConnection(@"Data Source=SAMUEL\SQLEXPRESS06;Initial Catalog=GoMart;Integrated Security=True");
        public SqlConnection GetCon()
        {
            return con;
        }
        public void OpenCon()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();

            }
        }
        public void CloseCon()
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();

            }
        }
    }
}
