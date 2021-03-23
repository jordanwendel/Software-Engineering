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
        private DatabaseTools dbTools;
        private RawMaterialsForm stockpage;

        public StockiestForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbTools = new DatabaseTools();
            dbTools.PopulateDataGrid(dataGridView1);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Wheat;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewMatBtn_Click(object sender, EventArgs e)
        {
            stockpage = new RawMaterialsForm();
            stockpage.ShowDialog(); // Open new display
            this.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dbTools.RefreshDataGrid(dataGridView1);
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
