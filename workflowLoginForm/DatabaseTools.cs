using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace workflowLoginForm
{
    public partial class DatabaseTools
    {
        private SqlConnection cn;
        private SqlDataReader dr;
        private SqlCommand cmd;

        // Variables
        private readonly string connectionString = Properties.Settings.Default.connectionString;

        // Empty constructor
        public DatabaseTools()
        {
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
        public bool ValidatePassword(string username, string enteredPassword)
        {
            bool isAuthorized = false;
           
            try
            {
                cmd.CommandText = "SELECT userpassword FROM AuthorizedUsers WHERE username = @username"; // Grabs password from associated username in database that matches the username input on the login screen
                cmd.Parameters.AddWithValue("@username", username);

                //opens database, grabs and returns password
                dr = cmd.ExecuteReader();
                dr.Read();

                if (enteredPassword.Equals(dr.GetString(0)))
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


        public void CloseConnection()
        {
            cn.Close();
        }
       
           
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
    }

}
