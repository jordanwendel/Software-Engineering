using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace workflowLoginForm
{
    class RawMaterial
    {
        private string rawMaterialName;
        private int quantity;

        //default constructor
        public RawMaterial()
        {

        }

        //constructor
        public RawMaterial(string rawMaterialName, int quantity)
        {
            this.rawMaterialName = rawMaterialName;
            this.quantity = quantity;
        }

        public void addRawMaterialInfo()
        {
            // string connection path
            string con = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\justi\\Source\\Repos\\WORK - FLOW\\workflowLoginForm\\UserLoginData.mdf; Integrated Security = True";

            //create a new sql connection to 
            SqlConnection connectionOne = new SqlConnection(con);

            // sql command to insert information into a sql database
            SqlCommand one = new SqlCommand("Insert into RawMaterials(RawMaterialName, Quantity) Values(@RawMaterialName,  @Quantity);", connectionOne);
            //add information from the text boxes into the databse itself
            one.Parameters.AddWithValue("@RawMatName", rawMaterialName);
            one.Parameters.AddWithValue("@Quanity", quantity);


            //open connection
            connectionOne.Open();
            //execute the query above 
            one.ExecuteNonQuery();
            //close connection
            connectionOne.Close();
        }
    }
}
