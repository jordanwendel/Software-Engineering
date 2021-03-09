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
    public partial class RegisterForm : Form
    {

        // Constructor
        public RegisterForm()
        {
            InitializeComponent();
        }

        // Event handler for Clear button click
        private void clearBtn_Click(object sender, EventArgs e)
        {
            passwordTxt.Text = String.Empty; // Empty password text
            usernameTxt.Text = String.Empty; // Empty username text
            jobTxt.Text = String.Empty; // Empty user job text
        }

        // Event handler for Register button click
        private void registerBtn_Click(object sender, EventArgs e)
        {
            // FIX PATH
            string con = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\jwend\source\Repo\workflowLoginForm\UserLoginData.mdf"; // Connection string
            SqlConnection connectionOne = new SqlConnection(con); // Creating an instance of the database

            SqlCommand one = new SqlCommand("Insert into AuthorizedUsers(username, userpassword, userjob) VALUES (@username, @password, @job);", connectionOne); // Create a SQL command that takes user input -- username, password, and job -- and inputs into the database
            one.Parameters.AddWithValue("@username", usernameTxt.Text); // Database uses the username text and puts it into the username column
            one.Parameters.AddWithValue("@password", passwordTxt.Text); // Database uses the password text and puts it into the userpassword column
            one.Parameters.AddWithValue("@job", jobTxt.Text); // Database uses the job text and puts it into the userjob column

            connectionOne.Open(); // Open the sql connection
            one.ExecuteNonQuery(); // Execute the sql command
            connectionOne.Close(); // Close the sql connection
            MessageBox.Show("Sucessfully Registered!");

            // Clear values for other users
            usernameTxt.Clear();
            passwordTxt.Clear();
            jobTxt.Clear();
        }

  

    }
}
