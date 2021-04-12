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
    public partial class QualityAnalyzerForm : Form
    {
        // Class level objects
        private DatabaseTools dbTools;
        private DataGridTools dgTools;

        // Variables

        public QualityAnalyzerForm()
        {
            InitializeComponent();
            dgTools = new DataGridTools();
        }

        private void Admin_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dgTools.dbName = "Products";
            
            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products";
            
            dgTools.RefreshDataGrid(prodDataGridView);

        }

        private void Admin_Click_1(object sender, EventArgs e)
        {

        }

        private void Logout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QualityAnalyzerForm_Load(object sender, EventArgs e)
        {
            dgTools.dbName = "Products";
            
            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products";
            
            dgTools.PopulateDataGrid(prodDataGridView);

        }

        private void addProduct_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            dgTools.dbName = "Products";

            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products";

            dgTools.PopulateDataGrid(prodDataGridView);

        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            String ProductName = ItemName.Text;
            String Quality = qualityMenu.Text;
            dbTools = new DatabaseTools();

            dbTools.CheckProduct(ProductName);

            if (dbTools.CheckProduct(ProductName).Equals(true))
            {
                try
                {
                    dbTools.EditQuality(ProductName, Quality);
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
