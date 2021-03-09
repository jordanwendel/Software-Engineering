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
           // System.Threading.Thread display = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));//create new display thing called dispaly
          //  this.Close(); //close current display
           // display.Start();//open new display
        }
       
    }
}
