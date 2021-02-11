using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workflowLoginForm
{
    public partial class workflowLoginForm : Form
    {
        public workflowLoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string enteredUserName = txtUserName.Text;
            string enteredPassword = txtPassword.Text;

            if (enteredUserName == "admin" && enteredPassword == "admin")
            {
                MessageBox.Show("Welcome to Work Flow!", "Successful Login!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid user name and/or password. Try again!", "Invalid Credentials!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
