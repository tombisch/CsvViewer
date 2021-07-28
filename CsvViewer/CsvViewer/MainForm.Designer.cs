namespace CsvViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChooseCsv = new System.Windows.Forms.Button();
            this.txtCsvFile = new System.Windows.Forms.TextBox();
            this.chkIncludesColumnHeaders = new System.Windows.Forms.CheckBox();
            this.gridCsvData = new System.Windows.Forms.DataGridView();
            this.CsvComboBoxView = new System.Windows.Forms.TabControl();
            this.tabCsvGridView = new System.Windows.Forms.TabPage();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.tabCsvComboView = new System.Windows.Forms.TabPage();
            this.cbNames = new System.Windows.Forms.ComboBox();
            this.btnCbNameId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCsvData)).BeginInit();
            this.CsvComboBoxView.SuspendLayout();
            this.tabCsvGridView.SuspendLayout();
            this.tabCsvComboView.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChooseCsv
            // 
            this.btnChooseCsv.Location = new System.Drawing.Point(16, 14);
            this.btnChooseCsv.Name = "btnChooseCsv";
            this.btnChooseCsv.Size = new System.Drawing.Size(75, 23);
            this.btnChooseCsv.TabIndex = 0;
            this.btnChooseCsv.Text = "Choose Csv";
            this.btnChooseCsv.UseVisualStyleBackColor = true;
            this.btnChooseCsv.Click += new System.EventHandler(this.btnChooseCsv_Click);
            // 
            // txtCsvFile
            // 
            this.txtCsvFile.Location = new System.Drawing.Point(108, 16);
            this.txtCsvFile.Name = "txtCsvFile";
            this.txtCsvFile.ReadOnly = true;
            this.txtCsvFile.Size = new System.Drawing.Size(265, 20);
            this.txtCsvFile.TabIndex = 1;
            // 
            // chkIncludesColumnHeaders
            // 
            this.chkIncludesColumnHeaders.AutoSize = true;
            this.chkIncludesColumnHeaders.Checked = true;
            this.chkIncludesColumnHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludesColumnHeaders.Location = new System.Drawing.Point(398, 19);
            this.chkIncludesColumnHeaders.Name = "chkIncludesColumnHeaders";
            this.chkIncludesColumnHeaders.Size = new System.Drawing.Size(150, 17);
            this.chkIncludesColumnHeaders.TabIndex = 2;
            this.chkIncludesColumnHeaders.Text = "Includes column headers?";
            this.chkIncludesColumnHeaders.UseVisualStyleBackColor = true;
            // 
            // gridCsvData
            // 
            this.gridCsvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCsvData.Location = new System.Drawing.Point(16, 18);
            this.gridCsvData.Name = "gridCsvData";
            this.gridCsvData.Size = new System.Drawing.Size(568, 322);
            this.gridCsvData.TabIndex = 3;
            // 
            // CsvComboBoxView
            // 
            this.CsvComboBoxView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CsvComboBoxView.Controls.Add(this.tabCsvGridView);
            this.CsvComboBoxView.Controls.Add(this.tabCsvComboView);
            this.CsvComboBoxView.Location = new System.Drawing.Point(16, 63);
            this.CsvComboBoxView.Name = "CsvComboBoxView";
            this.CsvComboBoxView.SelectedIndex = 0;
            this.CsvComboBoxView.Size = new System.Drawing.Size(760, 412);
            this.CsvComboBoxView.TabIndex = 4;
            // 
            // tabCsvGridView
            // 
            this.tabCsvGridView.Controls.Add(this.btnRemoveRow);
            this.tabCsvGridView.Controls.Add(this.gridCsvData);
            this.tabCsvGridView.Location = new System.Drawing.Point(4, 22);
            this.tabCsvGridView.Name = "tabCsvGridView";
            this.tabCsvGridView.Padding = new System.Windows.Forms.Padding(3);
            this.tabCsvGridView.Size = new System.Drawing.Size(752, 386);
            this.tabCsvGridView.TabIndex = 0;
            this.tabCsvGridView.Text = "Grid View";
            this.tabCsvGridView.UseVisualStyleBackColor = true;
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Location = new System.Drawing.Point(590, 18);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(80, 23);
            this.btnRemoveRow.TabIndex = 4;
            this.btnRemoveRow.Text = "Remove Row";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // tabCsvComboView
            // 
            this.tabCsvComboView.Controls.Add(this.cbNames);
            this.tabCsvComboView.Controls.Add(this.btnCbNameId);
            this.tabCsvComboView.Location = new System.Drawing.Point(4, 22);
            this.tabCsvComboView.Name = "tabCsvComboView";
            this.tabCsvComboView.Padding = new System.Windows.Forms.Padding(3);
            this.tabCsvComboView.Size = new System.Drawing.Size(752, 386);
            this.tabCsvComboView.TabIndex = 1;
            this.tabCsvComboView.Text = "ComboBox View";
            this.tabCsvComboView.UseVisualStyleBackColor = true;
            // 
            // cbNames
            // 
            this.cbNames.FormattingEnabled = true;
            this.cbNames.Location = new System.Drawing.Point(19, 18);
            this.cbNames.MaxDropDownItems = 100;
            this.cbNames.Name = "cbNames";
            this.cbNames.Size = new System.Drawing.Size(189, 21);
            this.cbNames.TabIndex = 2;
            this.cbNames.Text = "Name";
            // 
            // btnCbNameId
            // 
            this.btnCbNameId.Location = new System.Drawing.Point(225, 18);
            this.btnCbNameId.Name = "btnCbNameId";
            this.btnCbNameId.Size = new System.Drawing.Size(65, 23);
            this.btnCbNameId.TabIndex = 1;
            this.btnCbNameId.Text = "Id";
            this.btnCbNameId.UseVisualStyleBackColor = true;
            this.btnCbNameId.Click += new System.EventHandler(this.btnCbNameId_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CsvComboBoxView);
            this.Controls.Add(this.txtCsvFile);
            this.Controls.Add(this.chkIncludesColumnHeaders);
            this.Controls.Add(this.btnChooseCsv);
            this.Name = "MainForm";
            this.Text = "Csv Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.gridCsvData)).EndInit();
            this.CsvComboBoxView.ResumeLayout(false);
            this.tabCsvGridView.ResumeLayout(false);
            this.tabCsvComboView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseCsv;
        private System.Windows.Forms.TextBox txtCsvFile;
        private System.Windows.Forms.CheckBox chkIncludesColumnHeaders;
        private System.Windows.Forms.DataGridView gridCsvData;
        private System.Windows.Forms.TabControl CsvComboBoxView;
        private System.Windows.Forms.TabPage tabCsvGridView;
        private System.Windows.Forms.TabPage tabCsvComboView;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.Button btnCbNameId;
        private System.Windows.Forms.ComboBox cbNames;
    }
}

