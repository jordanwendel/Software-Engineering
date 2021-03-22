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
        // Constructor
        public ProductForm()
        {
            InitializeComponent();
        }

        //create Product object
        private Product objProduct;

        // Event handler for Insert Information button
        private void btnInsertInformation_Click(object sender, EventArgs e)
        {
            //assign objProduct
            objProduct = new Product(txtProductName.Text, txtQuality.Text, int.Parse(txtQuantity.Text), txtLocation.Text);
           
            //add item to the database
            objProduct.addProductInfo();

            MessageBox.Show("Item enterted Successfully");

            //clear text boxes
            txtProductName.Clear();
            txtQuality.Clear();
            txtQuantity.Clear();
            txtLocation.Clear();
        }

        // Event handler for Exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}

