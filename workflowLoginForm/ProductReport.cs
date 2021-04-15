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
    public partial class ProductReport : Form
    {
        private DataGridTools dgTools;
        private DatabaseReport dbReport;
        public ProductReport()
        {
            InitializeComponent();
            dgTools = new DataGridTools();
            dbReport = new DatabaseReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Count = dbReport.CountProducts();
            string Counter = Count.ToString();
            countlbl.Text = Counter;

            int Avg = dbReport.AvgQuantProducts();
            string Average = Avg.ToString();
            averagelbl.Text = Average;

            int Quality = dbReport.AvgQuantProducts();
            MessageBox.Show(Quality.ToString());
            decimal QualPercent = Quality / Count * 100;
            Decimal QualPercent2 = Decimal.Truncate(QualPercent);
            string QualityPercent = QualPercent2.ToString();
            qualitylbl.Text = QualityPercent;
        }
    }
}
