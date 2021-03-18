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
    public partial class DeliveryManagerForm : Form
    {

        private DeliveryManager delManager;

        public DeliveryManagerForm()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            //close current display
            delManager.clearUser();
        }
       
    }
}
