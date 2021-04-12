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
        private DataGridTools dgTools;

        // Variables

        // Constructor
        public ReportManagerForm()
        {
            InitializeComponent();
            dgTools = new DataGridTools();
        }

        // Event handler for Refresh button click
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dgTools.dbName = "Products";

            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products";

            dgTools.RefreshDataGrid(prodDataGridView);

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
                dgTools.dbName = "Products";

                dgTools.SqlCommand = "SELECT ProductName, Quality , Quantity, Location FROM Products";
                dgTools.PopulateDataGrid(prodDataGridView);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }

        // Event handler for View Product Data button click
        private void viewProdBtn_Click(object sender, EventArgs e)
        {
            dgTools.dbName = "Products";

            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products";

            dgTools.PopulateDataGrid(prodDataGridView);

        }

        // Event handler for View Raw Materials Data button click
        private void viewMatBtn_Click(object sender, EventArgs e)
        {
            dgTools.dbName = "RawMaterials";
            
            dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials"; // Viewing all data from RawMaterials database except the ID
            
            dgTools.PopulateDataGrid(prodDataGridView);

        }
    }
}
