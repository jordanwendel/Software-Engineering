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
    public partial class ProductManagerForm : Form
    {
        private DatabaseTools dbTools;
        private ProductForm stockpage;

        public ProductManagerForm()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            stockpage = new ProductForm();
            stockpage.ShowDialog();//open new display
            this.Show();
        }

        private void ProductManagerForm_Load(object sender, EventArgs e)
        {
            dbTools = new DatabaseTools();
            dbTools.PopulateDataGrid(prodDataGridView, "Products");
            prodDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            prodDataGridView.RowsDefaultCellStyle.BackColor = Color.Wheat;
            prodDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dbTools = new DatabaseTools();
            dbTools.RefreshDataGrid(prodDataGridView, "Products");
        }
    }
}
