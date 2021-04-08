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
                string statement = "SELECT ProductName, Quality, Quantity, Location FROM Products";
                this.databaseName = "Products";
                dbTools = new DatabaseTools(this.databaseName); // Default data grid is Products database
                dbTools.PopulateDataGrid(prodDataGridView, statement);
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
            dbTools = new DatabaseTools(this.databaseName);
            dbTools.RefreshDataGrid(prodDataGridView, statement); // Refresh the data grid to see changes
        }


        private void viewProdBtn_Click(object sender, EventArgs e)
        {
            string statement = "SELECT ProductName, Quality, Quantity, Location FROM Products";
            this.databaseName = "Products"; // Set the name for the database we want to find
            dbTools = new DatabaseTools(this.databaseName); // Pass the database name to the constructor
            dbTools.PopulateDataGrid(prodDataGridView, statement);
        }

        private void viewMatBtn_Click(object sender, EventArgs e)
        {
            //lstBoxProducts.Items.Clear();
            this.databaseName = "RawMaterials"; // Set the name for the database we want to find
            dbTools = new DatabaseTools(this.databaseName); // Pass the database name to the constructor
            dbTools.PopulateDataGrid(prodDataGridView);
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            //lstBoxProducts.Items.Clear();
            List<Product> productList;
            productList = new List<Product>();
            dbTools = new DatabaseTools("trial");

            Product tempProduct;
            dbTools.cn.Open();

            string qual = cBoxQuality.Text;
            string info = txtFilterByItem.Text;
            if (radBtnName.Checked)
            {
                string statement = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE ProductName = "+"'"+ info+"'";
                this.databaseName = "Products";
                dbTools = new DatabaseTools(this.databaseName); // Default data grid is Products database
                dbTools.PopulateDataGrid(prodDataGridView, statement);
                //string info = txtFilterByItem.Text;
                //dbTools.cmd = new SqlCommand("SELECT * FROM PRODUCTS WHERE ProductName = @info", dbTools.cn);
                //dbTools.cmd.Parameters.AddWithValue("@info", info);
            }
            if(radBtnQuality.Checked)
            {
                //MessageBox.Show(qual);
                string statement = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Quality = " + "'" + qual + "'";
                this.databaseName = "Products";
                dbTools = new DatabaseTools(this.databaseName); // Default data grid is Products database
                dbTools.PopulateDataGrid(prodDataGridView, statement);
                // string qual = cBoxQuality.Text;
                //dbTools.cmd = new SqlCommand("SELECT * FROM PRODUCTS WHERE Quality = @qual", dbTools.cn);
                //dbTools.cmd.Parameters.AddWithValue("@qual", "");
            }
            if (radBtnQuantity.Checked)
            {
                int num = int.Parse(txtNum.Text);
                string statement = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Quantity = " + "'" + num + "'";
                this.databaseName = "Products";
                dbTools = new DatabaseTools(this.databaseName); // Default data grid is Products database
                dbTools.PopulateDataGrid(prodDataGridView, statement);
                //MessageBox.Show(txtNum.Text);
               // dbTools.cmd = new SqlCommand("SELECT * FROM PRODUCTS WHERE Quantity = @num", dbTools.cn);
                //dbTools.cmd.Parameters.AddWithValue("@num", num);
            }
            if (radBtnLocation.Checked)
            {
                string location = cBoxLocation.Text;
                string statement = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Location = " + "'" + location + "'";
                this.databaseName = "Products";
                dbTools = new DatabaseTools(this.databaseName); // Default data grid is Products database
                dbTools.PopulateDataGrid(prodDataGridView, statement);
                //MessageBox.Show(location);
               // dbTools.cmd = new SqlCommand("SELECT * FROM PRODUCTS WHERE Location = @loc", dbTools.cn);
                //dbTools.cmd.Parameters.AddWithValue("@loc", location);

            }


            /*SqlDataReader reader = dbTools.cmd.ExecuteReader();
            
            while (reader.Read())
            {
                string ProductName = (string)reader["ProductName"];
                ProductName = ProductName.Trim() + "    ";
                string quality = (string)reader["Quality"];
                quality = quality.Trim() + "    ";
                int quantity = (int)reader["Quantity"];
                string location = (string)reader["Location"];
                location = location.Trim() + "    ";

                tempProduct = new Product(ProductName, quality, quantity, location);
                productList.Add(tempProduct);
            }*/

            dbTools.cn.Close();

            //lstBoxProducts.Items.Clear();
            //lstBoxProducts.Items.AddRange(productList.ToArray());



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
