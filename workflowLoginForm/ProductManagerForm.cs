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
    public partial class ProductManagerForm : Form
    {
        // Class level objects
        private DatabaseTools dbTools;
        private ProductForm stockpage;
        private string databaseName;

        // Constructor
        public ProductManagerForm()
        {
            InitializeComponent();
        }

        // Event handler to Logout button click
        private void Logout_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        // Event handler for Add New button click
        private void addProduct_Click(object sender, EventArgs e)
        {
            stockpage = new ProductForm();
            stockpage.ShowDialog(); // Open new display
            this.Show();
        }

        // Event handler for Product Manager Form load
        private void ProductManagerForm_Load(object sender, EventArgs e)
        {
            // Fill the Product Manager form with Products database information upon creation
            try
            {
                this.databaseName = "Products";
                dbTools = new DatabaseTools(this.databaseName); // Default data grid is Products database
                dbTools.PopulateDataGrid(prodDataGridView);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }

        // Event handler for Refresh Inventory button click
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dbTools = new DatabaseTools(this.databaseName);
            dbTools.RefreshDataGrid(prodDataGridView); // Refresh the data grid to see changes
        }


        private void viewProdBtn_Click(object sender, EventArgs e)
        {
            this.databaseName = "Products"; // Set the name for the database we want to find
            dbTools = new DatabaseTools(this.databaseName); // Pass the database name to the constructor
            dbTools.PopulateDataGrid(prodDataGridView);
        }

        private void viewMatBtn_Click(object sender, EventArgs e)
        {
            this.databaseName = "RawMaterials"; // Set the name for the database we want to find
            dbTools = new DatabaseTools(this.databaseName); // Pass the database name to the constructor
            dbTools.PopulateDataGrid(prodDataGridView);
        }
    }
}
