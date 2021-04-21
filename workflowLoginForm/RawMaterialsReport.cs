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
    public partial class RawMaterialsReport : Form
    {
        //private DatabaseTools dbTools;
        private DataGridTools dgTools;
        private DatabaseReport dbReport;

        public RawMaterialsReport()
        {
            InitializeComponent();
            dgTools = new DataGridTools();
            dbReport = new DatabaseReport();
        }

        private void RawMaterialsReport_Load(object sender, EventArgs e)
        {
            // Fill the data grid view on form with contents of given database using a data grid object
            dgTools.dbName = "RawMaterials";
            dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials"; // Viewing all data from RawMaterials database except the ID
            dgTools.PopulateDataGrid(stockDataGridView);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int Count = dbReport.CountMaterials();
            string Counter = Count.ToString();
            countlbl.Text = Counter;

            int Avg = dbReport.AvgQuantMaterials();
            string Average = Avg.ToString();
            averagelbl.Text = Average;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void stockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
