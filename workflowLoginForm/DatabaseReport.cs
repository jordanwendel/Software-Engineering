using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;


namespace workflowLoginForm
{
    public partial class DatabaseReport
    {
        public SqlConnection cn { get; set; }
        public SqlDataReader reader;
        public SqlCommand cmd;
        private readonly string connectionString = Properties.Settings.Default.connectionString;

        public DatabaseReport()
        {
            // Error handling
            try
            {
                cn = new SqlConnection(); // Establishing sql connection
                cn.ConnectionString = connectionString;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }



        // Methods

        public int CountMaterials()
        {
            try
            {
                cn.Open();
                int count = 0;
                cmd = new SqlCommand("SELECT Count (*) From RawMaterials", cn);
                count = (int)cmd.ExecuteScalar();
                return count;
            }
            finally
            {
                cn.Close();
            }
        }

        public int AvgQuantMaterials()
        {
            try
            {
                cn.Open();
                int average = 0;
                cmd = new SqlCommand("SELECT AVG(Quantity) From RawMaterials", cn);
                average = (int)cmd.ExecuteScalar();
                return average;
            }
            finally
            {
                cn.Close();
            }
        }

        public int CountProducts()
        {
            try
            {
                cn.Open();
                int count = 0;
                cmd = new SqlCommand("SELECT Count (*) From Products", cn);
                count = (int)cmd.ExecuteScalar();
                return count;
            }
            finally
            {
                cn.Close();
            }

        }

        public int AvgQuantProducts()
        {
            try
            {
                cn.Open();
                int average = 0;
                cmd = new SqlCommand("SELECT AVG(Quantity) From Products", cn);
                average = (int)cmd.ExecuteScalar();
                return average;
            }
            finally
            {
                cn.Close();
            }
        }

        public int GoodProducts()
        {
            try
            {
                cn.Open();
                int goodcount = 0;
                cmd = new SqlCommand("SELECT Count (*) From Products WHERE Quality = 'Satisfactory' ", cn);
                goodcount = (int)cmd.ExecuteScalar();
                return goodcount;
            }
            finally
            {
                cn.Close();
            }
        }
        public int BadProducts()
        {
            try
            {
                cn.Open();
                int badcount = 0;
                cmd = new SqlCommand("SELECT Count (*) From Products WHERE Quality = 'Defective' ", cn);
                badcount = (int)cmd.ExecuteScalar();
                return badcount;
            }
            finally
            {
                cn.Close();
            }
        }
        public int ProgressProducts()
        {
            try
            {
                cn.Open();
                int progresscount = 0;
                cmd = new SqlCommand("SELECT Count (*) From Products WHERE Quality = 'In Progress' ", cn);
                progresscount = (int)cmd.ExecuteScalar();
                return progresscount;
            }
            finally
            {
                cn.Close();
            }
        }
        public int ManuProducts()
        {
            try
            {
                cn.Open();
                int manucount = 0;
                cmd = new SqlCommand("SELECT Count (*) From Products WHERE Location = 'Manufacturing' ", cn);
                manucount = (int)cmd.ExecuteScalar();
                return manucount;
            }
            finally
            {
                cn.Close();
            }
        }
        public int SalesProducts()
        {
            try
            {
                cn.Open();
                int salescount = 0;
                cmd = new SqlCommand("SELECT Count (*) From Products WHERE Location = 'Sales' ", cn);
                salescount = (int)cmd.ExecuteScalar();
                return salescount;
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
