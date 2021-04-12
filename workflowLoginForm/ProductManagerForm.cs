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
        private DatabaseTools dbTools;
        private ProductForm stockpage;

        // Variables
        
        // Constructor
        public ProductManagerForm()
        {
            InitializeComponent();
            dgTools = new DataGridTools();
            dbTools = new DatabaseTools();
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
                dgTools.dbName = "Products";

                dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products";
                
                dgTools.PopulateDataGrid(prodDataGridView);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }

        // Event handler for Refresh Inventory button click
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            // Clear the filtering text fields when refreshing data grid
            txtFilterByItem.Clear();
            cBoxLocation.Text = null;
            cBoxQuality.Text = null;
            txtNum.Clear();
 
            // Viewing Products
            if (dgTools.dbName.Equals("Products"))
            {
                dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products";

                dgTools.RefreshDataGrid(prodDataGridView);
            }

            // Viewing Raw Materials
            else if (dgTools.dbName.Equals("RawMaterials"))
            {
                dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials"; // Viewing all data from RawMaterials database except the ID

                dgTools.RefreshDataGrid(prodDataGridView);
            }

            
        }


        private void viewProdBtn_Click(object sender, EventArgs e)
        {
            dgTools.dbName = "Products";

            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products";
            
            dgTools.PopulateDataGrid(prodDataGridView);

        }

        private void viewMatBtn_Click(object sender, EventArgs e)
        {
            dgTools.dbName = "RawMaterials";
            
            dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials"; // Viewing all data from RawMaterials database except the ID
            
            dgTools.PopulateDataGrid(prodDataGridView);

        }

        // ADD FUNCTIONALITY HERE TO FILTER BOTH DATABASES
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string qual = cBoxQuality.Text;
            string info = txtFilterByItem.Text;

            // Filtering Products database
            if (dgTools.dbName.Equals("Products"))
            {
                if (radBtnName.Checked)
                {
                    dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE ProductName = " + "'" + info + "'";

                    dgTools.PopulateDataGrid(prodDataGridView);

                }
                else if (radBtnQuality.Checked)
                {
                    dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Quality = " + "'" + qual + "'";

                    dgTools.PopulateDataGrid(prodDataGridView);

                }
                else if (radBtnQuantity.Checked)
                {
                    int num = int.Parse(txtNum.Text);

                    dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Quantity = " + "'" + num + "'";

                    dgTools.PopulateDataGrid(prodDataGridView);

                }
                else if (radBtnLocation.Checked)
                {
                    string location = cBoxLocation.Text;

                    dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Location = " + "'" + location + "'";

                    dgTools.PopulateDataGrid(prodDataGridView);

                }
            }

            // Filtering Raw Materials database
            else if (dgTools.dbName.Equals("RawMaterials"))
            {
                if (radBtnName.Checked)
                {
                    dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials WHERE RawMaterialName = " + "'" + info + "'";

                    dgTools.PopulateDataGrid(prodDataGridView);
                }
                else if (radBtnQuantity.Checked)
                {
                    int num = int.Parse(txtNum.Text);

                    dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials WHERE Quantity = " + "'" + num + "'";

                    dgTools.PopulateDataGrid(prodDataGridView);
                }
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
            // Creating a new product object, adding it to the database, and auto refreshing the datagrid
            Product newProduct = new Product(txtName.Text, qualityMenu.Text, int.Parse(txtQuantity.Text), locationMenu.Text);
            dbTools.AddProduct(newProduct);
            dgTools.RefreshDataGrid(prodDataGridView);

            // Clearing entered values
            txtName.Clear();
            qualityMenu.Text = null;
            txtQuantity.Clear();
            locationMenu.Text = null;
        }

       
    }
}
