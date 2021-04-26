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
        // Class level objects
        public User loggedInUser { get; set; }
        private DeliveryManagerForm DeliveryManager;
        private AdministratorForm Admin;
        private ProductManagerForm ProductManager;
        private ReportManagerForm ReportManager;
        private StockiestForm Stockpage;
        private QualityAnalyzerForm QualityAnalyzer;
        private UserManager userManager;

        // Constructor
        public workflowLoginForm()
        {
            InitializeComponent();
        }
      

        // Event handler for Login button click
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtPassword.Text;
            string enteredUsername = txtUserName.Text;

            loggedInUser = new User(enteredUsername, enteredPassword); // Logging in the current user
            
            // Logging in the current user
            try
            {
                userManager = new UserManager();
                if (userManager.ValidatePassword(enteredUsername, enteredPassword).Equals(true)) // Validating if the user's password matches in the database
                {
                    switch (loggedInUser.Job)
                    {
                        case "Administrator": // Admin log in
                            this.Hide();
                            Admin = new AdministratorForm(loggedInUser);
                            Admin.ShowDialog();
                            txtUserName.Text = string.Empty;
                            txtPassword.Text = string.Empty;
                            this.Show();
                            break;

                        case "Delivery Manager": // Delivery manager log in
                            this.Hide();
                            DeliveryManager = new DeliveryManagerForm();
                            DeliveryManager.ShowDialog();
                            txtUserName.Text = string.Empty;
                            txtPassword.Text = string.Empty;
                            this.Show();
                            break;

                        case "Product Manager": // Product manager log in
                            this.Hide();
                            ProductManager = new ProductManagerForm();
                            ProductManager.ShowDialog();
                            txtUserName.Text = string.Empty;
                            txtPassword.Text = string.Empty;
                            this.Show();
                            break;

                        case "Quality Analyzer": // Quality analyzer log in
                            this.Hide();
                            QualityAnalyzer = new QualityAnalyzerForm();
                            QualityAnalyzer.ShowDialog();
                            txtUserName.Text = string.Empty;
                            txtPassword.Text = string.Empty;
                            this.Show();
                            break;

                        case "Report Manager": // Report manager log in
                            this.Hide();
                            ReportManager = new ReportManagerForm();
                            ReportManager.ShowDialog();
                            txtUserName.Text = string.Empty;
                            txtPassword.Text = string.Empty;
                            this.Show();
                            break;

                        case "Stockiest": // Stockiest log in
                            this.Hide();
                            Stockpage = new StockiestForm();
                            Stockpage.ShowDialog();
                            txtUserName.Text = string.Empty;
                            txtPassword.Text = string.Empty;
                            this.Show();
                            break;
                    }
                }
                else // Password is not correct
                {
                    MessageBox.Show("Invalid username or password", "Warning!");
                    txtUserName.Focus();
                    txtUserName.SelectAll();
                }
            }
            catch (Exception) // Username is not correct
            {
                MessageBox.Show("Invalid username or password", "Warning!"); // Show error message
                txtUserName.Clear();
                txtPassword.Clear();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
