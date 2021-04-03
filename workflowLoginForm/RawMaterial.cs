using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace workflowLoginForm
{
    class RawMaterial
    {
        private DatabaseTools dbTools;

        public string rawMaterialName { get; set; }
        public int quantity { get; set; }


        // Constructor
        public RawMaterial(string rawMaterialName, int quantity)
        {
            dbTools = new DatabaseTools();
            this.rawMaterialName = rawMaterialName;
            this.quantity = quantity;

            try
            {
                dbTools.AddRawMaterial(rawMaterialName, quantity); // Automatically enters the raw material into the database when called
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }

    }
}
