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
using AdministratorScreen;
using StockiestScreen;
using ProductManager;
using QualityAnalyzer;
using DeliveryManager;
using ReportManagerPage;

namespace workflowLoginForm
{
    public partial class workflowLoginForm : Form
    {
        User user;
        DeliveryManagerForm delManager;
        AdministratorForm Admin;
        ProductManagerForm prodMan;
        ReportManagerForm Reppage;

        // Constructor
        public workflowLoginForm()
        {
            InitializeComponent();
        }

        private String getAuthorizedPassword(string userName)
        {
            // Object variables
            SqlConnection cn = new SqlConnection(); // Establishing sql connection
            SqlCommand cmd = new SqlCommand(); // Creating a sql command object
            SqlDataReader dr; // Sql data reader

            // Error catching
            try
            {
                
                cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ian\Source\Repos\WORK-FLOW\workflowLoginForm\UserLoginData.mdf"; // Connection string
                cmd.Connection = cn;//connects command object to database
                cmd.CommandText = "SELECT userPassword FROM AuthorizedUsers WHERE userName = @username"; //grabs password from associated username in database that matches the username input on the login screen
                cmd.Parameters.AddWithValue("@username", userName);

                //opens database, grabs and returns password
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();

                return dr.GetString(0);
            }
            catch (Exception err) // Handles exception
            {
                //MessageBox.Show(err.Message, "Warning!");

                return null;
            }
            finally
            {
                cn.Close();
            }
        }

        private String getAuthorizedjob(string userName)
        {
            // Object variables
            SqlConnection cn = new SqlConnection(); // Establishing sql connection
            SqlCommand cmd = new SqlCommand(); // Creating a sql command object
            SqlDataReader dr; // Sql data reader

            // Error catching
            try
            {

                cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ian\Source\Repos\WORK-FLOW\workflowLoginForm\UserLoginData.mdf"; // Connection string
                cmd.Connection = cn;//connects command object to database
                cmd.CommandText = "SELECT userjob FROM AuthorizedUsers WHERE userName = @username"; //grabs j from associated username in database that matches the username input on the login screen
                cmd.Parameters.AddWithValue("@username", userName);

                //opens database, grabs and returns password
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();

                return dr.GetString(0);
            }
            catch (Exception err) // Handles exception
            {
                //MessageBox.Show(err.Message, "Warning!");

                return null;
            }
            finally
            {
                cn.Close();
            }
        }

        // Event handler for Login button click
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtPassword.Text;
            // Error catching 
            try
            {
                // Password validation
                if (enteredPassword == getAuthorizedPassword(txtUserName.Text)) // Correct password
                {
                    MessageBox.Show("Welcome to the Work Flow", "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if(getAuthorizedjob(txtUserName.Text)=="Administrator")
                    {
                        this.Hide(); //close current display
                        Admin = new AdministratorForm();
                        Admin.ShowDialog();//open new display
                        txtUserName.Text = string.Empty; // Clear username text
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                    else if (getAuthorizedjob(txtUserName.Text) == "Stockiest")
                    {
                        this.Hide(); //close current display
                        Stock Stockpage = new Stock();
                        Stockpage.ShowDialog();//open new display
                        txtUserName.Text = string.Empty; // Clear username text
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                    else if (getAuthorizedjob(txtUserName.Text) == "Product Manager")
                    {
                        this.Hide(); //close current display
                        prodMan = new ProductManagerForm();
                        prodMan.ShowDialog();//open new display
                        txtUserName.Text = string.Empty; // Clear username text
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                    else if (getAuthorizedjob(txtUserName.Text) == "Quality Analyzer")
                    {
                        this.Hide(); //close current display
                        QualAnalyzer Qualpage = new QualAnalyzer();
                        Qualpage.ShowDialog();//open new display
                        txtUserName.Text = string.Empty; // Clear username text
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                    else if (getAuthorizedjob(txtUserName.Text) == "Delivery Manager")
                    {
                        this.Hide(); //close current display
                        delManager = new DeliveryManager();
                        delManager.ShowDialog();//open new display
                        txtUserName.Text = string.Empty; // Clear username text
                        txtPassword.Text = string.Empty;
                        this.Show();
                        
                    }
                    else if (getAuthorizedjob(txtUserName.Text) == "Report Manager")
                    {
                        this.Hide(); //close current display
                        Reppage = new ReportManager();
                        Reppage.ShowDialog();//open new display
                        txtUserName.Text = string.Empty; // Clear username text
                        txtPassword.Text = string.Empty;
                        this.Show();
                    }
                }
                else // Incorrect password
                {
                    MessageBox.Show("Invalid username or password", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    txtUserName.SelectAll();
                }
            }
            catch (Exception err) // Error exception
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
    }
}
