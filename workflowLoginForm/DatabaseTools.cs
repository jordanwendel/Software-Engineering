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
    public partial class DatabaseTools
    {
        // Class level objects
        public SqlConnection cn { get; set; }
        public SqlDataReader reader;
        public SqlCommand cmd;
        //private SqlDataAdapter sqlDa;


        // Variables
        private readonly string connectionString = Properties.Settings.Default.connectionString; // Database connection string stored in Properties -> Settings.settings
        public string dbName { get; set; }
        


        // Constructor with an optional argument to set the name of the database directly from the parameters
        // This optional argument will be used to switch between databases on a datagrid
        public DatabaseTools()//string dbName = "")
        {
            this.dbName = dbName; // For storing the optional database name parameter

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


        // Validates user from the database upon login
        public bool ValidatePassword(string username, string enteredPassword)
        {
            bool isAuthorized = false;
           
            // Open connection and execute sql command
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT userpassword FROM AuthorizedUsers WHERE username = @username", cn); // Grabs password from associated username in database that matches the username input on the login screen
                cmd.Parameters.AddWithValue("@username", username);

                // Opens database, grabs and returns password
                reader = cmd.ExecuteReader();
                reader.Read();

                if (enteredPassword.Equals(reader.GetString(0))) // Checks if entered password matches the one grabbed from database
                {
                    isAuthorized = true;
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

            return isAuthorized;
        }



        // Gets user job from database with given username
        public string GetJob(string username)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT userjob FROM AuthorizedUsers WHERE userName = @username", cn);
                cmd.Parameters.AddWithValue("@username", username);

                // Grabs and returns job from database
                reader = cmd.ExecuteReader();
                reader.Read();

                return reader.GetString(0);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
                return null;
            }
            finally
            {
                cn.Close();
            }
        }



        // Inputs user into database with given username, password, and job
        public void RegisterUser(string username, string password, string job) // May be better to pass in a User object instead
        {
            try
            {
                // Create a SQL command that takes user input -- username, password, and job -- and inputs into the database
                cn.Open();
                cmd = new SqlCommand("Insert into AuthorizedUsers(username, userpassword, userjob) VALUES (@username, @password, @job);", cn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@job", job);

                cmd.ExecuteNonQuery(); // Execute the sql command
                MessageBox.Show("Sucessfully Registered!");

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



        // Adds raw material to database with given name and quantity
        public void AddRawMaterial(string rawMaterialName, int quantity) // May be better to use a RawMaterial object instead
                                   //List<RawMaterial> rawMaterials)
        {
            try
            {
                /** For later use
                foreach (var mat in rawMaterials)
                {
                    one.Parameters.AddWithValue("@RawMaterialName", mat.rawMaterialName);
                    one.Parameters.AddWithValue("@Quantity", mat.quantity);
                }
                */

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



        // Returns a list of User objects. Pulls the names of users in a given job from the AuthorizedUsers database for each User object
        public List<User> createUserList(string job)
        {
            // Create list of User objects
            List<User> users;
            users = new List<User>();

            try
            {
                User tempUser;

                // Create the sql command
                cn.Open();
                cmd = new SqlCommand("SELECT username, userpassword FROM AuthorizedUsers WHERE userjob = " + "'" + job + "'", cn);
                reader = cmd.ExecuteReader();

                // Get the name of the user and add it to the list of User objects
                while (reader.Read())
                {
                    string name = (string)reader["username"];
                    tempUser = new User(name);
                    users.Add(tempUser);
                }

                reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
            finally
            {
                cn.Close();
            }

            return users;
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
                cmd = new SqlCommand("Update RawMaterials Set Quant=@Quantity Where RawMaterialName=@RawMaterialName", cn);
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
                cmd = new SqlCommand("Update Products Set Location=@Location Where ProductName=@ProductName", cn);
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
                cmd = new SqlCommand("Update Products Set Quality=@Quality Where ProductName=@ProductName", cn);
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
