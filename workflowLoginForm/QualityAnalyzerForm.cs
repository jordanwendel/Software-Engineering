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
    public partial class QualityAnalyzerForm : Form
    {
        // Class level objects
        private DatabaseTools dbTools;
        private DataGridTools dgTools;

        // Variables

        public QualityAnalyzerForm()
        {
            InitializeComponent();
            dgTools = new DataGridTools();
        }

        private void Admin_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products";
            
            dgTools.RefreshDataGrid(prodDataGridView);

        }

        private void Admin_Click_1(object sender, EventArgs e)
        {

        }

        private void Logout_Click_1(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void QualityAnalyzerForm_Load(object sender, EventArgs e)
        {
            dgTools.dbName = "Products";
            
            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products";
            
            dgTools.PopulateDataGrid(prodDataGridView);

        }

        private void addProduct_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
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

            // Clearing text fields
            ItemName.Clear();
            qualityMenu.Text = String.Empty;


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

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            String ProductName = ItemName.Text;
            String Quality = qualityMenu.Text;
            dbTools = new DatabaseTools();

            dbTools.CheckProduct(ProductName);

            if (dbTools.CheckProduct(ProductName).Equals(true))
            {
                try
                {
                    dbTools.EditQuality(ProductName, Quality);
                    Refresh_Click(sender, e);
                    
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Warning!");
                }
            }
            else
            {
                MessageBox.Show("This item can not be found.");

            }
        }

        private void qualityLbl_Click(object sender, EventArgs e)
        {

        }

        private void filterLbl_Click(object sender, EventArgs e)
        {

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

        // Automatically filtering by name as user types in the field
        private void txtFilterByItem_TextChanged(object sender, EventArgs e)
        {
            btnFilter_Click(sender, e);
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

                    }

                    // Filtering by Quality
                    else if (filterMenu.Text.Equals("Quality"))
                    {
                        dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Quality = " + "'" + qual + "'";

                        dgTools.PopulateDataGrid(prodDataGridView);

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
                        }

                        dgTools.PopulateDataGrid(prodDataGridView);

                    }

                    // Filtering by Location
                    else if (filterMenu.Text.Equals("Location"))
                    {
                        dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Location = " + "'" + location + "'";

                        dgTools.PopulateDataGrid(prodDataGridView);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please input the correct information");
                    throw;
                }
            }    
            
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void prodDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = prodDataGridView.Rows[e.RowIndex];
                ItemName.Text = row.Cells[0].Value.ToString();
            }
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
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

            // Clearing text fields
            ItemName.Clear();
            qualityMenu.Text = String.Empty;


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
    }
}
