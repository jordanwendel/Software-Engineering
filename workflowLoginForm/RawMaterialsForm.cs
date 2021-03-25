using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace workflowLoginForm
{
    public partial class RawMaterialsForm : Form
    {

        private RawMaterial objRawMaterial;
        private DatabaseTools dbTools;
        private StockiestForm stock;

        // Constructor
        public RawMaterialsForm()
        {
            InitializeComponent();
        }


        // Event handler for Insert Information button
        private void btnInsertInformation_Click(object sender, EventArgs e)
        {
            try
            {
                objRawMaterial = new RawMaterial(txtRawMatName.Text, int.Parse(txtRawMatQuanity.Text)); // Create a new raw material object and put it into the RawMaterials database automatically
                MessageBox.Show("Item enterted Successfully");

                // Clear text boxes
                txtRawMatName.Clear();
                txtRawMatQuanity.Clear();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }

            this.Hide();

        }

        // Event handler for Exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

