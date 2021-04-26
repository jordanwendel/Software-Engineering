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
    public partial class EditUserAdminConfirm : Form
    {
        
        private DatabaseTools dbTools;
        private User user;
        public Boolean check;


        private string password { get; set; }

        public EditUserAdminConfirm(User user)
        {
            InitializeComponent();
            this.password = user.Password;
            dbTools = new DatabaseTools();
            this.user = user;
            check = false;
        }

        public bool isAdmin()
        {
            bool isValid = false;
            string enteredPassword = "";

            enteredPassword = txtPass.Text;
            txtPass.Clear();

            if (this.password.Equals(enteredPassword))
            {
                isValid = true;
            }

            return isValid;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (isAdmin())
            {
                check = true;
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect password. Please try again.");
            }

            txtPass.Text = String.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
