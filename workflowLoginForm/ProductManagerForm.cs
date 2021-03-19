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
    public partial class ProductManagerForm : Form
    {
        private ProductForm stockpage;
        public ProductManagerForm()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            stockpage = new ProductForm();
            stockpage.ShowDialog();//open new display
            this.Show();
        }
    }
}
