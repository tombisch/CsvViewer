using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CsvViewer
{
    class CsvLoader
    {
        private string filepath;
        private bool hasColumnHeaders;
        private DataTable csvDataTable;

        public CsvLoader(string filepath, bool hasColumnHeaders)
        {
            this.filepath = filepath;
            this.hasColumnHeaders = hasColumnHeaders;
            csvDataTable = new DataTable();
        }

        public string Filepath
        {
            get { return filepath; }
            set { filepath = value; }
        }

        public bool HasColumnHeaders
        {
            get { return hasColumnHeaders; }
            set { hasColumnHeaders = value; }
        }

        public DataTable CsvDataTable
        {
            get { return csvDataTable; }
        }

        /// <summary>
        /// Loads csv from filepath to System.Data.DataTable.
        /// </summary>
        /// <returns></returns>
        public void LoadCSVToDataTable()
        {
            if (String.IsNullOrEmpty(filepath))
            {
                throw new Exception("Csv filepath is invalid.");
            }

            using (TextFieldParser parser = new TextFieldParser(filepath))
            {
                parser.SetDelimiters(",");

                // If csv not blank, add column headers to data table
                if (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    // Use column headers if supplied, otherwise create generic ones
                    if (hasColumnHeaders)
                    {
                        foreach (var f in fields)
                        {
                            csvDataTable.Columns.Add(f);
                        }
                    }
                    else
                    {
                        int colIndex = 1;
                        foreach (var f in fields)
                        {
                            csvDataTable.Columns.Add("Col " + (colIndex++).ToString());
                        }
                        csvDataTable.Rows.Add(fields);
                    }
                }
                
                // Add data rows until reaching end of file
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    csvDataTable.Rows.Add(fields);
                }
            }
        }
    }
}
