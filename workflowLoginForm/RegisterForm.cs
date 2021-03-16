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
            // Clear text fields
            passwordTxt.Text = String.Empty; 
            usernameTxt.Text = String.Empty; 
            boxOccupation.Text = String.Empty; 
        }

        // Event handler for Register button click
        private void registerBtn_Click(object sender, EventArgs e)
        {
            User user = new User(usernameTxt.Text, passwordTxt.Text, boxOccupation.Text); // Create a new user with entered values

            // FIX PATH
            if(user.getPassword() == confirmpasswordtxt.Text)
            {
                    //C: \Users\jwend\source\Repo\workflowLoginForm\UserLoginData.mdf"
                    string con = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C: \Users\jwend\source\Repo\workflowLoginForm\UserLoginData.mdf"; // Connection string
                    SqlConnection connectionOne = new SqlConnection(con); // Creating an instance of the database

                    // Create a SQL command that takes user input -- username, password, and job -- and inputs into the database
                    SqlCommand one = new SqlCommand("Insert into AuthorizedUsers(username, userpassword, userjob) VALUES (@username, @password, @job);", connectionOne);
                    one.Parameters.AddWithValue("@username", user.getUsername()); 
                    one.Parameters.AddWithValue("@password", user.getPassword()); 
                    one.Parameters.AddWithValue("@job", user.getJob()); 

                    connectionOne.Open(); // Open the sql connection
                    one.ExecuteNonQuery(); // Execute the sql command
                    connectionOne.Close(); // Close the sql connection
                    MessageBox.Show("Sucessfully Registered!");

                    // Clear values for other users
                    usernameTxt.Clear();
                    passwordTxt.Clear();
                    boxOccupation.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Passwords do not match", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void passwordLbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
