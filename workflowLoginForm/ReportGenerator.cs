using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using CsvHelper;
using System.Globalization;
using System.Windows.Forms;

namespace workflowLoginForm
{
    public class ReportGenerator
    {
        // Class level objects
        private DatabaseTools dbTools;

        // Variables


        // Constructor
        public ReportGenerator()
        {
            dbTools = new DatabaseTools();
        }



        // Methods

        // Generate a csv of all items in the Raw Materials database
        public void GenerateRawMaterialsReport(string path)
        {
            List<RawMaterial> rawMaterials;
            rawMaterials = new List<RawMaterial>();

            rawMaterials = dbTools.CreateRawMaterialList();

            // Write headers to csv here
            using (var writer = new StreamWriter(path)) //, false, System.Text.Encoding.UTF8))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                try
                {
                    csv.WriteRecords(rawMaterials);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Trouble writing to CSV");
                }
                
            }
           
        }


        // Generate a csv of the Product database, specifically filtered based on which products the user wants -- in progress, qualified, defective, or all products
        public void GenerateProductReport(string path, string filter)
        {
            List<Product> products;
            products = new List<Product>();

            products = dbTools.CreateProductList(filter);

            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                try
                {
                    csv.WriteRecords(products);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Trouble writing to CSV");
                }

            }
        }

        // Function that saves csv reports to subdirectory
        public string SaveReport(string type, string prefix = "")
        {
            string fileName = "";
            DateTime now = DateTime.Now;
            String date = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", now);
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName + @"\Reports";
            SaveFileDialog saveFile = new SaveFileDialog();

            if (type.Equals("RawMaterials"))
            {
                saveFile = new SaveFileDialog();

                saveFile.InitialDirectory = projectDirectory;
                saveFile.FileName = "RawMaterialsReport_" + date;
                saveFile.DefaultExt = ".csv";
                saveFile.Filter = "csv files(*.csv) | *.csv | All files(*.*) | *.*";
                saveFile.ShowDialog();

                fileName = saveFile.FileName;
            }

            else if (type.Equals("Products"))
            {
                // Switching file name based on which report is needed
                /*switch (prodFilter)
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
                }*/
                fileName = prefix + date;
                saveFile = new SaveFileDialog();
                saveFile.DefaultExt = ".csv";
                saveFile.FileName = fileName;
                saveFile.Filter = "csv files(*.csv) | *.csv | All files(*.*) | *.*";
                saveFile.ShowDialog();

                fileName = saveFile.FileName;
            }
            return fileName;

        }

        // Function that opens subdirectory with all reports
        public string OpenReports()
        {
            OpenFileDialog openFile = new OpenFileDialog();

            // Setting the working directory to Reports folder
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName + @"\Reports";
            openFile.InitialDirectory = projectDirectory;
            openFile.ShowDialog();

            return openFile.FileName;
        }
    }
}
