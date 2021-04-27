using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace workflowLoginForm
{
    public partial class ProductManagerForm : Form
    {
        // Class level objects
        private RawMaterialsForm ReOrderStockForm; // For re ordering stock

        private DataGridTools dgTools; // Uses DataGridView to create the data grids on screen

        private DatabaseTools dbTools; // Edits quantity of products and raw materials in the database

        private Product newProduct; // For storing in newProducts -> Product object that is being added to the database

        private RawMaterial newMaterial; // For storing in A Raw Material object that 

        private List<Product> newProducts; // List of Product objects that are being added to the database

        private List<RawMaterial> matsQuantityToRemove; // Stores the Raw Material object with the amount that the user wants to remove 

        private List<RawMaterial> matsUpdatedQuantity; // Stores the Raw Material objects with their updated quantity after removing material(s)

        private List<String> strProductsBeingAdded; // List of strings for displaying products to be added

        private List<String> strMatsBeingRemoved; // List of strings for displaying raw materials to be removed

        private FilterTools filterTools;

        public bool addedItems { get; set; }


        // Constructor
        public ProductManagerForm()
        {
            InitializeComponent();

            // Instantiating class level objects
            dgTools = new DataGridTools();
            dbTools = new DatabaseTools();
            newProducts = new List<Product>();
            matsQuantityToRemove = new List<RawMaterial>();
            filterTools = new FilterTools();
        }

        private void ConfirmChanges(Object sender, EventArgs e)
        {
            if (addedItems.Equals(true))
            {
                // Pressing confirm after adding products
                if (dgTools.dbName.Equals("Products"))
                {
                    MessageBox.Show("Please Remove Necessary Raw Materials");

                    viewMatBtn_Click(sender, e); // Switch to Raw Materials data grid view

                    addItemLbl.Text = "Remove Materials";

                    // Switching from Add button to Remove button
                    addItemBtn.Visible = false;
                    removeItemBtn.Visible = true;
                }

                // Pressing confirm after removing materials
                else
                {
                    // Creating a formatted string from the products and raw materials
                    string prod = String.Join("\n", strProductsBeingAdded); // Joining each item in the list with a newline at the end
                    string mat = String.Join("\n", strMatsBeingRemoved);

                    // Listing the products and raw materials on the screen
                    string confirm = "You are adding:\n" +
                                        prod + "\n\n" +
                                        "You are removing:\n" +
                                        mat + "\n\n" +
                                        "Is this correct?";

                    // Yes or no to confirm
                    DialogResult result = MessageBox.Show(confirm, "Confirm Changes", MessageBoxButtons.YesNo); // Confirming changes

                    // If user selects yes, update the databases
                    if (result.Equals(DialogResult.Yes))
                    {
                        // Switching back to the Add button from the Remove button
                        addItemBtn.Visible = true;
                        removeItemBtn.Visible = false;

                        try
                        {
                            // Clear items from list boxes
                            itemsView.Items.Clear();
                            rawMatsView.Items.Clear();

                            // Adding all new products to the database
                            foreach (Product p in newProducts)
                            {
                                if (dbTools.CheckProduct(p.productName).Equals(true)) // If product already exists, update the quantity on it
                                {
                                    // Adding the new product quantity to the existing product
                                    Product tempProduct = dbTools.GetProduct(p.productName); // Returns a product object with the current quantity before changes

                                    int newQuant = tempProduct.quantity + p.quantity; // Calculating new quantity after removing items

                                    dbTools.EditProductQuant(p.productName, newQuant); // Editing the product quantity in the database to reflect changes
                                }
                                else
                                {
                                    // If product is not already in the database, add a new entry
                                    dbTools.AddProduct(p);
                                }
                            }

                            // Updating the raw materials database to the new values
                            foreach (RawMaterial m in matsUpdatedQuantity)
                            {
                                dbTools.EditQuant(m.rawMaterialName, m.quantity);
                            }
                            toolStripStatusLabel1.Text = "Successfully created new product(s) with raw material(s)!";

                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message, "A database issue occurred. Please try again");
                        }

                        // Going back to product view
                        viewProdBtn_Click(sender, e);

                        // Clearing all lists
                        if (newProducts != null)
                        {
                            newProducts.Clear();
                        }
                        if (matsUpdatedQuantity != null)
                        {
                            matsUpdatedQuantity.Clear();
                        }
                        if (matsQuantityToRemove != null)
                        {
                            matsQuantityToRemove.Clear();
                        }
                        if (strMatsBeingRemoved != null)
                        {
                            strMatsBeingRemoved.Clear();
                        }
                        if (strProductsBeingAdded != null)
                        {
                            strProductsBeingAdded.Clear();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Must add products before continuing.", "Warning!");
            }
        }
        private void FilterSwitch(string dbName)
        {
            if (dbName.Equals("Products"))
            {
                switch(filterMenu.SelectedItem)
                {
                    case "Name":
                        // Disabling other options when searching for a name
                        cBoxQuality.Enabled = false;
                        txtNum.Enabled = false;
                        cBoxLocation.Enabled = false;
                        quantityEquations.Enabled = false;
                        txtFilterByItem.Enabled = true;
                        break;

                    case "Quality":
                        // Disabling other options when searching for quality
                        txtNum.Enabled = false;
                        cBoxLocation.Enabled = false;
                        txtFilterByItem.Enabled = false;
                        quantityEquations.Enabled = false;
                        cBoxQuality.Enabled = true;
                        break;

                    case "Quantity":
                        // Disabling other options when searching for quantity
                        cBoxQuality.Enabled = false;
                        cBoxLocation.Enabled = false;
                        txtFilterByItem.Enabled = false;
                        txtNum.Enabled = true;
                        quantityEquations.Enabled = true;
                        break;

                    case "Location":
                        // Disabling other options when searching for location
                        txtFilterByItem.Enabled = false;
                        cBoxQuality.Enabled = false;
                        txtNum.Enabled = false;
                        quantityEquations.Enabled = false;
                        cBoxLocation.Enabled = true;
                        break;

                    default:
                        MessageBox.Show("Not a valid selection", "Warning!");
                        break;
                }
            }
            else if (dbName.Equals("RawMaterials"))
            {
                switch (filterMenu.SelectedItem)
                {
                    case "Name":
                        // Disabling other options when searching for a name
                        cBoxQuality.Enabled = false;
                        txtNum.Enabled = false;
                        cBoxLocation.Enabled = false;
                        quantityEquations.Enabled = false;
                        txtFilterByItem.Enabled = true;
                        break;

                    case "Quantity":
                        // Disabling other options when searching for quantity
                        cBoxLocation.Enabled = false;
                        cBoxQuality.Enabled = false;
                        txtFilterByItem.Enabled = false;
                        quantityEquations.Enabled = true;
                        txtNum.Enabled = true;
                        break;

                    default:
                        MessageBox.Show("Not a valid selection", "Warning!");
                        break;
                }
            }
        }



        private void ClearFilteringFields()
        {
            txtFilterByItem.Clear();
            cBoxLocation.Text = null;
            cBoxQuality.Text = null;
            txtNum.Clear();
            quantityEquations.ResetText();
            stsStripLabel.Text = "";
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



        // Event handler for View Products button click
        private void viewProdBtn_Click(object sender, EventArgs e)
        {
            filterMenu.Text = "Click to expand..."; // Resetting the filter menu text

            // Clear filtering fields
            ClearFilteringFields();

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

        // Event handler for View Materials button click
        private void viewMatBtn_Click(object sender, EventArgs e)
        {
            filterMenu.Text = "Click to expand..."; // Resetting the filter menu text

            // Clear filtering fields
            ClearFilteringFields();

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
        // Event handler for Filter button click
        private void btnFilter_Click(object sender, EventArgs e)
        {
            filterTools.dbName = dgTools.dbName;
            string db = dgTools.dbName;
            string name = txtFilterByItem.Text;
            string num = txtNum.Text;
            string ql = cBoxQuality.Text;
            string l = cBoxLocation.Text;
            string eq = quantityEquations.Text;
            string menu = filterMenu.Text;
            filterTools.ProductManagerFilterDatagrid(name, ql, l, num, eq, prodDataGridView, stsStripLabel, menu);
        }

        
        // Event handler for Add button click
        private void addItemBtn_Click(object sender, EventArgs e)
        {
            addedItems = false;
            try
            {
                strProductsBeingAdded = new List<String>(); // For formatting items into a string to confirm changes on screen

                // Getting the text fields on screen
                string ProductName = txtName.Text;
                int Quantity = int.Parse(txtQuantity.Text);

                newProduct = new Product(ProductName, "", Quantity, ""); // Creating Product object with the text fields
                newProducts.Add(newProduct);

                // Clear list view
                itemsView.Items.Clear();

                // Format each product to display in list views
                foreach (Product prod in newProducts)
                {
                    string s = prod.quantity.ToString() + "x " + prod.productName; // Format to display -> (quantity)x (name)
                    strProductsBeingAdded.Add(s);
                    itemsView.Items.Add(s);
                }


                // Creating a new product object, adding it to the database, and auto refreshing the datagrid

                dgTools.RefreshDataGrid(prodDataGridView);

                // Clearing entered values
                txtName.Clear();
                txtQuantity.Clear();
                quantityEquations.Text = null;
                addedItems = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot add empty product.\nPlease try again.", "Warning!"); // User tries to add a product before typing anything in
                addedItems = false;
            }
        }

        
        // Event handler for filter menu drop down
        private void filterMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSwitch(dgTools.dbName);
        }


        // Event handler for Remove button click
        private void removeItemBtn_Click(object sender, EventArgs e)
        {
            // Creating lists
            strMatsBeingRemoved = new List<String>();
            matsUpdatedQuantity = new List<RawMaterial>(); 


            if (dbTools.CheckMat(txtName.Text).Equals(true)) // Checking if the material exists in the database
            {
                RawMaterial tempMaterial = dbTools.GetRawMaterial(txtName.Text); // Getting the raw material object with the given name from the database

                int newQuantity = tempMaterial.quantity - int.Parse(txtQuantity.Text); // Calculating the new quantity after subtracting the amount being taken out


                // NO DUPLICATE ENTRIES
                // Quantity cannot be negative after subtracting
                if (newQuantity > 0)
                {
                    tempMaterial.quantity = int.Parse(txtQuantity.Text); // Setting the object quantity to what the user inputs

                    matsQuantityToRemove.Add(tempMaterial); // Adding material to a list of raw material objects with the user inputted quantity


                    newMaterial = new RawMaterial(tempMaterial.rawMaterialName, newQuantity); // What we want the product to be after making changes

                    matsUpdatedQuantity.Add(newMaterial); // Adding that to a list to track its quantity 


                    rawMatsView.Items.Clear(); // Clearing list view

                    // Format each material to display in list views
                    foreach (RawMaterial mat in matsQuantityToRemove)
                    {
                        string s = mat.quantity.ToString() + "x " + mat.rawMaterialName; // Format to display -> (quantity)x (name) 
                        strMatsBeingRemoved.Add(s);
                        rawMatsView.Items.Add(s);
                    }

                    // Clear text fields
                    txtName.Clear();
                    txtQuantity.Clear();
                }
                else
                {
                    MessageBox.Show("Not enough raw materials!", "Warning!");
                    txtQuantity.Clear();
                }
            }
            else
            {
                MessageBox.Show("Material does not exist!", "Warning!");
            }
        }


        // Event handler for Confirm button click
        private void confirmChangesBtn_Click(object sender, EventArgs e)
        {
            ConfirmChanges(sender, e);
        }

        // Automatically filtering by name as user types in the field
        private void txtFilterByItem_TextChanged(object sender, EventArgs e)
        {
            btnFilter_Click(sender, e);
        }


        // Event handler for clicking on a row in the data grid
        private void prodDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgTools.dbName.Equals("Products"))
            {
                // Update the text fields to display the selected product info
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = prodDataGridView.Rows[e.RowIndex]; // Creating a row object from the currently selected row
                    txtName.Text = row.Cells[0].Value.ToString(); // Selecting the product name from the row object
                }
            }
            else
            {
                // Update the text fields to display the selected product info
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = prodDataGridView.Rows[e.RowIndex];
                    txtName.Text = row.Cells[0].Value.ToString();
                    //txtQuantity.Text = row.Cells[1].Value.ToString();
                }
            }
        }

        // Event handler for Go Back menu item click
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        // Event handler for Exit menu item click
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler for Refresh menu item click
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear the filtering text fields when refreshing data grid
            filterMenu.Text = String.Empty;
            txtFilterByItem.Clear();
            txtName.Text = String.Empty;
            cBoxLocation.Text = null;
            cBoxQuality.Text = null;
            txtNum.Clear();
            quantityEquations.Text = null;

            // Re-enabling all filter fields
            cBoxQuality.Enabled = true;
            cBoxLocation.Enabled = true;
            txtFilterByItem.Enabled = true;
            txtNum.Enabled = true;
            quantityEquations.Enabled = true;

            // Clearing all lists
            if (newProducts != null)
            {
                newProducts.Clear();
            }
            if (matsUpdatedQuantity != null)
            {
                matsUpdatedQuantity.Clear();
            }
            if (matsQuantityToRemove != null)
            {
                matsQuantityToRemove.Clear();
            }
            if (strMatsBeingRemoved != null)
            {
                strMatsBeingRemoved.Clear();
            }
            if (strProductsBeingAdded != null)
            {
                strProductsBeingAdded.Clear();
            }




            // Clearing all list views
            itemsView.Items.Clear();
            rawMatsView.Items.Clear();


            // Viewing Products
            if (dgTools.dbName.Equals("Products"))
            {
                dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products";

                dgTools.RefreshDataGrid(prodDataGridView);
            }

            // Viewing Raw Materials
            else if (dgTools.dbName.Equals("RawMaterials"))
            {
                removeItemBtn.Visible = false;
                addItemBtn.Visible = true;
                addItemLbl.Text = "Add Product";

                dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials"; // Viewing all data from RawMaterials database except the ID

                dgTools.RefreshDataGrid(prodDataGridView);
            }

        }


        private void productTableToolStripMenuItem_Click(object sender, EventArgs e)
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

            // Switching from Add button to Remove button
            addItemBtn.Visible = true;
            removeItemBtn.Visible = false;

            // Switching text for adding products
            addItemLbl.Text = "Add Product";
        }

        private void materialsTableToolStripMenuItem_Click(object sender, EventArgs e)
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

            // Switching from Add button to Remove button
            addItemBtn.Visible = false;
            removeItemBtn.Visible = true;

            // Switching text to removing materials
            addItemLbl.Text = "Remove Materials";
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            // Setting the working directory to Reports folder
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName + @"\Reports";
            openFile.InitialDirectory = projectDirectory;

            openFile.ShowDialog();
            if (openFile.FileName.Any())
            {
                System.Diagnostics.Process.Start(openFile.FileName);
            }
        }

        private void reOrderStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReOrderStockForm = new RawMaterialsForm("Order Stock", "Re-Order Raw Materials"); // Change the name of the titles on the form
            ReOrderStockForm.ShowDialog();
            this.Show();
        }
    }
}
