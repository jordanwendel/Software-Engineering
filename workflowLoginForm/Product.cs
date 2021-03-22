using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace workflowLoginForm
{
    class Product
    {
        private string productName { get; set; }
        private string quality { get; set; }
        private int quanity { get; set; }
        private string location { get; set; }

        //default constructor
        public Product()
        {

        }

        //constructor
        public Product(string productName, string quality, int quanity, string location)
        {
            this.productName = productName;
            this.quality = quality;
            this.quanity = quanity;
            this.location = location;

        }

        public void addProductInfo()
        {
            string con = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\justi\\Source\\Repos\\WORK - FLOW\\workflowLoginForm\\UserLoginData.mdf; Integrated Security = True";

            //create a new sql connection to 
            SqlConnection connectionOne = new SqlConnection(con);

            // sql command to insert information into a sql database
            SqlCommand one = new SqlCommand("Insert into Products(ProductName, Quality, Quantity, Location) Values(@ProductName, @Quality, @Quantity, @Location);", connectionOne);
            //add information from the text boxes into the databse itself
            one.Parameters.AddWithValue("@ProductName",productName);
            one.Parameters.AddWithValue("@Quality", quality);
            one.Parameters.AddWithValue("@Quantity", quanity);
            one.Parameters.AddWithValue("@Location", location);

            //open connection
            connectionOne.Open();
            //execute the query above 
            one.ExecuteNonQuery();
            //close connection
            connectionOne.Close();
            
        }
    }
}
