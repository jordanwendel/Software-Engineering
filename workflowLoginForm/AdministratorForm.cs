using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace workflowLoginForm
{
    public partial class AdministratorForm : Form
    {
        // Class level objects
        private DeliveryManagerForm DeliveryManager;
        private ProductManagerForm ProductManager;
        private ReportManagerForm ReportManager;
        private StockiestForm Stockpage;
        private QualityAnalyzerForm QualityAnalyzer;
        private EditUserInfo EditUserInfo;
        private List<User> users;
        private ReportGenerator ReportGen;
        private User user;

        // Constructor
        public AdministratorForm(User user)
        {
            InitializeComponent();
            users = new List<User>();
            this.user = user;
            ReportGen = new ReportGenerator();
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
            ReportManager = new ReportManagerForm();
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

        private void button1_Click(object sender, EventArgs e)
        {
            EditUserInfo = new EditUserInfo(this.user);
            this.Hide();
            EditUserInfo.ShowDialog();
            this.Show();
        }


        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = ReportGen.OpenReports();
            if (fileName.Any())
            {
                System.Diagnostics.Process.Start(fileName);
            }
        }
    }
}
