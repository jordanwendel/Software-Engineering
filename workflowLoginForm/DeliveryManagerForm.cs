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
    public partial class DeliveryManagerForm : Form
    {
        //class level objects
        private DatabaseTools dbTools;
        private DataGridTools dgTools;

        
        public DeliveryManagerForm()
        {
            InitializeComponent();
            dgTools = new DataGridTools();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Click(object sender, EventArgs e)
        {

        }

        private void prodDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dgTools.dbName = "Products";
            
            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products Where Quality IN ('Satisfactory','Defective')";
            
            dgTools.RefreshDataGrid(prodDataGridView);

        }

        private void DeliveryManagerForm_Load(object sender, EventArgs e)
        {
            dgTools.dbName = "Products";

            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products Where Quality IN ('Satisfactory','Defective')";
            
            dgTools.PopulateDataGrid(prodDataGridView);

        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            String ProductName = txtItemName.Text;
            String Location = locationMenu.Text;
            dbTools = new DatabaseTools();

            dbTools.CheckProduct(ProductName);

                if (dbTools.CheckProduct(ProductName).Equals(true))
                {
                    try
                    {
                        dbTools.EditLocation(ProductName, Location);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgTools.dbName = "Products";

            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products Where Quality IN ('Satisfactory','Defective')";
            
            dgTools.PopulateDataGrid(prodDataGridView);

        }
    }
}
