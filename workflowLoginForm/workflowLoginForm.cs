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
using ReportManager;

namespace workflowLoginForm
{
    public partial class workflowLoginForm : Form
    {
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
                        System.Threading.Thread display = new System.Threading.Thread(new System.Threading.ThreadStart(OpenAdminPage));//create new display thing called dispaly
                        this.Close(); //close current display
                        display.Start();//open new display
                    }
                    else if (getAuthorizedjob(txtUserName.Text) == "Stockiest")
                    {
                        System.Threading.Thread display = new System.Threading.Thread(new System.Threading.ThreadStart(OpenStockiestPage));//create new display thing called dispaly
                        this.Close(); //close current display
                        display.Start();//open new display
                    }
                    else if (getAuthorizedjob(txtUserName.Text) == "Product Manager")
                    {
                        System.Threading.Thread display = new System.Threading.Thread(new System.Threading.ThreadStart(OpenProductManagerPage));//create new display thing called dispaly
                        this.Close(); //close current display
                        display.Start();//open new display
                    }
                    else if (getAuthorizedjob(txtUserName.Text) == "Quality Analyzer")
                    {
                        System.Threading.Thread display = new System.Threading.Thread(new System.Threading.ThreadStart(OpenQualityAnalyzerPage));//create new display thing called dispaly
                        this.Close(); //close current display
                        display.Start();//open new display
                    }
                    else if (getAuthorizedjob(txtUserName.Text) == "Delivery Manager")
                    {
                        System.Threading.Thread display = new System.Threading.Thread(new System.Threading.ThreadStart(OpenDeliveryManagerPage));//create new display thing called dispaly
                        this.Close(); //close current display
                        display.Start();//open new display
                    }
                    else if (getAuthorizedjob(txtUserName.Text) == "Report Manager")
                    {
                        System.Threading.Thread display = new System.Threading.Thread(new System.Threading.ThreadStart(OpenReportManagerPage));//create new display thing called dispaly
                        this.Close(); //close current display
                        display.Start();//open new display
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
        //open new page (currenlty only linked to administrator page)
        public static void OpenAdminPage()
        {
                Application.Run(new Administrator());
        }
        public static void OpenStockiestPage()
        {
            Application.Run(new Stock());

        }
        public static void OpenProductManagerPage()
        {
            Application.Run(new ProdMan());
        }
        public static void OpenQualityAnalyzerPage()
        {
            Application.Run(new QualAnalyzer());
        }
        public static void OpenDeliveryManagerPage()
        {
            Application.Run(new DelManager());
        }
        public static void OpenReportManagerPage()
        {
            //Application.Run(new RepManager());
        }
    }
}
