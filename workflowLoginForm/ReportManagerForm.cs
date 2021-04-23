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
    public partial class ReportManagerForm : Form
    {
        private RawMaterialsReport RawMaterialsReport;
        private ProductReport ProductReport;
        private ReportGenerator ReportGen;

        public string workingDirectory { get; set; }
        public string projectDirectory { get; set; }

        public ReportManagerForm()
        {
            InitializeComponent();
            ReportGen = new ReportGenerator();
        }


        private void RawMatbtn_Click(object sender, EventArgs e)
        {
            csvStatusLbl.Text = String.Empty; // Clearing status field text
            RawMaterialsReport = new RawMaterialsReport();
            this.Hide();
            RawMaterialsReport.ShowDialog();
            this.Show();
        }

        private void Productbtn_Click(object sender, EventArgs e)
        {
            csvStatusLbl.Text = String.Empty;
            ProductReport = new ProductReport();
            this.Hide();
            ProductReport.ShowDialog();
            this.Show();
        }

        // Event handler for Generate Raw Material CSV button click
        private void RawMatCSVbtn_Click(object sender, EventArgs e)
        {
            csvStatusLbl.Text = String.Empty;

            try
            {
                ReportGen.GenerateRawMaterialsReport(ReportGen.SaveReport("RawMaterials")); // Returns file name to save 
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Issue writing to CSV");
            }

            csvStatusLbl.Text = "Successfully wrote to CSV!";
            
        }


        // Event handler for Generate Product CSV button click
        private void prodCsvBtn_Click(object sender, EventArgs e)
        {
            csvStatusLbl.Text = String.Empty;
            
            // Getting the prefix for the file name
            string prefix;
            switch (cBoxProductRep.SelectedItem) // Prefix changes based on what product report the user would like to view
            {
                case "In Progress":
                    prefix = "InProgressProductsReport_";
                    break;

                case "Qualified":
                    prefix = "QualifiedProductsReport_";
                    break;

                case "Defective":
                    prefix = "DefectiveProductsReport_";
                    break;

                default:
                    prefix = "AllProductsReport_";
                    break;
            }

           
            string fileName = ReportGen.SaveReport("Products", prefix);

            try
            {
                ReportGen.GenerateProductReport(fileName, cBoxProductRep.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Issue writing to CSV");
            }

            csvStatusLbl.Text = "Successfully wrote to CSV!";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = ReportGen.OpenReports();
            if (fileName.Any())
            {
                System.Diagnostics.Process.Start(fileName);
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            csvStatusLbl.Text = String.Empty;
        }

        private void cBoxProductRep_SelectedIndexChanged(object sender, EventArgs e)
        {
            csvStatusLbl.Text = String.Empty;
        }

    }
}
