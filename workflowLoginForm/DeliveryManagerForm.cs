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
        public DeliveryManagerForm()
        {
            InitializeComponent();
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
            dbTools = new DatabaseTools("Products");
            dbTools.RefreshDataGrid(prodDataGridView);
        }

        private void DeliveryManagerForm_Load(object sender, EventArgs e)
        {
            String statement = "SELECT ProductName, Quality, Quantity, Location FROM  Products Where Quality IN ('Satisfactory','Defective')";
            dbTools = new DatabaseTools("Products" );
            dbTools.PopulateDataGrid(prodDataGridView,statement);
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
