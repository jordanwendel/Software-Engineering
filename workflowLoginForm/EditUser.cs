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
    public partial class EditUserInfo : Form
    {
        private DataGridTools dgTools;
        private DatabaseTools dbTools;
        public EditUserInfo()
        {
            InitializeComponent();
            dgTools = new DataGridTools();
            dbTools = new DatabaseTools();

        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            
            // Show Stockiests
            try
            {
                dgTools.dbName = "AuthorizedUsers";

                dgTools.SqlCommand = "SELECT firstname, lastname FROM AuthorizedUsers WHERE userjob in ('Stockiest')";

                dgTools.PopulateDataGrid(StockiestDataGridView);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }

            // Show Product Managers
            try
            {
                dgTools.dbName = "AuthorizedUsers";

                dgTools.SqlCommand = "SELECT firstname, lastname FROM AuthorizedUsers WHERE userjob in ('Product Manager')";

                dgTools.PopulateDataGrid(ProductDataGridView);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }

            // Show Delivery Managers
            try
            {
                dgTools.dbName = "AuthorizedUsers";

                dgTools.SqlCommand = "SELECT firstname, lastname FROM AuthorizedUsers WHERE userjob in ('Delivery Manager')";

                dgTools.PopulateDataGrid(DeliveryDataGridView);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }

            // Show Report Managers
            try
            {
                dgTools.dbName = "AuthorizedUsers";

                dgTools.SqlCommand = "SELECT firstname, lastname FROM AuthorizedUsers WHERE userjob in ('Report Manager')";

                dgTools.PopulateDataGrid(ReportDataGridView);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }

            // Show Quality Analyzers
            try
            {
                dgTools.dbName = "AuthorizedUsers";

                dgTools.SqlCommand = "SELECT firstname,lastname FROM AuthorizedUsers WHERE userjob in ('Quality Analyzer')";

                dgTools.PopulateDataGrid(QualityDataGridView);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
            // Show Admins
            try
            {
                dgTools.dbName = "AuthorizedUsers";

                dgTools.SqlCommand = "SELECT firstname, lastname FROM AuthorizedUsers WHERE userjob in ('Administrator')";

                dgTools.PopulateDataGrid(AdminDataGridView);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string job = boxOccupation.Text;
            dbTools = new DatabaseTools();

            try
            {
                string message = "Are you sure you want to change the job of " + txtFirstName.Text + " " + txtLastName.Text + " to " + job + "?";
                string title = "Warning!";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    dbTools.EditUserJob(firstname, lastname, job);
                    dgTools.SqlCommand = "SELECT firstname, lastname FROM AuthorizedUsers WHERE userjob in ('Administrator')"; // Viewing all data from RawMaterials database except the ID
                    dgTools.RefreshDataGrid(AdminDataGridView);
                    dgTools.SqlCommand = "SELECT firstname, lastname FROM AuthorizedUsers WHERE userjob in ('Quality Analyzer')";
                    dgTools.RefreshDataGrid(QualityDataGridView);
                    dgTools.SqlCommand = "SELECT firstname, lastname FROM AuthorizedUsers WHERE userjob in ('Report Manager')";
                    dgTools.RefreshDataGrid(ReportDataGridView);
                    dgTools.SqlCommand = "SELECT firstname, lastname FROM AuthorizedUsers WHERE userjob in ('Delivery Manager')";
                    dgTools.RefreshDataGrid(DeliveryDataGridView);
                    dgTools.SqlCommand = "SELECT firstname, lastname FROM AuthorizedUsers WHERE userjob in ('Product Manager')";
                    dgTools.RefreshDataGrid(ProductDataGridView);
                    dgTools.SqlCommand = "SELECT firstname, lastname FROM AuthorizedUsers WHERE userjob in ('Stockiest')";
                    dgTools.RefreshDataGrid(StockiestDataGridView);
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    boxOccupation.Items.Clear();
                }
                else
                {
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StockiestDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = StockiestDataGridView.Rows[e.RowIndex]; // Creating a row object from the currently selected row
                txtFirstName.Text = row.Cells[0].Value.ToString();
                txtLastName.Text = row.Cells[1].Value.ToString(); // Selecting the product name from the row object
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ReportDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ReportDataGridView.Rows[e.RowIndex]; // Creating a row object from the currently selected row
                txtFirstName.Text = row.Cells[0].Value.ToString();
                txtLastName.Text = row.Cells[1].Value.ToString();// Selecting the product name from the row object
            }
        }

        private void QualityDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = QualityDataGridView.Rows[e.RowIndex]; // Creating a row object from the currently selected row
                txtFirstName.Text = row.Cells[0].Value.ToString();
                txtLastName.Text = row.Cells[1].Value.ToString(); // Selecting the product name from the row object
            }
        }

        private void DeliveryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DeliveryDataGridView.Rows[e.RowIndex]; // Creating a row object from the currently selected row
                txtFirstName.Text = row.Cells[0].Value.ToString();
                txtLastName.Text = row.Cells[1].Value.ToString(); // Selecting the product name from the row object
            }
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProductDataGridView.Rows[e.RowIndex]; // Creating a row object from the currently selected row
                txtFirstName.Text = row.Cells[0].Value.ToString();
                txtLastName.Text = row.Cells[1].Value.ToString(); // Selecting the product name from the row object
            }
        }

        private void AdminDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AdminDataGridView.Rows[e.RowIndex]; // Creating a row object from the currently selected row
                txtFirstName.Text = row.Cells[0].Value.ToString();
                txtLastName.Text = row.Cells[1].Value.ToString(); // Selecting the product name from the row object
            }
        }

        private void viewProductReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            if (openFile.FileName.Any())
            {
                System.Diagnostics.Process.Start(openFile.FileName);
            }
        }
    }
}
