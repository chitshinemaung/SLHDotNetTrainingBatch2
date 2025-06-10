using System;
using System.Data.Common;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;



namespace SLHDay4
{
    class CRUD
    {

        SqlConnectionStringBuilder _builder = new SqlConnectionStringBuilder()
        {
            DataSource = "CSM\\SQLEXPRESS",
            InitialCatalog = "DotNetTrainingBatch2",
            IntegratedSecurity = true, // Use Windows Authentication
            TrustServerCertificate = true, // Trust the server certificate
        };

        public void Create()
        {


        }


        static void Main(string [] args)
        {
            

        }
    }
}