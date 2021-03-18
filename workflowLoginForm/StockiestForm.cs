s
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
        private Stockiest s;
        private RawMaterialsForm stockpage;
        public StockiestForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stockpage = new RawMaterialsForm();
            stockpage.ShowDialog();//open new display
            this.Show();
        }
    }
}
