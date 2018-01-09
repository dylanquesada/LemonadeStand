using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class DatabaseConnection
    {
        // member variables
        public string ConnectionString = "Server = DESKTOP-02SQATS; Database=lemonadestand; Integrated Security=true;";
        SqlConnection con;

        //constructor
        public DatabaseConnection()
        {
            con = new SqlConnection(ConnectionString);
        }
        

        //member methods
        public void OpenConnection()
        {
           // con = new SqlConnection(ConnectionString);
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
        }
        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }
        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object datum = ds.Tables[0];
            return datum;
        }
    }
}
