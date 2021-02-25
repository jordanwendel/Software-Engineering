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
    public partial class RegisterForm : Form
    {
        //Variables
        int id;
        string username, password, job;

        //Constructor
        public RegisterForm()
        {
            InitializeComponent();
        }

        //Methods
        private void clearBtn_Click(object sender, EventArgs e)
        {
            passwordTxt.Text = String.Empty;
            usernameTxt.Text = String.Empty;
            jobTxt.Text = String.Empty;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            username = usernameTxt.Text;
            password = passwordTxt.Text;
            job = jobTxt.Text;
        }

  

    }
}
