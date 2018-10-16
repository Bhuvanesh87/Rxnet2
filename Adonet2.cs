using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet
{
    class Adonet2
    {
        static void Main(string[] args)
        {
            new Adonet2().CreateTable();
            Console.Read();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=Bhuvan; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into student(id, name, email, join_date)values('102', 'Rajesh', 'Mahesh.aluri@gmail.com', '3/10/2015')", con);  
                // Opening Connection  
              con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Data inserted into the Table Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
