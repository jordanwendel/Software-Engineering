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

        // Variables

        public QualityAnalyzerForm()
        {
            InitializeComponent();
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
            dbTools = new DatabaseTools("Products");
            dbTools.RefreshDataGrid(prodDataGridView); // Refresh the data grid to see changes
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
            dbTools = new DatabaseTools("Products"); // Default data grid is Products database
            dbTools.PopulateDataGrid(prodDataGridView);
        }
    }
}
