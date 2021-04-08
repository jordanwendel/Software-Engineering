using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workflowLoginForm
{
    public partial class ReportManagerForm : Form
    {

        // Class level objects
        private DatabaseTools dbTools;

        // Variables
        private string databaseName { get; set; }

        // Constructor
        public ReportManagerForm()
        {
            InitializeComponent();
        }

        // Event handler for Refresh button click
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string statement = "SELECT ProductName, Quality, Quantity, Location FROM Products";
            dbTools = new DatabaseTools(this.databaseName);
            dbTools.RefreshDataGrid(prodDataGridView,statement); // Refresh the data grid to see changes
        }

        // Event handler for Log Out button click
        private void Logout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for Form load
        private void ReportManagerForm_Load(object sender, EventArgs e)
        {
            // Fill the Product Manager form with Products database information upon creation
            try
            {
                string statement = "SELECT ProductName, Quality , Quantity, Location FROM Products " ;
                this.databaseName = "Products";
                dbTools = new DatabaseTools(this.databaseName); // Default data grid is Products database
                dbTools.PopulateDataGrid(prodDataGridView, statement);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }

        // Event handler for View Product Data button click
        private void viewProdBtn_Click(object sender, EventArgs e)
        {
            string statement = "SELECT ProductName, Quality, Quantity, Location FROM Products";
            this.databaseName = "Products"; // Set the name for the database we want to find
            dbTools = new DatabaseTools(this.databaseName); // Pass the database name to the constructor
            dbTools.PopulateDataGrid(prodDataGridView,statement);
        }

        // Event handler for View Raw Materials Data button click
        private void viewMatBtn_Click(object sender, EventArgs e)
        {
            this.databaseName = "RawMaterials"; // Set the name for the database we want to find
            dbTools = new DatabaseTools(this.databaseName); // Pass the database name to the constructor
            dbTools.PopulateDataGrid(prodDataGridView);
        }
    }
}
