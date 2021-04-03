using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace workflowLoginForm
{
    class Product
    {

        private DatabaseTools dbTools;

        private string productName { get; set; }
        private string quality { get; set; }
        private int quantity { get; set; }
        private string location { get; set; }

        public Product()
        {

        }

        // Constructor
        public Product(string productName, string quality, int quantity, string location)
        {
            this.productName = productName;
            this.quality = quality;
            this.quantity = quantity;
            this.location = location;

            // Put product into Product database
            dbTools = new DatabaseTools();
            try
            {
                dbTools.AddProduct(productName, quality, quantity, location); // Automatically enters the product into the database when called
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }

        }

    }
}
