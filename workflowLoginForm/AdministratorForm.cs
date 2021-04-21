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
    public partial class AdministratorForm : Form
    {
        // Class level objects
        private DeliveryManagerForm DeliveryManager;
        private ProductManagerForm ProductManager;
        private ReportManager ReportManager;
        private StockiestForm Stockpage;
        private QualityAnalyzerForm QualityAnalyzer;
        private List<User> users;

        // Constructor
        public AdministratorForm()
        {
            InitializeComponent();
            users = new List<User>();
        }

        // Event handler for Logout button click
        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for Stockest button click
        private void stockiestBtn_Click(object sender, EventArgs e)
        {
            Stockpage = new StockiestForm();
            this.Hide();
            Stockpage.ShowDialog();
            this.Show();
        }

        // Event handler for Product Manager button click 
        private void prodManagerBtn_Click(object sender, EventArgs e)
        {
            ProductManager = new ProductManagerForm();
            this.Hide();
            ProductManager.ShowDialog();
            this.Show();
        }

        // Event handler for Delivery Manager button click
        private void delManagerBtn_Click(object sender, EventArgs e)
        {
            DeliveryManager = new DeliveryManagerForm();
            this.Hide();
            DeliveryManager.ShowDialog();
            this.Show();
        }

        // Event handler for Report Manager button click
        private void repManagerBtn_Click(object sender, EventArgs e)
        {
            ReportManager = new ReportManager();
            this.Hide();
            ReportManager.ShowDialog();
            this.Show();
        }

        // Event handler for Quality Analyzer button click
        private void qualAnalyzerBtn_Click(object sender, EventArgs e)
        {
            QualityAnalyzer = new QualityAnalyzerForm();
            this.Hide();
            QualityAnalyzer.ShowDialog();
            this.Show();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
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

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm rform = new RegisterForm(); // Creates instance of Register Form class
            rform.ShowDialog(); // Shows the register form on the screen
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
