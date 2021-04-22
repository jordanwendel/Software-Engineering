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
        private DataGridTools dgTools;


        // Constructor
        public StockiestForm()
        {
            InitializeComponent();
            dgTools = new DataGridTools();
        }

        // Event handler for Stockiest Form load
        private void StockiestForm_Load(object sender, EventArgs e)
        {
            // Fill the data grid view on form with contents of given database using a data grid object
            dgTools.dbName = "RawMaterials";

            dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials"; // Viewing all data from RawMaterials database except the ID
            
            dgTools.PopulateDataGrid(stockDataGridView);

        }

        // Event handler for Logout button click
        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for Refresh Inventory button click
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            // Clear the filtering text fields when refreshing data grid
            filterMenu.Text = "Click to expand...";
            txtFilterByItem.Clear();
            txtNum.Clear();
            quantityEquations.Text = null;

            // Re-enabling all search fields
            txtFilterByItem.Enabled = true;
            txtNum.Enabled = true;
            quantityEquations.Enabled = true;


            // Viewing Raw Materials
            if (dgTools.dbName.Equals("RawMaterials"))
            { dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials"; // Viewing all data from RawMaterials database except the ID

                dgTools.RefreshDataGrid(stockDataGridView);
               
            }

        }

        // Event handler for Add New button click
        private void addNewMat_Btn_Click(object sender, EventArgs e)
        {
            stockpage = new RawMaterialsForm();
            stockpage.ShowDialog(); // Open new display
            this.Show();
        }

        private void addNewMatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String MatName = itembox.Text;
                int Quant = int.Parse(qtnBox.Text);
                dbTools = new DatabaseTools();

                if (dbTools.CheckMat(MatName).Equals(true))
                {
                    try
                    {
                        dbTools.EditQuant(MatName, Quant);
                        dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials"; // Viewing all data from RawMaterials database except the ID
                        dgTools.RefreshDataGrid(stockDataGridView);
                        itembox.Clear();
                        qtnBox.Clear();

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
            catch(Exception err)
            {
                MessageBox.Show("Please input a value and quantity", "Warning!");
            }
        }

        private void filterMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (dgTools.dbName.Equals("RawMaterials"))
            {
                if (filterMenu.SelectedItem.Equals("Name"))
                {
                    // Disabling other options when searching for a name
                    txtNum.Enabled = false;
                    quantityEquations.Enabled = false;
                    txtFilterByItem.Enabled = true;
                }
                else if (filterMenu.SelectedItem.Equals("Quantity"))
                {
                    // Disabling other options when searching for quantity
                    txtFilterByItem.Enabled = false;
                    quantityEquations.Enabled = true;
                    txtNum.Enabled = true;
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string info = txtFilterByItem.Text;

            // Filtering Raw Materials database
            if (dgTools.dbName.Equals("RawMaterials"))
            {
                try
                {
                    // Filtering by Name
                    if (filterMenu.Text.Equals("Name"))
                    {
                        dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials WHERE RawMaterialName LIKE " + "'%" + info + "%'"; // Any matches of the inputted search term

                        dgTools.PopulateDataGrid(stockDataGridView);
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
                        }

                        // Entered quanitity is less than or equal to zero
                        else
                        {
                            MessageBox.Show("Quantity must be greater than zero");
                        }

                        dgTools.PopulateDataGrid(stockDataGridView);
                    }
                }
                catch (FormatException)
                {
                    //MessageBox.Show(err.Message, "Please input the correct information");
                    throw;
                }
            }
        }

        // Automatically filtering by name as user types in the field
        private void txtFilterByItem_TextChanged(object sender, EventArgs e)
        {
            btnFilter_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = stockDataGridView.Rows[e.RowIndex];
                itembox.Text = row.Cells[0].Value.ToString();
            }
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear the filtering text fields when refreshing data grid
            filterMenu.Text = "Click to expand...";
            txtFilterByItem.Clear();
            txtNum.Clear();
            quantityEquations.Text = null;

            // Re-enabling all search fields
            txtFilterByItem.Enabled = true;
            txtNum.Enabled = true;
            quantityEquations.Enabled = true;


            // Viewing Raw Materials
            if (dgTools.dbName.Equals("RawMaterials"))
            {
                dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials"; // Viewing all data from RawMaterials database except the ID

                dgTools.RefreshDataGrid(stockDataGridView);

            }
        }

        private void viewProductReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            if (openFile.FileName.Any())
            {
                System.Diagnostics.Process.Start(openFile.FileName);
            }
        }
    }
}
