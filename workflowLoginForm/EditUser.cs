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
    public partial class EditUserInfo : Form
    {
        private List<User> users;
        public EditUserInfo()
        {
            InitializeComponent();
            users = new List<User>();

        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();

            // Show Stockiests
            users = userManager.CreateUserList("Stockiest");
            stockiestNames.Items.AddRange(users.ToArray());

            // Show Product Managers
            users = userManager.CreateUserList("Product Manager");
            productManagerNames.Items.AddRange(users.ToArray());

            // Show Delivery Managers
            users = userManager.CreateUserList("Delivery Manager");
            deliveryManagerNames.Items.AddRange(users.ToArray());

            // Show Report Managers
            users = userManager.CreateUserList("Report Manager");
            reportManagerNames.Items.AddRange(users.ToArray());

            // Show Quality Analyzers
            users = userManager.CreateUserList("Quality Analyzer");
            qualityAnalyzerNames.Items.AddRange(users.ToArray());

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
