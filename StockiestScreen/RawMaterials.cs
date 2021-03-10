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

namespace RawMaterials
{
    public partial class RawMaterials : Form
    {
        // Constructor
        public RawMaterials()
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
            SqlCommand one = new SqlCommand("Insert into RawMaterials(RawMaterialName, Quantity) Values(@RawMaterialName,  @Quantity);", connectionOne);
            //add information from the text boxes into the databse itself
            one.Parameters.AddWithValue("@RawMatName", txtRawMatName.Text);
            one.Parameters.AddWithValue("@Quanity", txtRawMatQuanity.Text);


            //open connection
            connectionOne.Open();
            //execute the query above 
            one.ExecuteNonQuery();
            //close connection
            connectionOne.Close();
            MessageBox.Show("Item enterted Successfully");

            //clear text boxes
            txtRawMatName.Clear();
            txtRawMatQuanity.Clear();
        }

        // Event handler for Exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

