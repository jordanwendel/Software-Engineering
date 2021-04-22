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
        private DatabaseTools dbTools;
        private UserManager userManager;

        // Constructor
        public RegisterForm()
        {
            InitializeComponent();
        }

        // Event handler for Clear button click
        private void clearBtn_Click(object sender, EventArgs e)
        {
            /*/ Clear text fields
            passwordTxt.Text = String.Empty; 
            usernameTxt.Text = String.Empty; 
            boxOccupation.Text = String.Empty;
            confirmpasswordtxt.Text = String.Empty;
            */
        }

        // Event handler for Register button click
        private void registerBtn_Click(object sender, EventArgs e)
        {
            dbTools = new DatabaseTools();
            userManager = new UserManager();


            if (passwordTxt.Text.Equals(confirmpasswordtxt.Text))
            {
                try
                {
                    string message = "Are you sure you want to create a new user with job title " + boxOccupation.Text + "?";
                    string title = "Warning!";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        User newUser = new User(usernameTxt.Text, passwordTxt.Text, boxOccupation.Text);
                        userManager.RegisterUser(newUser); // Register the user in the database
                    }
                    else
                    {
                        return;
                    }   
                   
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Warning!");
                }
                                        
                // Clear values for other users
                usernameTxt.Clear();
                passwordTxt.Clear();
                confirmpasswordtxt.Clear();
                boxOccupation.Text = string.Empty;

                this.Hide();
            }
            else
            {
                MessageBox.Show("Passwords Do Not Match!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear text fields
            passwordTxt.Text = String.Empty;
            usernameTxt.Text = String.Empty;
            boxOccupation.Text = String.Empty;
            confirmpasswordtxt.Text = String.Empty;
        }

    }
}
