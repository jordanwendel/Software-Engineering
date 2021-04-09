using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace workflowLoginForm
{
    public class UserManager
    {
        // Class level objects
        private SqlConnection cn { get; set; }
        private SqlCommand cmd;
        private SqlDataReader reader;
        private User user;
        

        // Variables
        private readonly string connectionString = Properties.Settings.Default.connectionString; // Database connection string stored in Properties -> Settings.settings
        
        public UserManager()
        {
            try
            {
                cn = new SqlConnection(); // Establishing sql connection
                cn.ConnectionString = connectionString;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Issue connecting to database");
            }
        }


        // Inputs user into database with given username, password, and job
        public void RegisterUser(User user) // May be better to pass in a User object instead
        {
            try
            {
                // Create a SQL command that takes user input -- username, password, and job -- and inputs into the database
                cn.Open();
                cmd = new SqlCommand("Insert into AuthorizedUsers(username, userpassword, userjob) VALUES (@username, @password, @job);", cn);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@job", user.Job);

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


        // Returns a list of User objects. Pulls the names of users in a given job from the AuthorizedUsers database for each User object
        public List<User> CreateUserList(string job)
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
