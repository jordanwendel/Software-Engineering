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
        // Constructor
        public RawMaterialsForm()
        {
            InitializeComponent();
        }

        //create RawMeterial object
        private RawMaterial objRawMaterial;

        // Event handler for Insert Information button
        private void btnInsertInformation_Click(object sender, EventArgs e)
        {
            //assign objRawMaterial
            objRawMaterial = new RawMaterial(txtRawMatName.Text, int.Parse(txtRawMatQuanity.Text));

            //add item to the database
            objRawMaterial.addRawMaterialInfo();

            MessageBox.Show("Item enterted Successfully");

            //clear text boxes
            txtRawMatName.Clear();
            txtRawMatQuanity.Clear();
        }

        // Event handler for Exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RawMaterials_Load(object sender, EventArgs e)
        {

        }
    }
}

