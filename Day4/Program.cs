using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Program
    {
        static void Main(string [] args)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "CSM\\SQLEXPRESS";
            builder.InitialCatalog = "DotNetTrainingBatch2";
            //builder.UserID = "username";  
            //builder.Password = "password";  
            builder.IntegratedSecurity = true; // Use Windows Authentication  
            builder.TrustServerCertificate = true; // Trust the server certificate  

            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            Console.WriteLine("Opening database...");
            connection.Open();
            Console.WriteLine("Database opened successfully!");

            Console.WriteLine();

            string query = "SELECT * FROM TBL_Student";
            SqlCommand cmd = new SqlCommand(query, connection); // Corrected the type to SqlCommand  
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Console.WriteLine("Closing database...");
            connection.Close();
            Console.WriteLine("Database closed successfully!");

            int dtcount = dt.Rows.Count;
            Console.WriteLine("Number of rows in the DataTable: " + dtcount);

            for ( int i = 0; i < dtcount; i++ )
            {
                DataRow dtrow = dt.Rows [i];
                Console.WriteLine(i);
                Console.WriteLine(dtrow["StudentID"]);
                Console.WriteLine(dtrow ["StudentName"]);
                // Add logic to process each row if needed  
            }

            Console.ReadKey();
        }
    }
}
