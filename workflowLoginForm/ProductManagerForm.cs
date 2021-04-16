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

            removeItemBtn.Visible = false;
        }

        // Event handler for Refresh Inventory button click
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            // Clear the filtering text fields when refreshing data grid
            filterMenu.Text = "Click to expand...";
            txtFilterByItem.Clear();
            cBoxLocation.Text = null;
            cBoxQuality.Text = null;
            txtNum.Clear();
            quantityEquations.Text = null;

            // Re-enabling all search fields
            cBoxQuality.Enabled = true;
            cBoxLocation.Enabled = true;
            txtFilterByItem.Enabled = true;
            txtNum.Enabled = true;
            quantityEquations.Enabled = true;


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
            filterMenu.Text = "Click to expand..."; // Resetting the filter menu text

            // Clear filtering fields
            txtFilterByItem.Clear();
            cBoxLocation.Text = null;
            cBoxQuality.Text = null;
            txtNum.Clear();
            quantityEquations.ResetText();
            stsStripLabel.Text = "";

            // Populate data grid
            dgTools.dbName = "Products";
            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products";
            dgTools.PopulateDataGrid(prodDataGridView);

            // Add the filtering options specifically for Products
            filterMenu.Items.Clear();
            filterMenu.Items.Add("Name");
            filterMenu.Items.Add("Quality");
            filterMenu.Items.Add("Quantity");
            filterMenu.Items.Add("Location");

        }

        private void viewMatBtn_Click(object sender, EventArgs e)
        {
            filterMenu.Text = "Click to expand..."; // Resetting the filter menu text

            // Clear filtering fields
            txtFilterByItem.Clear();
            cBoxLocation.Text = null;
            cBoxQuality.Text = null;
            txtNum.Clear();
            quantityEquations.ResetText();
            stsStripLabel.Text = "";

            // Populate the data grid
            dgTools.dbName = "RawMaterials";
            dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials"; // Viewing all data from RawMaterials database except the ID
            dgTools.PopulateDataGrid(prodDataGridView);

            // Add the filtering options specifically for Raw Materials
            filterMenu.Items.Clear();
            filterMenu.Items.Add("Name");
            filterMenu.Items.Add("Quantity");
        }

        // NEED TO ERROR CATCH WHEN INCORRECT STRING INPUT IS USED
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string info = txtFilterByItem.Text;
            string qual = cBoxQuality.Text;
            string location = cBoxLocation.Text;

            // Filtering Products database
            if (dgTools.dbName.Equals("Products"))
            {
                try
                {
                    // Filtering by Name
                    if (filterMenu.Text.Equals("Name"))
                    {
                        dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE ProductName LIKE " + "'%" + info + "%'"; // Any matches of the inputted search term

                        dgTools.PopulateDataGrid(prodDataGridView);

                        //get the size of each result
                        int dataGridSize = 0;
                        foreach (DataGridViewRow row in prodDataGridView.Rows)
                        {
                            dataGridSize++;
                        }

                        stsStripLabel.Text = "There is/are " + (dataGridSize - 1) + " result(s) that matched your filter";

                    }

                    // Filtering by Quality
                    else if (filterMenu.Text.Equals("Quality"))
                    {
                        dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Quality = " + "'" + qual + "'";
                        
                        dgTools.PopulateDataGrid(prodDataGridView);
                        
                        int dataGridSize = 0;
                        foreach (DataGridViewRow row in prodDataGridView.Rows)
                        {
                            dataGridSize++;
                        }

                        stsStripLabel.Text = "There is/are " + (dataGridSize - 1) + " result(s) that matched your filter";

                    }

                    // Filtering by Quantity
                    else if (filterMenu.Text.Equals("Quantity"))
                    {
                        int N = int.Parse(txtNum.Text);
                        
                        // Valid quanitity input greater than zero
                        if (N > 0)
                        {
                            // Inequality comparisons for quantity
                            if (quantityEquations.Text.Equals("GREATER THAN")) // Greater than N
                            {
                                dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Quantity > " + "'" + N + "'";
                            }
                            else if (quantityEquations.Text.Equals("LESS THAN")) // Less than N
                            {
                                dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Quantity < " + "'" + N + "'";
                            }
                            else if (quantityEquations.Text.Equals("EQUAL TO")) // Equal to N
                            {
                                dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Quantity = " + "'" + N + "'";
                            }

                        }

                        // Entered quanitity is negative
                        
                        else
                        {
                            MessageBox.Show("Quantity must be greater than zero");
                            
                            stsStripLabel.Text = "";
                        }

                        dgTools.PopulateDataGrid(prodDataGridView);

                        int dataGridSize = 0;
                        foreach (DataGridViewRow row in prodDataGridView.Rows)
                        {
                            dataGridSize++;
                        }

                        stsStripLabel.Text = "There is/are " + (dataGridSize - 1) + " result(s) that matched your filter";

                    }

                    // Filtering by Location
                    else if (filterMenu.Text.Equals("Location"))
                    {
                        dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Location = " + "'" + location + "'";

                        dgTools.PopulateDataGrid(prodDataGridView);

                        int dataGridSize = 0;
                        foreach (DataGridViewRow row in prodDataGridView.Rows)
                        {
                            dataGridSize++;
                        }

                        stsStripLabel.Text = "There is/are " + (dataGridSize - 1) + " result(s) that matched your filter";
                    }
                }
                catch(FormatException)
                {
                    MessageBox.Show("Please input the correct information");
                    throw;
                }
            }

            // Filtering Raw Materials database
            else if (dgTools.dbName.Equals("RawMaterials"))
            {
                try
                {
                    // Filtering by Name
                    if (filterMenu.Text.Equals("Name"))
                    {
                        dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials WHERE RawMaterialName LIKE " + "'%" + info + "%'"; // Any matches of the inputted search term

                        dgTools.PopulateDataGrid(prodDataGridView);

                        int dataGridSize = 0;
                        foreach (DataGridViewRow row in prodDataGridView.Rows)
                        {
                            dataGridSize++;
                        }

                        stsStripLabel.Text = "There is/are " + (dataGridSize - 1) + " result(s) that matched your filter";
                    }

                    // Filtering by Quantity
                    else if (filterMenu.Text.Equals("Quantity"))
                    {
                        int N = int.Parse(txtNum.Text);

                        // Valid quanitity input greater than zero
                        if (N > 0)
                        {
                            // Inequality comparisons for quantity
                            if (quantityEquations.Text.Equals("GREATER THAN")) // Greater than N
                            {
                                dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials WHERE Quantity > " + "'" + N + "'";
                            }
                            else if (quantityEquations.Text.Equals("LESS THAN")) // Less than N
                            {
                                dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials WHERE Quantity < " + "'" + N + "'";
                            }
                            else if (quantityEquations.Text.Equals("EQUAL TO")) // Equal to N
                            {
                                dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials WHERE Quantity = " + "'" + N + "'";
                            }

                            int dataGridSize = 0;
                            foreach (DataGridViewRow row in prodDataGridView.Rows)
                            {
                                dataGridSize++;
                            }

                            stsStripLabel.Text = "There is/are " + (dataGridSize - 1) + " result(s) that matched your filter";
                        }

                        // Entered quanitity is less than or equal to zero
                        else
                        {
                            MessageBox.Show("Quantity must be greater than zero");
                            
                        }

                        dgTools.PopulateDataGrid(prodDataGridView);
                    }
                }
                catch (FormatException)
                {
                    //MessageBox.Show(err.Message, "Please input the correct information");
                    throw;
                }
            }
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            string ProductName = txtName.Text;
            int Quantity = int.Parse(txtQuantity.Text);
            dbTools = new DatabaseTools();

            // CHECK TO SEE IF CURRENT VIEW IS PRODUCT
            if (dgTools.dbName.Equals("Product"))
            {

            }
            Product newProduct = new Product(ProductName, "", Quantity, "");

            MessageBox.Show("Please Remove Necessary Raw Materials");

            viewMatBtn_Click(sender, e);

            addItemLbl.Text = "Remove Materials";

            addItemBtn.Visible = false;

            removeItemBtn.Visible = true;



           /* // Creating a new product object, adding it to the database, and auto refreshing the datagrid
            if (dbTools.CheckProduct(ProductName).Equals(true))
            {
                dbTools.EditProductQuant(ProductName, Quantity);
            }
            else
            {
                //MessageBox.Show("Why is this running?");
                Product newProduct = new Product(txtName.Text, "", int.Parse(txtQuantity.Text), "");
                dbTools.AddProduct(newProduct);
            }*/
            dgTools.RefreshDataGrid(prodDataGridView);

            // Clearing entered values
            txtName.Clear();
            txtQuantity.Clear();
            quantityEquations.Text = null;
        }

        private void filterMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgTools.dbName.Equals("Products"))
            {
                if (filterMenu.SelectedItem.Equals("Name"))
                {
                    // Disabling other options when searching for a name
                    cBoxQuality.Enabled = false;
                    txtNum.Enabled = false;
                    cBoxLocation.Enabled = false;
                    quantityEquations.Enabled = false;
                    txtFilterByItem.Enabled = true;
                }
                else if (filterMenu.SelectedItem.Equals("Quality"))
                {
                    // Disabling other options when searching for quality
                    txtNum.Enabled = false;
                    cBoxLocation.Enabled = false;
                    txtFilterByItem.Enabled = false;
                    quantityEquations.Enabled = false;
                    cBoxQuality.Enabled = true;
                }
                else if (filterMenu.SelectedItem.Equals("Quantity"))
                {
                    // Disabling other options when searching for quantity
                    cBoxQuality.Enabled = false;
                    cBoxLocation.Enabled = false;
                    txtFilterByItem.Enabled = false;
                    txtNum.Enabled = true;
                    quantityEquations.Enabled = true;
                }
                else if (filterMenu.SelectedItem.Equals("Location"))
                {
                    // Disabling other options when searching for location
                    txtFilterByItem.Enabled = false;
                    cBoxQuality.Enabled = false;
                    txtNum.Enabled = false;
                    quantityEquations.Enabled = false;
                    cBoxLocation.Enabled = true;
                }
            }
            else if (dgTools.dbName.Equals("RawMaterials"))
            {
                if (filterMenu.SelectedItem.Equals("Name"))
                {
                    // Disabling other options when searching for a name
                    cBoxQuality.Enabled = false;
                    txtNum.Enabled = false;
                    cBoxLocation.Enabled = false;
                    quantityEquations.Enabled = false;
                    txtFilterByItem.Enabled = true;
                }
                else if (filterMenu.SelectedItem.Equals("Quantity"))
                {
                    // Disabling other options when searching for quantity
                    cBoxLocation.Enabled = false;
                    cBoxQuality.Enabled = false;
                    txtFilterByItem.Enabled = false;
                    quantityEquations.Enabled = true;
                    txtNum.Enabled = true;
                }
            }
        }

        private void txtFilterByItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBoxQuality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quantityEquations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void removeItemBtn_Click(object sender, EventArgs e)
        {
            RawMaterial tempMaterial;

            if (dbTools.CheckMat(txtName.Text).Equals(true))
            {
                RawMaterial material = dbTools.GetRawMaterial(txtName.Text);
                int newQuantity = material.quantity - int.Parse(txtQuantity.Text);

                if (newQuantity > 0)
                {
                    dbTools.EditQuant(material.rawMaterialName, newQuantity);
                    //dgTools.RefreshDataGrid(prodDataGridView);
                }
                else
                {
                    MessageBox.Show("Not enough raw materials!");
                }
            }
            else
            {
                MessageBox.Show("Material does not exist!");
            }

            removeItemBtn.Visible = false;
            addItemBtn.Visible = true;
            
        }
    }
}
