using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workflowLoginForm
{
    public partial class StockiestForm : Form
    {
        // Class level objects
        private DatabaseTools dbTools;
        private RawMaterialsForm stockpage;
        private DataGridTools dgTools;


        // Constructor
        public StockiestForm()
        {
            InitializeComponent();
            dgTools = new DataGridTools();
        }

        // Event handler for Stockiest Form load
        private void StockiestForm_Load(object sender, EventArgs e)
        {
            // Fill the data grid view on form with contents of given database using a data grid object
            dgTools.dbName = "RawMaterials";

            dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials"; // Viewing all data from RawMaterials database except the ID
            
            dgTools.PopulateDataGrid(stockDataGridView);

        }

        // Event handler for Logout button click
        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for Refresh Inventory button click
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dgTools.dbName = "RawMaterials";
            
            dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials"; // Viewing all data from RawMaterials database except the ID
            
            dgTools.RefreshDataGrid(stockDataGridView);

        }

        // Event handler for Add New button click
        private void addNewMat_Btn_Click(object sender, EventArgs e)
        {
            stockpage = new RawMaterialsForm();
            stockpage.ShowDialog(); // Open new display
            this.Show();
        }

        private void addNewMatBtn_Click(object sender, EventArgs e)
        {
                String MatName = itembox.Text;
                int Quant = int.Parse(qtnBox.Text);
                dbTools = new DatabaseTools();

                if (dbTools.CheckMat(MatName).Equals(true))
                {
                    try
                    {
                        dbTools.EditQuant(MatName, Quant);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Warning!");
                    }
                }
                else
                {
                    MessageBox.Show("This item can not be found.");

                }
            }
        }
    }
