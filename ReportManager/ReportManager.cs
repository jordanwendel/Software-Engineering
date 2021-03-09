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

        private void Admin_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            System.Threading.Thread display = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));//create new display thing called dispaly
            this.Close(); //close current display
            display.Start();//open new display
        }
        public static void OpenLoginForm()
        {
            Application.Run(new RepManager());
        }
    }
}
