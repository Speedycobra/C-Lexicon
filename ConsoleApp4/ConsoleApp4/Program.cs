using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;


namespace ADONET
{
    class Program
    {

        //Connectionstring som bör fungera i era system
        //....
        static string conString = "Server=ELEV; Database=NORTHWND;Trusted_Connection=True";
        private SqlConnection con;
        private string query;

        static void Main(string[] args)
        {
            var con = new SqlConnection(conString);
            con.Open();

            SqlCommand command = new SqlCommand("SELECT [CustomerID], [CompanyName], [City], [ContactName] From Customers", con);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t{0}\t{1,-40}\t{2,-20} {3}", "ID", "CompanyName", "City", "ContactName");
                Console.ForegroundColor = ConsoleColor.White;
                while (dataReader.Read())
                {
                    Console.WriteLine("\t{0}\t{1,-40}\t{2,-20} {3}", dataReader[0], dataReader[1], dataReader[2], dataReader[3]);
                }
            }
            else
            {
                Console.WriteLine("No items found!");
            }
            Console.ReadKey(true);

            con.Close();
            dataReader.Close();
        }
        //public void InsertQuery()


        //    {
        //        con.Open();
        //        string sql = "INSERT INTO dbo.Customers(CustomerID,CompanyName) VALUES(@CustomerID, @CompanyName)";
        //        SqlCommand cmd = new SqlCommand(sql, con);
        //        cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).SqlValue = "FLYNO";
        //        cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar).SqlValue = "Flyfishin North";

        //        cmd.CommandType = CommandType.Text;
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //    }


        public void UpdateQuery()
        {
            con.Open();
            string sql = "UPDATE dbo.Customers(CompanyName,ContactName) VALUES(@CompanyName, @ContactName)WHERE CustomerID = 'BLAUS'"; 
                                      
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar).Value = "Flyfishing North";
            cmd.Parameters.Add("@ContactName", SqlDbType.NVarChar).Value = "SalimElHajjar";
                     

            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}




