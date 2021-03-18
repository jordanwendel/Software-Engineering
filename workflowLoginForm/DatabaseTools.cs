using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace workflowLoginForm
{
    public partial class DatabaseTools
    {
        private SqlConnection cn;
        private SqlDataReader dr;
        private SqlCommand cmd;

        // Variables
        private string connectionString = @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog = WORKFLOW; Persist Security Info=True;User ID = workflow; Password=cw97zUyEDMXyaf6UsZBB;Encrypt=True;TrustServerCertificate=True"

        // Empty constructor
        public DatabaseTools()
        {
            cn = new SqlConnection(); // Establishing sql connection
            cn.ConnectionString = connectionString;
            cn.Open(); // Opening conneciton with specified path
            cmd = new SqlCommand();
            cmd.Connection = cn;
        }

        // Methods

       
           
    }

}
