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
    public partial class ReportManagerForm : Form
    {
        public ReportManagerForm()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
