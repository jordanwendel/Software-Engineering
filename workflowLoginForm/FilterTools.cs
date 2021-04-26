using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace workflowLoginForm
{
    public class FilterTools
    {
        private DatabaseTools dbTools;
        private DataGridTools dgTools;
        public string dbName { get; set; }
        public string SqlCommand { get; set; }

        public FilterTools()
        {
            dbTools = new DatabaseTools();
            dgTools = new DataGridTools();
        }

        public string ViewFilterResults(DataGridView dataGrid)
        {

            // Get the size of each result to display the matched records
            int dataGridSize = 0;
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                dataGridSize++;
            }

            string label = "There is/are " + (dataGridSize - 1) + " result(s) that matched your filter";

            return label;
        }


     
        public void FilterDatagrid(string nameFilter, string qualityFilter, string locationFilter, string quantityFilter, string inequality, DataGridView dataGrid, ToolStripStatusLabel status, string filterMenu)
        {
            dgTools.dbName = this.dbName;
            dgTools.SqlCommand = this.SqlCommand;
            string info = nameFilter;
            string qual = qualityFilter;
            string location = locationFilter;

            // Filtering Products database
            if (dbName.Equals("Products"))
            {
                try
                {
                    switch (filterMenu)
                    {
                        case "Name": // Filtering by name
                            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE ProductName LIKE " + "'%" + info + "%'"; // Any matches of the inputted search term
                            dgTools.PopulateDataGrid(dataGrid);
                            status.Text = ViewFilterResults(dataGrid);
                            break;

                        case "Quality": // Filtering by quality
                            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Quality = " + "'" + qual + "'";
                            dgTools.PopulateDataGrid(dataGrid);
                            status.Text = ViewFilterResults(dataGrid);
                            break;

                        case "Quantity": // Filtering by quantity
                            if (int.Parse(quantityFilter) > 0)
                            {
                                switch (inequality)
                                {
                                    case "GREATER THAN":
                                        dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Quantity > " + "'" + quantityFilter + "'";
                                        break;

                                    case "LESS THAN":
                                        dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Quantity < " + "'" + quantityFilter + "'";
                                        break;

                                    case "EQUAL TO":
                                        dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Quantity = " + "'" + quantityFilter + "'";
                                        break;

                                    default:
                                        MessageBox.Show("Not a valid selection. Please try again.", "Warning!");
                                        break;
                                }
                            }
                            else // Entered quantity is <= 0
                            {
                                MessageBox.Show("Quantity must be greater than zero");
                                status.Text = "";
                            }

                            dgTools.PopulateDataGrid(dataGrid);
                            status.Text = ViewFilterResults(dataGrid);
                            break;

                        case "Location": // Filtering by location
                            dgTools.SqlCommand = "SELECT ProductName, Quality, Quantity, Location FROM Products WHERE Location = " + "'" + location + "'";
                            dgTools.PopulateDataGrid(dataGrid);
                            status.Text = ViewFilterResults(dataGrid);
                            break;

                        default:
                            break;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please input the correct information");
                    throw;
                }
            }
            else if (dbName.Equals("RawMaterials")) // Filtering Raw Materials database
            {
                try
                {
                    switch (filterMenu)
                    {
                        case "Name":
                            dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials WHERE RawMaterialName LIKE " + "'%" + info + "%'"; // Any matches of the inputted search 
                            dgTools.PopulateDataGrid(dataGrid);
                            status.Text = ViewFilterResults(dataGrid);
                            break;

                        case "Quantity":
                            if (int.Parse(quantityFilter) > 0)
                            {
                                switch (inequality)
                                {
                                    case "GREATER THAN":
                                        dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials WHERE Quantity > " + "'" + quantityFilter + "'";
                                        break;

                                    case "LESS THAN":
                                        dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials WHERE Quantity < " + "'" + quantityFilter + "'";
                                        break;

                                    case "EQUAL TO":
                                        dgTools.SqlCommand = "SELECT RawMaterialName, Quantity FROM RawMaterials WHERE Quantity = " + "'" + quantityFilter + "'";
                                        break;

                                    default:
                                        MessageBox.Show("Not a valid selection. Please try again.", "Warning!");
                                        break;
                                }
                            }
                            else // Entered quantity is <= 0
                            {
                                MessageBox.Show("Quantity must be greater than zero");
                                status.Text = "";
                            }
                            dgTools.PopulateDataGrid(dataGrid);
                            status.Text = ViewFilterResults(dataGrid);
                            break;

                        default:
                            break;
                    }
                }
                catch (FormatException)
                {
                    //MessageBox.Show(err.Message, "Please input the correct information");
                    throw;
                }
            }
        }
    }
}
