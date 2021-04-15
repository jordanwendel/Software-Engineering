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
    }
}
