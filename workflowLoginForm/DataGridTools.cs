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
        public string dbName { get; set; } // Name of the database we want to query from
        public string SqlCommand { get; set; } // Query that we want to run on the database
        public DataGridView dataGrid2 { get; set; }



        // Constructor
        public DataGridTools()
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


        // Creates a data grid from a specified database
        public void PopulateDataGrid(DataGridView dataGrid)
        {

            // Error handling
            try
            {
                cn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(SqlCommand, cn);
                DataSet ds = new DataSet();

                // Fill data grid on screen with data from given database
                dataAdapter.Fill(ds, dbName);
                dataGrid.DataSource = ds;
                dataGrid.DataMember = dbName;

                // Formatting the data grid
                dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dataGrid.RowsDefaultCellStyle.BackColor = Color.Wheat;
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGrid.Font = new Font("Microsoft Sans Serif", 8);
                /*MessageBox.Show);*/
                dataGrid.RowHeadersVisible = false;
                dataGrid.ReadOnly = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Issue Creating Data Grid");
            }
            finally
            {
                cn.Close();
            }
        }



        // Refreshing the data grid to update inventory
        public void RefreshDataGrid(DataGridView dataGrid)
        {
            dataGrid.Update();
            dataGrid.Refresh();
            PopulateDataGrid(dataGrid);
        }


    }
}
