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
        private DeliveryManagerForm DeliveryManager;
        private ProductManagerForm ProductManager;
        private ReportManagerForm ReportManager;
        private StockiestForm Stockpage;
        private QualityAnalyzerForm QualityAnalyzer;

        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stockiestBtn_Click(object sender, EventArgs e)
        {
            Stockpage = new StockiestForm();
            this.Hide();
            Stockpage.ShowDialog();
            this.Show();
        }

        private void prodManagerBtn_Click(object sender, EventArgs e)
        {
            ProductManager = new ProductManagerForm();
            this.Hide();
            ProductManager.ShowDialog();
            this.Show();
        }

        private void delManagerBtn_Click(object sender, EventArgs e)
        {
            DeliveryManager = new DeliveryManagerForm();
            this.Hide();
            DeliveryManager.ShowDialog();
            this.Show();
        }

        private void repManagerBtn_Click(object sender, EventArgs e)
        {
            ReportManager = new ReportManagerForm();
            this.Hide();
            ReportManager.ShowDialog();
            this.Show();
        }

        private void qualAnalyzerBtn_Click(object sender, EventArgs e)
        {
            QualityAnalyzer = new QualityAnalyzerForm();
            this.Hide();
            QualityAnalyzer.ShowDialog();
            this.Show();
        }
    }
}
