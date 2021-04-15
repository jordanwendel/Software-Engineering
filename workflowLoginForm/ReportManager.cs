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
    public partial class ReportManager : Form
    {
        private RawMaterialsReport RawMaterialsReport;
        private ProductReport ProductReport;
        public ReportManager()
        {
            InitializeComponent();
        }

        private void RawMatbtn_Click(object sender, EventArgs e)
        {
            RawMaterialsReport = new RawMaterialsReport();
            this.Hide();
            RawMaterialsReport.ShowDialog();
            this.Show();
        }

        private void Productbtn_Click(object sender, EventArgs e)
        {
            ProductReport = new ProductReport();
            this.Hide();
            ProductReport.ShowDialog();
            this.Show();
        }
    }
}
