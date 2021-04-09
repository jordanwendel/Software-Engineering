using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace workflowLoginForm
{
    public partial class DatabaseTools // For manipulating data in a database
    {
        // Class level objects
        public SqlConnection cn { get; set; }
        public SqlDataReader reader;
        public SqlCommand cmd;
        //private SqlDataAdapter sqlDa;


        // Variables
        private readonly string connectionString = Properties.Settings.Default.connectionString; // Database connection string stored in Properties -> Settings.settings

        public DatabaseTools()
        {
            //this.dbName = dbName; // For storing the optional database name parameter

            // Error handling
            try
            {
                cn = new SqlConnection(); // Establishing sql connection
                cn.ConnectionString = connectionString;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }


        // Methods


        // Adds raw material to database with given name and quantity
        public void AddRawMaterial(string rawMaterialName, int quantity) // May be better to use a RawMaterial object instead
        {
            try
            {
                // Create a SQL command that takes user input -- raw material name, quantity -- and inputs into RawMaterials database
                cn.Open();
                cmd = new SqlCommand("Insert into RawMaterials(RawMaterialName, Quantity) Values(@RawMaterialName,  @Quantity);", cn);
                cmd.Parameters.AddWithValue("@RawMaterialName", rawMaterialName);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.ExecuteNonQuery(); // Execute the sql command
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
            finally
            {
                cn.Close();
            }
        }



        // Adds product to database with given name, quality, quantity, and location
        public void AddProduct(string name, string quality, int quantity, string location) // May be better to use a Product object instead
        {
            try
            {
                // Create a sql command that takes user input -- product name, quality, quantity, location -- and inputs into Products database
                cn.Open();
                cmd = new SqlCommand("Insert into Products(ProductName, Quality, Quantity, Location) Values(@ProductName, @Quality, @Quantity, @Location);", cn);
                cmd.Parameters.AddWithValue("@ProductName", name);
                cmd.Parameters.AddWithValue("@Quality", quality);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Location", location);

                cmd.ExecuteNonQuery(); // Execute the sql command

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
            finally
            {
                cn.Close();
            }
        }



        public bool CheckMat(string RawMaterialName)
        {
            bool Exists = false;

            // Open connection and execute sql command
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT Count (*) From RawMaterials WHERE RawMaterialName = Trim(@RawMaterialName)", cn);
                cmd.Parameters.AddWithValue("@RawMaterialName", RawMaterialName);

                // Opens database, grabs and returns password
                int MatExists = (int)cmd.ExecuteScalar();

                if (MatExists > 0) // Checks if entered password matches the one grabbed from database
                {
                    Exists = true;
                }

            }
            catch (Exception err) // Handles exception
            {
                MessageBox.Show(err.Message, "Warning!");
            }
            finally
            {
                cn.Close();
            }

            return Exists;
        }
    

        public bool CheckProduct(string ProductName)
        {
            bool Exists = false;

            // Open connection and execute sql command
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT Count (*) FROM Products WHERE ProductName = @ProductName", cn); // Grabs password from associated username in database that matches the username input on the login screen
                cmd.Parameters.AddWithValue("@ProductName", ProductName);

                // Opens database, grabs and returns password

                int ProductExists = (int)cmd.ExecuteScalar();

                if (ProductExists > 0) // Checks if entered password matches the one grabbed from database
                {
                    Exists = true;
                }

            }
            catch (Exception err) // Handles exception
            {
                MessageBox.Show(err.Message, "Warning!");
            }
            finally
            {
                cn.Close();
            }
            return Exists;
        }


        public void EditQuant(string RawMaterialName, int Quant)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("Update RawMaterials Set Quant = @Quantity Where RawMaterialName = @RawMaterialName", cn);
                cmd.Parameters.AddWithValue("@RawMaterialName", RawMaterialName);
                cmd.Parameters.AddWithValue("@Quantity", Quant);
                cmd.ExecuteNonQuery(); // Execute the sql command
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
            finally
            {
                cn.Close();
            }
        }


        public void EditLocation(string ProductName, string Location) 
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("Update Products Set Location = @Location Where ProductName = @ProductName", cn);
                cmd.Parameters.AddWithValue("@ProductName", ProductName);
                cmd.Parameters.AddWithValue("@Location", Location);

                cmd.ExecuteNonQuery(); // Execute the sql command

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
            finally
            {
                cn.Close();
            }
        }

        public void EditQuality(string ProductName, string Quality)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("Update Products Set Quality = @Quality Where ProductName = @ProductName", cn);
                cmd.Parameters.AddWithValue("@ProductName", ProductName);
                cmd.Parameters.AddWithValue("@Quality", Quality);

                cmd.ExecuteNonQuery(); // Execute the sql command

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
            finally
            {
                cn.Close();
            }
        }

    }

    }
