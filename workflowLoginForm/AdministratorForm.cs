﻿using System;
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
        private ReportManagerForm ReportManager;
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

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            DatabaseTools dbTools = new DatabaseTools();

            // Show Stockiests
            users = dbTools.createUserList("Stockiest");
            stockiestNames.Items.AddRange(users.ToArray());

            // Show Product Managers
            users = dbTools.createUserList("Product Manager");
            productManagerNames.Items.AddRange(users.ToArray());

            // Show Delivery Managers
            users = dbTools.createUserList("Delivery Manager");
            deliveryManagerNames.Items.AddRange(users.ToArray());

            // Show Report Managers
            users = dbTools.createUserList("Report Manager");
            reportManagerNames.Items.AddRange(users.ToArray());

            // Show Quality Analyzers
            users = dbTools.createUserList("Quality Analyzer");
            qualityAnalyzerNames.Items.AddRange(users.ToArray());

            dbTools.CloseConnection();


        }
    }
}
