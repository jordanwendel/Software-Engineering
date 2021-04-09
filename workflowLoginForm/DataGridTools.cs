using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace workflowLoginForm
{
    public class DataGridTools
    {
        // Class level objects
        public SqlConnection cn { get; set; }


        // Variables
        private readonly string connectionString = Properties.Settings.Default.connectionString; // Database connection string stored in Properties -> Settings.settings
        public string dbName { get; set; }

        public DataGridTools(string dbName = null)
        {
            this.dbName = dbName;

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


        // Creates a data grid from a specified database
        public void PopulateDataGrid(DataGridView dataGrid, string statement = null)
        {
            string sql = "SELECT * FROM " + dbName; // Default value

            // Only displaying the data that we want from each database
            if (this.dbName.Equals("Products"))
            {
                sql = statement; // Viewing all data dependent on statement 
            }
            else if (this.dbName.Equals("RawMaterials"))
            {
                sql = "SELECT RawMaterialName, Quantity FROM " + dbName; // Viewing all data from RawMaterials database except the ID
                //sql = statement;
            }


            // Error handling
            try
            {
                cn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
                DataSet ds = new DataSet();

                // Fill data grid on screen with data from given database
                dataAdapter.Fill(ds, dbName);
                dataGrid.DataSource = ds;
                dataGrid.DataMember = dbName;

                // Formatting the data grid
                dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dataGrid.RowsDefaultCellStyle.BackColor = Color.Wheat;
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Issue Creating DataGrid");
            }
            finally
            {
                cn.Close();
            }
        }



        // Refreshing the data grid to update inventory
        public void RefreshDataGrid(DataGridView dataGrid, string statement = null)
        {
            dataGrid.Update();
            dataGrid.Refresh();
            PopulateDataGrid(dataGrid, statement);
        }


    }
}
