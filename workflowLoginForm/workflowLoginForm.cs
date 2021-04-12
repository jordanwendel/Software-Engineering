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
        private User loggedInUser;
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

            try
            {
                userManager = new UserManager();
                if (userManager.ValidatePassword(enteredUsername, enteredPassword).Equals(true)) // Validating if the user's password matches in the database
                {
                    //MessageBox.Show("Welcome to the Work Flow", "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // May be better with an enum
                    if (loggedInUser.Job.Equals("Administrator")) // Admin page
                    {
                        this.Hide();
                        Admin = new AdministratorForm();
                        Admin.ShowDialog();
                        txtUserName.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                    else if (loggedInUser.Job.Equals("Delivery Manager")) // Delivery manager page
                    {
                        this.Hide();
                        DeliveryManager = new DeliveryManagerForm();
                        DeliveryManager.ShowDialog();
                        txtUserName.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                    else if (loggedInUser.Job.Equals("Product Manager")) // Product manager page
                    {
                        this.Hide();
                        ProductManager = new ProductManagerForm();
                        ProductManager.ShowDialog();
                        txtUserName.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                    else if (loggedInUser.Job.Equals("Quality Analyzer")) // Quality analyzer page
                    {
                        this.Hide();
                        QualityAnalyzer = new QualityAnalyzerForm();
                        QualityAnalyzer.ShowDialog();
                        txtUserName.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                    else if (loggedInUser.Job.Equals("Report Manager")) // Report manager page
                    {
                        this.Hide();
                        ReportManager = new ReportManagerForm();
                        ReportManager.ShowDialog();
                        txtUserName.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                    else if (loggedInUser.Job.Equals("Stockiest")) // Stockiest page
                    {
                        this.Hide();
                        Stockpage = new StockiestForm();
                        Stockpage.ShowDialog();
                        txtUserName.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                }
                else
                {   // Incorrect password
                    MessageBox.Show("Invalid username or password", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    txtUserName.SelectAll();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something Broke"); // Show error message
            }
            

        }


        // Event handler for Clear button click
        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clear text fields
            txtUserName.Text = string.Empty; 
            txtPassword.Text = string.Empty;
        }

        // Event handler for Exit button click
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Quit application
        }

    }
}
