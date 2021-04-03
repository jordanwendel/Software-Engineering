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
        private SqlDataReader reader;
        private SqlCommand cmd;
        //private SqlDataAdapter sqlDa;


        // Variables
        private readonly string connectionString = Properties.Settings.Default.connectionString; // Database connection string stored in Properties -> Settings.settings
        public string dbName { get; set; }
        


        // Constructor with an optional argument to set the name of the database directly from the parameters
        public DatabaseTools(string db = "")
        {
            this.dbName = db; // For storing the optional database name parameter, if applicable

            // Open connection and create a sql command for class use
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
        public void RegisterUser(string username, string password, string job)
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
        public void AddRawMaterial(string rawMaterialName, int quantity)
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
        public void AddProduct(string name, string quality, int quantity, string location)
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

        // Creates a data grid from a specified database
        public void PopulateDataGrid(DataGridView dataGrid)
        {
            string sql = "SELECT * FROM " + dbName; // Default value

            // Only displaying the data that we want from each database
            if (this.dbName.Equals("Products"))
            {
                sql = "SELECT ProductName, Quality, Quantity, Location FROM " + dbName; // Viewing all data from Product database except the ID
            }
            else if (this.dbName.Equals("RawMaterials"))
            {
                sql = "SELECT RawMaterialName, Quantity FROM " + dbName; // Viewing all data from RawMaterials database except the ID
            }
 

            // Error handling
            try
            {
                //SqlConnection connection = new SqlConnection(connectionString);
                cn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
                DataSet ds = new DataSet();

                // Fill data grid on screen with data from given database
                dataAdapter.Fill(ds, dbName);
                dataGrid.DataSource = ds;
                dataGrid.DataMember = dbName;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Issue Creating DataGrid");
            }
            finally
            {
                cn.Close();
            }

            // Formatting the data grid
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGrid.RowsDefaultCellStyle.BackColor = Color.Wheat;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Refreshing the data grid to update inventory
        public void RefreshDataGrid(DataGridView dataGrid)
        {
            dataGrid.Update();
            dataGrid.Refresh();
            PopulateDataGrid(dataGrid);
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

    }

}
