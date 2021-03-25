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
            // Fill the data grid view on form with contents of given database using a data grid object
            dbTools = new DatabaseTools();
            dbTools.PopulateDataGrid(prodDataGridView, "Products");

            // Setting attributes for data grid
            prodDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            prodDataGridView.RowsDefaultCellStyle.BackColor = Color.Wheat;
            prodDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Event handler for Refresh Inventory button click
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dbTools = new DatabaseTools();
            dbTools.RefreshDataGrid(prodDataGridView, "Products"); // Refresh the data grid to see changes
        }

        private void prodDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filterLbl_Click(object sender, EventArgs e)
        {

        }

        private void locationLbl_Click(object sender, EventArgs e)
        {

        }

        private void quantityLbl_Click(object sender, EventArgs e)
        {

        }

        private void qualityLbl_Click(object sender, EventArgs e)
        {

        }

        private void nameLbl_Click(object sender, EventArgs e)
        {

        }

        private void locationMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quantityTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void qualityMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addItemLbl_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {

        }
    }
}
