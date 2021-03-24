using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace workflowLoginForm
{
    public partial class DatabaseTools
    {
        // Class level objects
        private SqlConnection cn;
        private SqlDataReader dr;
        private SqlCommand cmd;
        private SqlDataAdapter sqlDa;
        private User user;

        // Variables
        private readonly string connectionString = Properties.Settings.Default.connectionString; // Database connection string stored in Properties -> Settings.settings

        // Empty constructor
        public DatabaseTools()
        {
            // Open connection and create a sql command for class use
            try
            {
                cn = new SqlConnection(); // Establishing sql connection
                cn.ConnectionString = connectionString;
                cn.Open(); // Opening connection with specified path
                cmd = new SqlCommand();
                cmd.Connection = cn;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }

        // Methods


        // For closing connection manually
        public void CloseConnection() 
        {
            cn.Close();
        }


        // Validates user from the database upon login
        public bool ValidatePassword(string username, string enteredPassword)
        {
            bool isAuthorized = false;
           
            try
            {
                cmd.CommandText = "SELECT userpassword FROM AuthorizedUsers WHERE username = @username"; // Grabs password from associated username in database that matches the username input on the login screen
                cmd.Parameters.AddWithValue("@username", username);

                // Opens database, grabs and returns password
                dr = cmd.ExecuteReader();
                dr.Read();

                if (enteredPassword.Equals(dr.GetString(0))) // Checks if entered password matches the one grabbed from database
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
                cmd.CommandText = "SELECT userjob FROM AuthorizedUsers WHERE userName = @username";
                cmd.Parameters.AddWithValue("@username", username);

                // Grabs and returns job from database
                dr = cmd.ExecuteReader();
                dr.Read();

                return dr.GetString(0);
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
        public void RegisterUser(string username, string password, string job)
        {
            try
            {
                SqlConnection connectionOne = new SqlConnection(connectionString); // Creating an instance of the database

                // Create a SQL command that takes user input -- username, password, and job -- and inputs into the database
                SqlCommand one = new SqlCommand("Insert into AuthorizedUsers(username, userpassword, userjob) VALUES (@username, @password, @job);", connectionOne);
                one.Parameters.AddWithValue("@username", username);
                one.Parameters.AddWithValue("@password", password);
                one.Parameters.AddWithValue("@job", job);

                connectionOne.Open(); // Open the sql connection
                one.ExecuteNonQuery(); // Execute the sql command
                connectionOne.Close(); // Close the sql connection
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
        public void AddRawMaterial(string rawMaterialName, int quantity)
        {
            try
            {
                // Create a new sql connection
                SqlConnection connectionOne = new SqlConnection(connectionString);

                // Create a SQL command that takes user input -- raw material name, quantity -- and inputs into RawMaterials database
                SqlCommand one = new SqlCommand("Insert into RawMaterials(RawMaterialName, Quantity) Values(@RawMaterialName,  @Quantity);", connectionOne);
                one.Parameters.AddWithValue("@RawMaterialName", rawMaterialName);
                one.Parameters.AddWithValue("@Quantity", quantity);

                connectionOne.Open(); // Open the sql connection
                one.ExecuteNonQuery(); // Execute the sql command
                connectionOne.Close(); // Close the sql connection
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
        public void AddProduct(string name, string quality, int quantity, string location)
        {
            try
            {
                // Create a new sql connection 
                SqlConnection connectionOne = new SqlConnection(connectionString);

                // Create a sql command that takes user input -- product name, quality, quantity, location -- and inputs into Products database
                SqlCommand one = new SqlCommand("Insert into Products(ProductName, Quality, Quantity, Location) Values(@ProductName, @Quality, @Quantity, @Location);", connectionOne);
                one.Parameters.AddWithValue("@ProductName", name);
                one.Parameters.AddWithValue("@Quality", quality);
                one.Parameters.AddWithValue("@Quantity", quantity);
                one.Parameters.AddWithValue("@Location", location);

                connectionOne.Open(); // Open connection
                one.ExecuteNonQuery(); // Execute the sql command
                connectionOne.Close(); // Close the sql connection
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

        // Creates a data grid from a specified database
        public void PopulateDataGrid(DataGridView dataGrid, string databaseName) 
        {
            string sql = "SELECT * FROM " + databaseName;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataAdapter.Fill(ds, databaseName);
            connection.Close();
            dataGrid.DataSource = ds;
            dataGrid.DataMember = databaseName;
        }

        // Refreshing the data grid to update inventory
        public void RefreshDataGrid(DataGridView dataGrid, string databaseName)
        {
            dataGrid.Update();
            dataGrid.Refresh();
            PopulateDataGrid(dataGrid, databaseName);
        }

    }

}
