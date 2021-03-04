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

namespace Product
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void btnInsertInformation_Click(object sender, EventArgs e)
        {
            string con = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\justi\\Source\\Repos\\WORK - FLOW\\workflowLoginForm\\UserLoginData.mdf; Integrated Security = True";

            SqlConnection connectionOne = new SqlConnection(con);

            SqlCommand one = new SqlCommand("Insert into Products(ProductName, Quality, Quantity, Location) Values(@ProductName, @Quality, @Quantity, @Location);", connectionOne);
            one.Parameters.AddWithValue("@ProductName", txtProductName.Text);
            one.Parameters.AddWithValue("@Quality", txtQuality.Text);
            one.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
            one.Parameters.AddWithValue("@Location", txtLocation.Text);

            connectionOne.Open();
            one.ExecuteNonQuery();
            connectionOne.Close();
            MessageBox.Show("Item enterted Successfully");
            txtProductName.Clear();
            txtQuality.Clear();
            txtQuantity.Clear();
            txtLocation.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}

