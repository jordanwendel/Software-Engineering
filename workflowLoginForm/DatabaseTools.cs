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
    public class DatabaseTools
    {
        // Class level objects
        public SqlConnection Cn { get; set; }
        public SqlDataReader reader;
        public SqlCommand cmd;


        // Variables
        private readonly string connectionString = Properties.Settings.Default.connectionString; // Database connection string stored in Properties -> Settings.settings

        public DatabaseTools()
        {
            // Error handling
            try
            {
                Cn = new SqlConnection(); // Establishing sql connection
                Cn.ConnectionString = connectionString;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }


        // Methods

        // Create a list of products for csv report generation
        public List<Product> CreateProductList(string filter)
        {
            List<Product> products;
            products = new List<Product>();
            Product tempProduct;

            Cn.Open();

            try
            {
                // Switch case for returning different products based on parameter
                switch (filter)
                {
                    case "In Progress":
                        // Create a list of products in progress
                        cmd = new SqlCommand("SELECT TRIM(ProductName) AS ProductName, TRIM(Quality) AS Quality, Quantity, TRIM(Location) AS Location FROM Products WHERE Quality = ''", Cn);
                        break;

                    case "Qualified":
                        // Create a list of qualified products
                        cmd = new SqlCommand("SELECT TRIM(ProductName) AS ProductName, TRIM(Quality) AS Quality, Quantity, TRIM(Location) AS Location FROM Products WHERE Quality = 'Satisfactory'", Cn);
                        break;

                    case "Defective":
                        cmd = new SqlCommand("SELECT TRIM(ProductName) AS ProductName, TRIM(Quality) AS Quality, Quantity, TRIM(Location) AS Location FROM Products WHERE Quality = 'Defective'", Cn);
                        // Create a list of defective products
                        break;

                    default:
                        // Create a list of all products
                        cmd = new SqlCommand("SELECT TRIM(ProductName) AS ProductName, TRIM(Quality) AS Quality, Quantity, TRIM(Location) AS Location FROM Products", Cn);
                        break;
                }

                reader = cmd.ExecuteReader();

                // Getting information from database
                while (reader.Read())
                {
                    string name = (string)reader["ProductName"];
                    string quality = (string)reader["Quality"];
                    int quantity = (int)reader["Quantity"];
                    string location = (string)reader["Location"];
                    tempProduct = new Product(name, quality, quantity, location);
                    products.Add(tempProduct);
                }

                reader.Close();
            }
            catch (Exception err)
            {
                throw;
            }
            finally
            {
                Cn.Close();
            }

            return products;
        }

        // Function to return a list of products from the product database
        public List<RawMaterial> CreateRawMaterialList()
        {
            // Create a new list of Products
            List<RawMaterial> rawMaterials;
            rawMaterials = new List<RawMaterial>();

            try
            {
                RawMaterial tempMaterial;

                // Create the sql command
                Cn.Open();
                cmd = new SqlCommand("SELECT TRIM(RawMaterialName) AS RawMaterialName, Quantity FROM RawMaterials", Cn);
                reader = cmd.ExecuteReader();

                // Get the information from the Products databse and add it to the list of Product objects
                while (reader.Read())
                {
                    string name = (string)reader["RawMaterialName"];
                    int quantity = (int)reader["Quantity"];
                    tempMaterial = new RawMaterial(name, quantity);
                    rawMaterials.Add(tempMaterial);                
                }

                reader.Close();
            }
            catch (Exception err)
            {
                throw;
            }
            finally
            {
                Cn.Close();
            }

            return rawMaterials;
        }


        // Adds raw material to database with given name and quantity
        public void AddRawMaterial(RawMaterial rawMaterial)
        {
            try
            {
                // Create a SQL command that takes user input -- raw material name, quantity -- and inputs into RawMaterials database
                Cn.Open();
                cmd = new SqlCommand("Insert into RawMaterials(RawMaterialName, Quantity) Values(@RawMaterialName,  @Quantity);", Cn);
                cmd.Parameters.AddWithValue("@RawMaterialName", rawMaterial.rawMaterialName);
                cmd.Parameters.AddWithValue("@Quantity", rawMaterial.quantity);
                cmd.ExecuteNonQuery(); // Execute the sql command
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
            finally
            {
                Cn.Close();
            }
        }



        // Adds product to database with given name, quality, quantity, and location
        public void AddProduct(Product product)
        {
            try
            {
                // Create a sql command that takes user input -- product name, quality, quantity, location -- and inputs into Products database
                Cn.Open();
                cmd = new SqlCommand("Insert into Products(ProductName, Quality, Quantity, Location) Values(@ProductName, @Quality, @Quantity, @Location);", Cn);
                cmd.Parameters.AddWithValue("@ProductName", product.productName);
                cmd.Parameters.AddWithValue("@Quality", product.quality);
                cmd.Parameters.AddWithValue("@Quantity", product.quantity);
                cmd.Parameters.AddWithValue("@Location", product.location);

                cmd.ExecuteNonQuery(); // Execute the sql command

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
            finally
            {
                Cn.Close();
            }
        }



        public bool CheckMat(string RawMaterialName)
        {
            bool Exists = false;

            // Open connection and execute sql command
            try
            {
                Cn.Open();
                cmd = new SqlCommand("SELECT Count (*) From RawMaterials WHERE RawMaterialName = Trim(@RawMaterialName)", Cn);
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
                Cn.Close();
            }

            return Exists;
        }
    

        public bool CheckProduct(string ProductName)
        {
            bool Exists = false;

            // Open connection and execute sql command
            try
            {
                Cn.Open();
                cmd = new SqlCommand("SELECT Count (*) FROM Products WHERE ProductName = @ProductName", Cn); // Grabs password from associated username in database that matches the username input on the login screen
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
                Cn.Close();
            }
            return Exists;
        }


        public void EditQuant(string RawMaterialName, int Quantity)
        {
            try
            {
                Cn.Open();
                cmd = new SqlCommand("Update RawMaterials Set Quantity = @Quantity Where RawMaterialName = @RawMaterialName", Cn);
                cmd.Parameters.AddWithValue("@RawMaterialName", RawMaterialName);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                cmd.ExecuteNonQuery(); // Execute the sql command
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
            finally
            {
                Cn.Close();
            }
        }

        public void EditProductQuant(string ProductName, int Quantity)
        {
            try
            {
                Cn.Open();
                cmd = new SqlCommand("Update Products Set Quantity = @Quantity Where ProductName = @ProductName", Cn);
                cmd.Parameters.AddWithValue("@ProductName", ProductName);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                cmd.ExecuteNonQuery(); // Execute the sql command
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
            finally
            {
                Cn.Close();
            }
        }


        public void EditLocation(string ProductName, string Location) 
        {
            try
            {
                Cn.Open();
                cmd = new SqlCommand("Update Products Set Location = @Location Where ProductName = @ProductName", Cn);
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
                Cn.Close();
            }
        }

        public void EditQuality(string ProductName, string Quality)
        {
            try
            {
                Cn.Open();
                cmd = new SqlCommand("Update Products Set Quality = @Quality Where ProductName = @ProductName", Cn);
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
                Cn.Close();
            }
        }

        public RawMaterial GetRawMaterial(string rawMaterialName)
        {
            RawMaterial mat = new RawMaterial(rawMaterialName, 0);

            try
            {
                Cn.Open();
                cmd = new SqlCommand("SELECT Quantity FROM RawMaterials WHERE RawMaterialName = " + "'" + rawMaterialName + "'", Cn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int quantity = (int)reader["Quantity"];
                    //mat.rawMaterialName = rawMaterialName;
                    mat.quantity = quantity;
                }
                reader.Close();
            }
            catch (Exception err)
            {
                throw;
            }
            finally
            {
                Cn.Close();
            }
            return mat;
        }

    }

    }
