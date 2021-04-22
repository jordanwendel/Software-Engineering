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
            SaveFileDialog saveFile = new SaveFileDialog();
            DateTime now = DateTime.Now;
            String date = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", now);
            
            
            saveFile.FileName = "RawMaterialsReport_" + date;
            saveFile.DefaultExt = ".csv";
            saveFile.Filter = "csv files(*.csv) | *.csv | All files(*.*) | *.*";
            //saveFile.InitialDirectory = @"C:\";
            saveFile.ShowDialog();

            

            string filePath = saveFile.FileName;
            

            try
            {
                //string filePath = rawMatCsvSave.FileName;//@"C:\Users\jwend\source\repos\WORK-FLOW\workflowLoginForm\bin\test2.csv";
                ReportGen.GenerateRawMaterialsReport(filePath);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Issue writing to CSV");
            }

            //if (rawMatCsvSave)
            //{
                csvStatusLbl.Text = "Successfully wrote to CSV!";
            //}
            
        }

        // Event handler for Generate Product CSV button click
        private void prodCsvBtn_Click(object sender, EventArgs e)
        {
            string fileName;
            productCsvSave = new SaveFileDialog();
            DateTime now = DateTime.Now;
            String date = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", now);

            // Switching file name based on which report is needed
            switch (cBoxProductRep.SelectedItem)
            {
                case "In Progress":
                    fileName = "InProgressProductsReport_" + date;
                    break;

                case "Qualified":
                    fileName = "QualifiedProductsReport_" + date;
                    break;

                case "Defective":
                    fileName = "DefectiveProductsReport_" + date;
                    break;

                default:
                    fileName = "AllProductsReport_" + date;
                    break;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = ".csv";
            saveFile.FileName = fileName;
            saveFile.Filter = "csv files(*.csv) | *.csv | All files(*.*) | *.*";

            saveFile.ShowDialog();
            string filePath = saveFile.FileName;


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

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            if (openFile.FileName.Any())
            {
                System.Diagnostics.Process.Start(openFile.FileName);
            }
        }
    }
}
