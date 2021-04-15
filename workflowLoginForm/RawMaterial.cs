using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace workflowLoginForm
{
    public class RawMaterial
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
        }

        public override string ToString()
        {
            return string.Format("{0},{1}\n", rawMaterialName, quantity);
        }

    }
}
