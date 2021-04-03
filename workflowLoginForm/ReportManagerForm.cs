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
        public ReportManagerForm()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dbTools = new DatabaseTools(this.databaseName);
            dbTools.RefreshDataGrid(prodDataGridView); // Refresh the data grid to see changes
        }

        private void Logout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportManagerForm_Load(object sender, EventArgs e)
        {
            // Fill the Product Manager form with Products database information upon creation
            try
            {
                this.databaseName = "Products";
                dbTools = new DatabaseTools(this.databaseName); // Default data grid is Products database
                dbTools.PopulateDataGrid(prodDataGridView);
                dbTools.CloseConnection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }

        private void viewProdBtn_Click(object sender, EventArgs e)
        {
            this.databaseName = "Products"; // Set the name for the database we want to find
            dbTools = new DatabaseTools(this.databaseName); // Pass the database name to the constructor
            dbTools.PopulateDataGrid(prodDataGridView);
            dbTools.CloseConnection();
        }

        private void viewMatBtn_Click(object sender, EventArgs e)
        {
            this.databaseName = "RawMaterials"; // Set the name for the database we want to find
            dbTools = new DatabaseTools(this.databaseName); // Pass the database name to the constructor
            dbTools.PopulateDataGrid(prodDataGridView);
            dbTools.CloseConnection();
        }
    }
}
