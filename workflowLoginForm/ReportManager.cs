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
    public partial class ReportManager : Form
    {
        private RawMaterialsReport RawMaterialsReport;
        private ProductReport ProductReport;
        private ReportGenerator ReportGen;

        public ReportManager()
        {
            InitializeComponent();
            ReportGen = new ReportGenerator();
        }

        private void RawMatbtn_Click(object sender, EventArgs e)
        {
            RawMaterialsReport = new RawMaterialsReport();
            this.Hide();
            RawMaterialsReport.ShowDialog();
            this.Show();
        }

        private void Productbtn_Click(object sender, EventArgs e)
        {
            ProductReport = new ProductReport();
            this.Hide();
            ProductReport.ShowDialog();
            this.Show();
        }

        // Event handler for Generate Raw Material CSV button click
        private void RawMatCSVbtn_Click(object sender, EventArgs e)
        {
            // Save file to chosen directory
            rawMatCsvSave = new SaveFileDialog();
            rawMatCsvSave.FileName = "RawMaterialsReport.csv";
            rawMatCsvSave.DefaultExt = ".csv";
            rawMatCsvSave.Filter = "csv files(*.csv) | *.csv | All files(*.*) | *.*";
            rawMatCsvSave.InitialDirectory = @"C:\";
            rawMatCsvSave.ShowDialog();
            string filePath = rawMatCsvSave.FileName;
            

            try
            {
                //string filePath = rawMatCsvSave.FileName;//@"C:\Users\jwend\source\repos\WORK-FLOW\workflowLoginForm\bin\test2.csv";
                ReportGen.GenerateRawMaterialsReport(filePath);
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
            string fileName;
            productCsvSave = new SaveFileDialog();

            // Switching file name based on which report is needed
            switch (cBoxProductRep.SelectedItem)
            {
                case "In Progress":
                    fileName = "InProgressProductsReport.csv";
                    break;

                case "Qualified":
                    fileName = "QualifiedProductsReport.csv";
                    break;

                case "Defective":
                    fileName = "DefectiveProductsReport.csv";
                    break;

                default:
                    fileName = "AllProductsReport.csv";
                    break;
            }


            // Save file to chosen directory
            productCsvSave.DefaultExt = ".csv";
            productCsvSave.FileName = fileName;
            productCsvSave.Filter = "csv files(*.csv) | *.csv | All files(*.*) | *.*";
            productCsvSave.InitialDirectory = @"C:\";
            productCsvSave.ShowDialog();
            string filePath = productCsvSave.FileName;


            // MAKE SURE C BOX HAS A SELECTION BEFORE BEING ABLE TO PRESS THE BUTTON
            try
            {
                ReportGen.GenerateProductReport(filePath, cBoxProductRep.Text);
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
    }
}
