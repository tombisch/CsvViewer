using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CsvViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens a file browser dialogue for the user to select a csv file to load / view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openCsv = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Choose Csv File",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "csv files (*.csv)|*.csv",
                RestoreDirectory = true,
                ReadOnlyChecked = true,
            };

            if (openCsv.ShowDialog() == DialogResult.OK)
            {
                txtCsvFile.Text = openCsv.FileName;
                loadCsvData();
            }
        }

        /// <summary>
        /// Loads data of selected csv file to grid view and to combo box view if possible.
        /// Loading to combo box view requires csv to have 2 columns: col 1 = id, col 2 = name.
        /// </summary>
        private void loadCsvData()
        {
            try
            {
                // Load data table from selected csv
                CsvLoader loader = new CsvLoader(txtCsvFile.Text, chkIncludesColumnHeaders.Checked);
                loader.LoadCSVToDataTable();

                // Load grid view
                gridCsvData.DataSource = null;
                gridCsvData.Rows.Clear(); // clear the datagrid of existing data
                gridCsvData.DataSource = loader.CsvDataTable;

                // Load combo box view if 2 columns present: col 1 = id, col 2 = name
                cbNames.Items.Clear(); // clear the combobox of existing items
                if (loader.CsvDataTable.Columns.Count == 2)
                {
                    if (loader.CsvDataTable.Columns[0].ColumnName.ToLowerInvariant() == "id" &&
                        loader.CsvDataTable.Columns[1].ColumnName.ToLowerInvariant() == "name")
                    {
                        foreach (DataRow row in loader.CsvDataTable.Rows)
                        {
                            ComboBoxItem item = new ComboBoxItem();
                            item.Id = row[0] as string;
                            item.Name = row[1] as string;
                            cbNames.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Encountered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Remove selected row from grid view control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            if (gridCsvData.SelectedRows.Count <= 0)
                return;

            try
            {
                foreach (DataGridViewRow row in gridCsvData.SelectedRows)
                {
                    gridCsvData.Rows.RemoveAt(row.Index);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Encountered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Update the text on the button to show the id for the selected combobox item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCbNameId_Click(object sender, EventArgs e)
        {
            if (cbNames.SelectedItem == null)
                return;

            try
            {
                btnCbNameId.Text = (cbNames.SelectedItem as ComboBoxItem).Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Encountered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
