
namespace AccFileParserUI
{
    partial class SoAUncertaintyForm
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
            this.openSoAFile = new System.Windows.Forms.Button();
            this.guideLabel = new System.Windows.Forms.Label();
            this.TaxonomyBoxLabel = new System.Windows.Forms.Label();
            this.taxonListBox = new System.Windows.Forms.ListBox();
            this.techniqueBoxLabel = new System.Windows.Forms.Label();
            this.techniqueListBox = new System.Windows.Forms.ListBox();
            this.taxonGroupBox = new System.Windows.Forms.GroupBox();
            this.paramDataGridLabel = new System.Windows.Forms.Label();
            this.taxonParamDataGrid = new System.Windows.Forms.DataGridView();
            this.paramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.required = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxonDefinition = new System.Windows.Forms.TextBox();
            this.taxonName = new System.Windows.Forms.Label();
            this.techniqueGroupBox = new System.Windows.Forms.GroupBox();
            this.techniqueParamDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techniqueParamLabel = new System.Windows.Forms.Label();
            this.expression = new System.Windows.Forms.TextBox();
            this.functionName = new System.Windows.Forms.Label();
            this.techniqueName = new System.Windows.Forms.Label();
            this.rangesDataGrid = new System.Windows.Forms.DataGridView();
            this.filterButton = new System.Windows.Forms.Button();
            this.filtersPanel = new System.Windows.Forms.Panel();
            this.labelFilteredRanges = new System.Windows.Forms.Label();
            this.taxonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxonParamDataGrid)).BeginInit();
            this.techniqueGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueParamDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // openSoAFile
            // 
            this.openSoAFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openSoAFile.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.openSoAFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openSoAFile.ForeColor = System.Drawing.SystemColors.Info;
            this.openSoAFile.Location = new System.Drawing.Point(12, 6);
            this.openSoAFile.Name = "openSoAFile";
            this.openSoAFile.Size = new System.Drawing.Size(147, 37);
            this.openSoAFile.TabIndex = 1;
            this.openSoAFile.Text = "Open SoA File";
            this.openSoAFile.UseVisualStyleBackColor = false;
            this.openSoAFile.Click += new System.EventHandler(this.openSoAFile_Click);
            // 
            // guideLabel
            // 
            this.guideLabel.AutoSize = true;
            this.guideLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guideLabel.Location = new System.Drawing.Point(194, 16);
            this.guideLabel.Name = "guideLabel";
            this.guideLabel.Size = new System.Drawing.Size(214, 17);
            this.guideLabel.TabIndex = 11;
            this.guideLabel.Text = "Select a file to load the content...";
            // 
            // TaxonomyBoxLabel
            // 
            this.TaxonomyBoxLabel.AutoSize = true;
            this.TaxonomyBoxLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TaxonomyBoxLabel.Location = new System.Drawing.Point(12, 48);
            this.TaxonomyBoxLabel.Name = "TaxonomyBoxLabel";
            this.TaxonomyBoxLabel.Size = new System.Drawing.Size(76, 17);
            this.TaxonomyBoxLabel.TabIndex = 12;
            this.TaxonomyBoxLabel.Text = "Taxonomy:";
            // 
            // taxonListBox
            // 
            this.taxonListBox.FormattingEnabled = true;
            this.taxonListBox.HorizontalScrollbar = true;
            this.taxonListBox.ItemHeight = 15;
            this.taxonListBox.Location = new System.Drawing.Point(13, 68);
            this.taxonListBox.Name = "taxonListBox";
            this.taxonListBox.Size = new System.Drawing.Size(146, 229);
            this.taxonListBox.TabIndex = 13;
            this.taxonListBox.SelectedValueChanged += new System.EventHandler(this.taxonListBox_SelectedValueChanged);
            // 
            // techniqueBoxLabel
            // 
            this.techniqueBoxLabel.AutoSize = true;
            this.techniqueBoxLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.techniqueBoxLabel.Location = new System.Drawing.Point(12, 305);
            this.techniqueBoxLabel.Name = "techniqueBoxLabel";
            this.techniqueBoxLabel.Size = new System.Drawing.Size(77, 17);
            this.techniqueBoxLabel.TabIndex = 14;
            this.techniqueBoxLabel.Text = "Techniques";
            // 
            // techniqueListBox
            // 
            this.techniqueListBox.FormattingEnabled = true;
            this.techniqueListBox.HorizontalScrollbar = true;
            this.techniqueListBox.ItemHeight = 15;
            this.techniqueListBox.Location = new System.Drawing.Point(13, 325);
            this.techniqueListBox.Name = "techniqueListBox";
            this.techniqueListBox.Size = new System.Drawing.Size(146, 229);
            this.techniqueListBox.TabIndex = 15;
            this.techniqueListBox.SelectedValueChanged += new System.EventHandler(this.techniqueListBox_SelectedValueChanged);
            // 
            // taxonGroupBox
            // 
            this.taxonGroupBox.Controls.Add(this.paramDataGridLabel);
            this.taxonGroupBox.Controls.Add(this.taxonParamDataGrid);
            this.taxonGroupBox.Controls.Add(this.taxonDefinition);
            this.taxonGroupBox.Controls.Add(this.taxonName);
            this.taxonGroupBox.Location = new System.Drawing.Point(194, 68);
            this.taxonGroupBox.Name = "taxonGroupBox";
            this.taxonGroupBox.Size = new System.Drawing.Size(364, 229);
            this.taxonGroupBox.TabIndex = 16;
            this.taxonGroupBox.TabStop = false;
            this.taxonGroupBox.Text = "Taxon Information";
            // 
            // paramDataGridLabel
            // 
            this.paramDataGridLabel.AutoSize = true;
            this.paramDataGridLabel.Location = new System.Drawing.Point(6, 105);
            this.paramDataGridLabel.Name = "paramDataGridLabel";
            this.paramDataGridLabel.Size = new System.Drawing.Size(66, 15);
            this.paramDataGridLabel.TabIndex = 3;
            this.paramDataGridLabel.Text = "Parameters";
            // 
            // taxonParamDataGrid
            // 
            this.taxonParamDataGrid.AllowUserToAddRows = false;
            this.taxonParamDataGrid.AllowUserToDeleteRows = false;
            this.taxonParamDataGrid.AllowUserToResizeColumns = false;
            this.taxonParamDataGrid.AllowUserToResizeRows = false;
            this.taxonParamDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taxonParamDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taxonParamDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.taxonParamDataGrid.CausesValidation = false;
            this.taxonParamDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.taxonParamDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taxonParamDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paramName,
            this.required,
            this.quantity});
            this.taxonParamDataGrid.Location = new System.Drawing.Point(0, 123);
            this.taxonParamDataGrid.Name = "taxonParamDataGrid";
            this.taxonParamDataGrid.ReadOnly = true;
            this.taxonParamDataGrid.RowHeadersVisible = false;
            this.taxonParamDataGrid.RowTemplate.Height = 25;
            this.taxonParamDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taxonParamDataGrid.Size = new System.Drawing.Size(364, 106);
            this.taxonParamDataGrid.TabIndex = 2;
            // 
            // paramName
            // 
            this.paramName.DataPropertyName = "Name";
            this.paramName.HeaderText = "Name";
            this.paramName.Name = "paramName";
            this.paramName.ReadOnly = true;
            // 
            // required
            // 
            this.required.DataPropertyName = "Required";
            this.required.HeaderText = "Required";
            this.required.Name = "required";
            this.required.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "Quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // taxonDefinition
            // 
            this.taxonDefinition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taxonDefinition.Location = new System.Drawing.Point(8, 46);
            this.taxonDefinition.Multiline = true;
            this.taxonDefinition.Name = "taxonDefinition";
            this.taxonDefinition.ReadOnly = true;
            this.taxonDefinition.Size = new System.Drawing.Size(350, 56);
            this.taxonDefinition.TabIndex = 1;
            this.taxonDefinition.Text = "taxonDefinition";
            // 
            // taxonName
            // 
            this.taxonName.AutoSize = true;
            this.taxonName.Location = new System.Drawing.Point(6, 19);
            this.taxonName.Name = "taxonName";
            this.taxonName.Size = new System.Drawing.Size(69, 15);
            this.taxonName.TabIndex = 0;
            this.taxonName.Text = "taxonName";
            // 
            // techniqueGroupBox
            // 
            this.techniqueGroupBox.Controls.Add(this.techniqueParamDataGrid);
            this.techniqueGroupBox.Controls.Add(this.techniqueParamLabel);
            this.techniqueGroupBox.Controls.Add(this.expression);
            this.techniqueGroupBox.Controls.Add(this.functionName);
            this.techniqueGroupBox.Controls.Add(this.techniqueName);
            this.techniqueGroupBox.Location = new System.Drawing.Point(574, 68);
            this.techniqueGroupBox.Name = "techniqueGroupBox";
            this.techniqueGroupBox.Size = new System.Drawing.Size(364, 229);
            this.techniqueGroupBox.TabIndex = 17;
            this.techniqueGroupBox.TabStop = false;
            this.techniqueGroupBox.Text = "Technique Information";
            // 
            // techniqueParamDataGrid
            // 
            this.techniqueParamDataGrid.AllowUserToAddRows = false;
            this.techniqueParamDataGrid.AllowUserToDeleteRows = false;
            this.techniqueParamDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.techniqueParamDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.techniqueParamDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.type,
            this.range,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.techniqueParamDataGrid.Location = new System.Drawing.Point(0, 123);
            this.techniqueParamDataGrid.Name = "techniqueParamDataGrid";
            this.techniqueParamDataGrid.ReadOnly = true;
            this.techniqueParamDataGrid.RowHeadersVisible = false;
            this.techniqueParamDataGrid.RowTemplate.Height = 25;
            this.techniqueParamDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.techniqueParamDataGrid.Size = new System.Drawing.Size(364, 106);
            this.techniqueParamDataGrid.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "Type";
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // range
            // 
            this.range.DataPropertyName = "Range";
            this.range.HeaderText = "Range";
            this.range.Name = "range";
            this.range.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Required";
            this.dataGridViewTextBoxColumn2.HeaderText = "Required";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // techniqueParamLabel
            // 
            this.techniqueParamLabel.AutoSize = true;
            this.techniqueParamLabel.Location = new System.Drawing.Point(6, 105);
            this.techniqueParamLabel.Name = "techniqueParamLabel";
            this.techniqueParamLabel.Size = new System.Drawing.Size(66, 15);
            this.techniqueParamLabel.TabIndex = 3;
            this.techniqueParamLabel.Text = "Parameters";
            // 
            // expression
            // 
            this.expression.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expression.Location = new System.Drawing.Point(6, 64);
            this.expression.Multiline = true;
            this.expression.Name = "expression";
            this.expression.ReadOnly = true;
            this.expression.Size = new System.Drawing.Size(352, 38);
            this.expression.TabIndex = 2;
            this.expression.Text = "expression";
            // 
            // functionName
            // 
            this.functionName.AutoSize = true;
            this.functionName.Location = new System.Drawing.Point(6, 46);
            this.functionName.Name = "functionName";
            this.functionName.Size = new System.Drawing.Size(84, 15);
            this.functionName.TabIndex = 1;
            this.functionName.Text = "functionName";
            // 
            // techniqueName
            // 
            this.techniqueName.AutoSize = true;
            this.techniqueName.Location = new System.Drawing.Point(6, 19);
            this.techniqueName.Name = "techniqueName";
            this.techniqueName.Size = new System.Drawing.Size(92, 15);
            this.techniqueName.TabIndex = 0;
            this.techniqueName.Text = "techniqueName";
            // 
            // rangesDataGrid
            // 
            this.rangesDataGrid.AllowUserToAddRows = false;
            this.rangesDataGrid.AllowUserToDeleteRows = false;
            this.rangesDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.rangesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rangesDataGrid.Location = new System.Drawing.Point(194, 325);
            this.rangesDataGrid.Name = "rangesDataGrid";
            this.rangesDataGrid.ReadOnly = true;
            this.rangesDataGrid.RowHeadersVisible = false;
            this.rangesDataGrid.RowTemplate.Height = 25;
            this.rangesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rangesDataGrid.Size = new System.Drawing.Size(744, 229);
            this.rangesDataGrid.TabIndex = 18;
            // 
            // filterButton
            // 
            this.filterButton.AllowDrop = true;
            this.filterButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.filterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filterButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.filterButton.Location = new System.Drawing.Point(13, 585);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(146, 37);
            this.filterButton.TabIndex = 19;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // filtersPanel
            // 
            this.filtersPanel.AutoScroll = true;
            this.filtersPanel.Location = new System.Drawing.Point(194, 569);
            this.filtersPanel.Name = "filtersPanel";
            this.filtersPanel.Size = new System.Drawing.Size(744, 69);
            this.filtersPanel.TabIndex = 20;
            // 
            // labelFilteredRanges
            // 
            this.labelFilteredRanges.AutoSize = true;
            this.labelFilteredRanges.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFilteredRanges.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelFilteredRanges.Location = new System.Drawing.Point(194, 305);
            this.labelFilteredRanges.Name = "labelFilteredRanges";
            this.labelFilteredRanges.Size = new System.Drawing.Size(55, 17);
            this.labelFilteredRanges.TabIndex = 21;
            this.labelFilteredRanges.Text = "Ranges:";
            // 
            // SoAUncertaintyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.labelFilteredRanges);
            this.Controls.Add(this.filtersPanel);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.rangesDataGrid);
            this.Controls.Add(this.techniqueGroupBox);
            this.Controls.Add(this.taxonGroupBox);
            this.Controls.Add(this.techniqueListBox);
            this.Controls.Add(this.techniqueBoxLabel);
            this.Controls.Add(this.taxonListBox);
            this.Controls.Add(this.TaxonomyBoxLabel);
            this.Controls.Add(this.guideLabel);
            this.Controls.Add(this.openSoAFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoAUncertaintyForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SoAUncertaintyForm";
            this.taxonGroupBox.ResumeLayout(false);
            this.taxonGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxonParamDataGrid)).EndInit();
            this.techniqueGroupBox.ResumeLayout(false);
            this.techniqueGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techniqueParamDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openSoAFile;
        private System.Windows.Forms.Label guideLabel;
        private System.Windows.Forms.Label TaxonomyBoxLabel;
        private System.Windows.Forms.ListBox taxonListBox;
        private System.Windows.Forms.Label techniqueBoxLabel;
        private System.Windows.Forms.ListBox techniqueListBox;
        private System.Windows.Forms.GroupBox taxonGroupBox;
        private System.Windows.Forms.GroupBox techniqueGroupBox;
        private System.Windows.Forms.DataGridView taxonParamDataGrid;
        private System.Windows.Forms.TextBox taxonDefinition;
        private System.Windows.Forms.Label taxonName;
        private System.Windows.Forms.Label paramDataGridLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramName;
        private System.Windows.Forms.DataGridViewTextBoxColumn required;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridView techniqueParamDataGrid;
        private System.Windows.Forms.Label techniqueParamLabel;
        private System.Windows.Forms.TextBox expression;
        private System.Windows.Forms.Label functionName;
        private System.Windows.Forms.Label techniqueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn range;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView rangesDataGrid;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Panel filtersPanel;
        private System.Windows.Forms.Label labelFilteredRanges;
    }
}