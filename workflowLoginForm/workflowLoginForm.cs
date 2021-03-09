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

namespace workflowLoginForm
{
    public partial class workflowLoginForm : Form
    {
        // Constructor
        public workflowLoginForm()
        {
            InitializeComponent();
        }

        private String getAuthorizedPassword(string userName)
        {
            // Object variables
            SqlConnection cn = new SqlConnection(); // Establishing sql connection
            SqlCommand cmd = new SqlCommand(); // Creating a sql command object
            SqlDataReader dr; // Sql data reader

            // Error catching
            try
            {
                
                cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ian\Source\Repos\WORK-FLOW\workflowLoginForm\UserLoginData.mdf"; // Connection string
                cmd.Connection = cn;//connects command object to database
                cmd.CommandText = "SELECT userPassword FROM AuthorizedUsers WHERE userName = @username"; //grabs password from associated username in database that matches the username input on the login screen
                cmd.Parameters.AddWithValue("@username", userName);

                //opens database, grabs and returns password
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();

                return dr.GetString(0);
            }
            catch (Exception err) // Handles exception
            {
                //MessageBox.Show(err.Message, "Warning!");

                return null;
            }
            finally
            {
                cn.Close();
            }
        }

        // Event handler for Login button click
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtPassword.Text;
            // Error catching 
            try
            {
                // Password validation
                if (enteredPassword == getAuthorizedPassword(txtUserName.Text)) // Correct password
                {
                    MessageBox.Show("Welcome to the Work Flow", "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Incorrect password
                {
                    MessageBox.Show("Invalid username or password", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    txtUserName.SelectAll();
                }
            }
            catch (Exception err) // Error exception
            {
                MessageBox.Show(err.Message, "Something Broke"); // Show error message
            }
        }

        // Event handler for Clear button click
        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty; // Clear username text
            txtPassword.Text = string.Empty; // Clear password text
        }

        // Event handler for Exit button click
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Quit application
        }

        // Event handler for Register button click
        private void registerBtn_Click(object sender, EventArgs e)
        {
            // Create a new class for user registration with SQL Server
            RegisterForm rform = new RegisterForm(); // Creates instance of Register Form class
            rform.ShowDialog(); // Shows the register form on the screen
        }

    }
}
