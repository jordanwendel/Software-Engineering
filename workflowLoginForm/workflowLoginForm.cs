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
        private User loggedInUser;
        private DeliveryManagerForm DeliveryManager;
        private AdministratorForm Admin;
        private ProductManagerForm ProductManager;
        private ReportManagerForm ReportManager;
        private StockiestForm Stockpage;
        private QualityAnalyzerForm QualityAnalyzer;
        private DatabaseTools DbTools;

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
                DbTools = new DatabaseTools();
                if (DbTools.ValidatePassword(enteredUsername, enteredPassword).Equals(true))
                {
                    MessageBox.Show("Welcome to the Work Flow", "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // May be better with an enum
                    if (loggedInUser.Job.Equals("Administrator"))
                    {
                        this.Hide();
                        Admin = new AdministratorForm();
                        Admin.ShowDialog();
                        txtUserName.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                    else if (loggedInUser.Job.Equals("Delivery Manager"))
                    {
                        this.Hide();
                        DeliveryManager = new DeliveryManagerForm();
                        DeliveryManager.ShowDialog();
                        txtUserName.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                    else if (loggedInUser.Job.Equals("Product Manager"))
                    {
                        this.Hide(); 
                        ProductManager = new ProductManagerForm();
                        ProductManager.ShowDialog();
                        txtUserName.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                    else if (loggedInUser.Job.Equals("Quality Analyzer"))
                    {
                        this.Hide();
                        QualityAnalyzer = new QualityAnalyzerForm();
                        QualityAnalyzer.ShowDialog();
                        txtUserName.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                    else if (loggedInUser.Job.Equals("Report Manager"))
                    {
                        this.Hide();
                        ReportManager = new ReportManagerForm();
                        ReportManager.ShowDialog();
                        txtUserName.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                    else if (loggedInUser.Job.Equals("Stockiest"))
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
            txtUserName.Text = string.Empty; // Clear username text
            txtPassword.Text = string.Empty; // Clear password text
        }

        // Event handler for Exit button click
        private void exitBtn_Click(object sender, EventArgs e)
        {
            DbTools.CloseConnection(); // Close database connection
            Application.Exit(); // Quit application
        }

        // Event handler for Register button click
        private void registerBtn_Click(object sender, EventArgs e)
        {
            // Create a new class for user registration with SQL Server
            RegisterForm rform = new RegisterForm(); // Creates instance of Register Form class
            rform.ShowDialog(); // Shows the register form on the screen
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void workflowLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
