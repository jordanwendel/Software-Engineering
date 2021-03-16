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

        // Event handler for Insert Information button
        private void btnInsertInformation_Click(object sender, EventArgs e)
        {
            // string connection path
            string con = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\justi\\Source\\Repos\\WORK - FLOW\\workflowLoginForm\\UserLoginData.mdf; Integrated Security = True"; 

            //create a new sql connection to 
            SqlConnection connectionOne = new SqlConnection(con);
            
            // sql command to insert information into a sql database
            SqlCommand one = new SqlCommand("Insert into Products(ProductName, Quality, Quantity, Location) Values(@ProductName, @Quality, @Quantity, @Location);", connectionOne);
            //add information from the text boxes into the databse itself
            one.Parameters.AddWithValue("@ProductName", txtProductName.Text);
            one.Parameters.AddWithValue("@Quality", txtQuality.Text);
            one.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
            one.Parameters.AddWithValue("@Location", txtLocation.Text);

            //open connection
            connectionOne.Open();
            //execute the query above 
            one.ExecuteNonQuery();
            //close connection
            connectionOne.Close();
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

    }
}

