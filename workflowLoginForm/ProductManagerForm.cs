using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private DataGridTools dgTools;
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
                string statement = "SELECT ProductName, Quality, Quantity, Location FROM Products";
                this.databaseName = "Products";

                dgTools = new DataGridTools(this.databaseName);
                dgTools.PopulateDataGrid(prodDataGridView, statement);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }

        // Event handler for Refresh Inventory button click
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string statement = "SELECT ProductName, Quality, Quantity, Location FROM Products";

            dgTools = new DataGridTools(this.databaseName);
            dgTools.RefreshDataGrid(prodDataGridView, statement);

        }


        private void viewProdBtn_Click(object sender, EventArgs e)
        {
            string statement = "SELECT ProductName, Quality, Quantity, Location FROM Products";
            this.databaseName = "Products"; // Set the name for the database we want to find

            dgTools = new DataGridTools(this.databaseName);
            dgTools.PopulateDataGrid(prodDataGridView, statement);

        }

        private void viewMatBtn_Click(object sender, EventArgs e)
        {
            this.databaseName = "RawMaterials"; // Set the name for the database we want to find

            dgTools = new DataGridTools(this.databaseName);
            dgTools.PopulateDataGrid(prodDataGridView);

        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            string qual = cBoxQuality.Text;
            string info = txtFilterByItem.Text;

            if (radBtnName.Checked)
            {
                string statement = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE ProductName = "+"'"+ info+"'";
                this.databaseName = "Products";

                dgTools = new DataGridTools(this.databaseName);
                dgTools.PopulateDataGrid(prodDataGridView, statement);

            }
            if(radBtnQuality.Checked)
            {
                string statement = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Quality = " + "'" + qual + "'";
                this.databaseName = "Products";

                dgTools = new DataGridTools(this.databaseName);
                dgTools.PopulateDataGrid(prodDataGridView, statement);

            }
            if (radBtnQuantity.Checked)
            {
                int num = int.Parse(txtNum.Text);
                string statement = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Quantity = " + "'" + num + "'";
                this.databaseName = "Products";

                dgTools = new DataGridTools(this.databaseName);
                dgTools.PopulateDataGrid(prodDataGridView, statement);

            }
            if (radBtnLocation.Checked)
            {
                string location = cBoxLocation.Text;
                string statement = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Location = " + "'" + location + "'";
                this.databaseName = "Products";

                dgTools = new DataGridTools(this.databaseName);
                dgTools.PopulateDataGrid(prodDataGridView, statement);

            }

        }

        private void radBtnQuality_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
