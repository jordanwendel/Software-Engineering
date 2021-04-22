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
        private string password { get; set; }

        public EditUserAdminConfirm(User user)
        {
            InitializeComponent();
            this.password = user.Password;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtPass.Text;
            if (this.password.Equals(enteredPassword))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid password. Please try again");
            }

        }
    }
}
