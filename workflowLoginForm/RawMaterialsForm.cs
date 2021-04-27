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
        public string Title { get; set; }
        public string Description { get; set; }
        private RawMaterial objRawMaterial;
        private DatabaseTools dbTools;

        // Constructor
        public RawMaterialsForm(string title = "", string desc = "")
        {
            InitializeComponent();
            dbTools = new DatabaseTools();
            Title = title;

            // If the title for the screen is passed into the parameters, it will change the text on the form before showing it
            if (title != "" && desc != "")
            {
                lblRawMat.Text = title;
                lblDesc.Text = desc;
            }
        }


        // Event handler for Insert Information button
        private void btnInsertInformation_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Are you sure you want to create a new material called " + txtRawMatName.Text + " with quantity " + txtRawMatQuanity.Text + "?";
                string title = "Warning!";

                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    objRawMaterial = new RawMaterial(txtRawMatName.Text, int.Parse(txtRawMatQuanity.Text)); // Create a new raw material object
                    dbTools.AddRawMaterial(objRawMaterial); // Add the raw material to the database
                    MessageBox.Show("Item Entered Successfully");
                }
                else
                {
                    return;
                }


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

