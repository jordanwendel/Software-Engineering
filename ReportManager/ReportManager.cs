using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportManager
{
    public partial class RepManager : Form
    {
        public RepManager()
        {
            InitializeComponent();
        }


        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close(); //close current display
        }
        private void RepManager_Load_1(object sender, EventArgs e)
        {

        }
    }
}
