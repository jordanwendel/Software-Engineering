using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace workflowLoginForm
{
    public class Product
    {

        private DatabaseTools dbTools;

        public string productName { get; set; }
        public string quality { get; set; }
        public int quantity { get; set; }
        public string location { get; set; }

        // Constructor
        public Product(string productName, string quality, int quantity, string location)
        {
            this.productName = productName;
            this.quality = quality;
            this.quantity = quantity;
            this.location = location;
        }

        public override string ToString()
        {
             return string.Format("{0},{1},{2},{3}\n", productName, quality, quantity, location);
        }

    }
}
