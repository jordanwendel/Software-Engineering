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
            // Clear text fields
            passwordTxt.Text = String.Empty; 
            usernameTxt.Text = String.Empty; 
            boxOccupation.Text = String.Empty;
            confirmpasswordtxt.Text = String.Empty;
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
                    // May want to create a new User object here and pass that into RegisterUser instead
                    userManager.RegisterUser(usernameTxt.Text, passwordTxt.Text, boxOccupation.Text); // Register the user in the database
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

    }
}
