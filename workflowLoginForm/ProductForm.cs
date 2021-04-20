using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace workflowLoginForm
{
    public partial class ProductForm : Form
    {
        // Class level objects
        private Product objProduct;
        private DatabaseTools dbTools;

        // Constructor
        public ProductForm()
        {
            InitializeComponent();
            dbTools = new DatabaseTools();
        }

        // Event handler for Insert Information button
        private void btnInsertInformation_Click(object sender, EventArgs e)
        {
            try
            {
                // Assign objProduct
                objProduct = new Product(txtProductName.Text, txtQuality.Text, int.Parse(txtQuantity.Text), txtLocation.Text); // Create a new product object
                dbTools.AddProduct(objProduct); // Add product object to database

                lblProductAddedStatus.Text = "Item Added Successfully!"; // Display a success message on screen

                //clear text boxes
                txtProductName.Clear();
                txtQuality.Clear();
                txtQuantity.Clear();
                txtLocation.Clear();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }

            //this.Hide();
        }

        // Event handler for Exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            txtProductName.Clear();
            txtQuality.Clear();
            txtQuantity.Clear();
            txtLocation.Clear();
            this.Hide();
        }

        private void btnExit_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

