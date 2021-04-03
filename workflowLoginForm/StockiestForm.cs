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
    public partial class StockiestForm : Form
    {
        // Class level objects
        private DatabaseTools dbTools;
        private RawMaterialsForm stockpage;

        // Constructor
        public StockiestForm()
        {
            InitializeComponent();
        }

        // Event handler for Stockiest Form load
        private void StockiestForm_Load(object sender, EventArgs e)
        {
            // Fill the data grid view on form with contents of given database using a data grid object
            dbTools = new DatabaseTools();
            dbTools.dbName = "RawMaterials";
            dbTools.PopulateDataGrid(stockDataGridView);

        }

        // Event handler for Logout button click
        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for Refresh Inventory button click
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dbTools = new DatabaseTools();
            dbTools.dbName = "RawMaterials";
            dbTools.RefreshDataGrid(stockDataGridView); // Refresh the grid to see changes
        }

        // Event handler for Add New button click
        private void addNewMat_Btn_Click(object sender, EventArgs e)
        {
            stockpage = new RawMaterialsForm();
            stockpage.ShowDialog(); // Open new display
            this.Show();
        }
    }
}
