using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DeliveryManager
{
    public partial class DelManager : Form
    {
        public DelManager()
        {
            InitializeComponent();
        }

        private void DelManager_Load(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close(); //close current display
        }
       
    }
}
