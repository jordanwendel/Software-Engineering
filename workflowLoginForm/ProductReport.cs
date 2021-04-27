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
            countlbl1.Text = Counter;

            int Avg = dbReport.AvgQuantProducts();
            string Average = Avg.ToString();
            averagelbl1.Text = Average;

            int Quality = dbReport.GoodProducts();
            string Qualitylabel = Quality.ToString();
            satisfactorylbl1.Text = Qualitylabel;

            int BadQuality = dbReport.BadProducts();
            string Badlabel = BadQuality.ToString();
            defectivelbl1.Text = Badlabel;

            int ProgressQuality = dbReport.ProgressProducts();
            string Progresslabel = ProgressQuality.ToString();
            progresslbl1.Text = Progresslabel;

            decimal QualPercent = (Quality * 100 / Count);
           // Decimal QualPercent2 = Decimal.Truncate(QualPercent);
            string QualityPercent = QualPercent.ToString();
            qualitylbl1.Text = QualityPercent + "%";

            int salescount = dbReport.SalesProducts();
            string SalesCount = salescount.ToString();
            saleslbl.Text = SalesCount;

            int manucount = dbReport.ManuProducts();
            string ManuCount = manucount.ToString();
            manufacturinglbl1.Text = ManuCount;

            decimal salesPercent = (salescount * 100 / Count);
            // Decimal QualPercent2 = Decimal.Truncate(QualPercent);
            string SalesPercent = salesPercent.ToString();
            percentsaleslbl1.Text = SalesPercent + "%";
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ProductReport_Load(object sender, EventArgs e)
        {
            dgTools.dbName = "Products";

            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products Where Quality IN ('Satisfactory','Defective')";

            dgTools.PopulateDataGrid(stockDataGridView);

            int Count = dbReport.CountProducts();
            string Counter = Count.ToString();
            countlbl1.Text = Counter;

            int Avg = dbReport.AvgQuantProducts();
            string Average = Avg.ToString();
            averagelbl1.Text = Average;

            int Quality = dbReport.GoodProducts();
            string Qualitylabel = Quality.ToString();
            satisfactorylbl1.Text = Qualitylabel;

            int BadQuality = dbReport.BadProducts();
            string Badlabel = BadQuality.ToString();
            defectivelbl1.Text = Badlabel;

            int ProgressQuality = dbReport.ProgressProducts();
            string Progresslabel = ProgressQuality.ToString();
            progresslbl1.Text = Progresslabel;

            decimal QualPercent = (Quality * 100 / Count);
            // Decimal QualPercent2 = Decimal.Truncate(QualPercent);
            string QualityPercent = QualPercent.ToString();
            qualitylbl1.Text = QualityPercent + "%";

            int salescount = dbReport.SalesProducts();
            string SalesCount = salescount.ToString();
            saleslbl.Text = SalesCount;

            int manucount = dbReport.ManuProducts();
            string ManuCount = manucount.ToString();
            manufacturinglbl1.Text = ManuCount;

            decimal salesPercent = (salescount * 100 / Count);
            // Decimal QualPercent2 = Decimal.Truncate(QualPercent);
            string SalesPercent = salesPercent.ToString();
            percentsaleslbl1.Text = SalesPercent + "%";
        }
    }
}
