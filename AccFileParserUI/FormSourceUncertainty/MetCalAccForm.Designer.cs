
namespace AccFileParserUI
{
    partial class MetCalAccForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetCalAccForm));
            this.openAccFileButton = new System.Windows.Forms.Button();
            this.modeListBox = new System.Windows.Forms.ListBox();
            this.modeListBoxLabel = new System.Windows.Forms.Label();
            this.selectedModeLabel = new System.Windows.Forms.Label();
            this.buttonModeListSort = new System.Windows.Forms.Button();
            this.modeLabel = new System.Windows.Forms.Label();
            this.nominalLabel = new System.Windows.Forms.Label();
            this.mod1Label = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.textBoxMod1 = new System.Windows.Forms.TextBox();
            this.textBoxNominal = new System.Windows.Forms.TextBox();
            this.dataGridViewSelectedRanges = new System.Windows.Forms.DataGridView();
            this.nominalLower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominalUpper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mod1Lower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mod1Upper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tolerance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileContentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.guideLabel = new System.Windows.Forms.Label();
            this.labelFilteredRanges = new System.Windows.Forms.Label();
            this.dataGridViewFilteredRanges = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedRanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilteredRanges)).BeginInit();
            this.SuspendLayout();
            // 
            // openAccFileButton
            // 
            this.openAccFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openAccFileButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.openAccFileButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openAccFileButton.ForeColor = System.Drawing.SystemColors.Info;
            this.openAccFileButton.Location = new System.Drawing.Point(12, 6);
            this.openAccFileButton.Name = "openAccFileButton";
            this.openAccFileButton.Size = new System.Drawing.Size(147, 37);
            this.openAccFileButton.TabIndex = 0;
            this.openAccFileButton.Text = "Open Acc File";
            this.openAccFileButton.UseVisualStyleBackColor = false;
            this.openAccFileButton.Click += new System.EventHandler(this.openAccFileButton_Click);
            // 
            // modeListBox
            // 
            this.modeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modeListBox.FormattingEnabled = true;
            this.modeListBox.ItemHeight = 15;
            this.modeListBox.Location = new System.Drawing.Point(13, 68);
            this.modeListBox.Name = "modeListBox";
            this.modeListBox.Size = new System.Drawing.Size(146, 349);
            this.modeListBox.TabIndex = 2;
            this.modeListBox.SelectedValueChanged += new System.EventHandler(this.modeListBox_SelectedValueChanged);
            // 
            // modeListBoxLabel
            // 
            this.modeListBoxLabel.AutoSize = true;
            this.modeListBoxLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modeListBoxLabel.Location = new System.Drawing.Point(12, 48);
            this.modeListBoxLabel.Name = "modeListBoxLabel";
            this.modeListBoxLabel.Size = new System.Drawing.Size(73, 17);
            this.modeListBoxLabel.TabIndex = 4;
            this.modeListBoxLabel.Text = "Mode List:";
            // 
            // selectedModeLabel
            // 
            this.selectedModeLabel.AutoSize = true;
            this.selectedModeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedModeLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.selectedModeLabel.Location = new System.Drawing.Point(253, 231);
            this.selectedModeLabel.Name = "selectedModeLabel";
            this.selectedModeLabel.Size = new System.Drawing.Size(97, 17);
            this.selectedModeLabel.TabIndex = 5;
            this.selectedModeLabel.Text = "Selected Mode";
            // 
            // buttonModeListSort
            // 
            this.buttonModeListSort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModeListSort.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonModeListSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonModeListSort.Image = ((System.Drawing.Image)(resources.GetObject("buttonModeListSort.Image")));
            this.buttonModeListSort.Location = new System.Drawing.Point(161, 68);
            this.buttonModeListSort.Name = "buttonModeListSort";
            this.buttonModeListSort.Size = new System.Drawing.Size(27, 33);
            this.buttonModeListSort.TabIndex = 7;
            this.buttonModeListSort.UseVisualStyleBackColor = false;
            this.buttonModeListSort.Click += new System.EventHandler(this.buttonModeListSort_Click);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modeLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.modeLabel.Location = new System.Drawing.Point(201, 231);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(46, 17);
            this.modeLabel.TabIndex = 8;
            this.modeLabel.Text = "Mode:";
            // 
            // nominalLabel
            // 
            this.nominalLabel.AutoSize = true;
            this.nominalLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nominalLabel.Location = new System.Drawing.Point(12, 452);
            this.nominalLabel.Name = "nominalLabel";
            this.nominalLabel.Size = new System.Drawing.Size(65, 17);
            this.nominalLabel.TabIndex = 13;
            this.nominalLabel.Text = "Nominal:";
            // 
            // mod1Label
            // 
            this.mod1Label.AutoSize = true;
            this.mod1Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mod1Label.Location = new System.Drawing.Point(13, 502);
            this.mod1Label.Name = "mod1Label";
            this.mod1Label.Size = new System.Drawing.Size(47, 17);
            this.mod1Label.TabIndex = 14;
            this.mod1Label.Text = "Mod1:";
            // 
            // buttonFilter
            // 
            this.buttonFilter.AllowDrop = true;
            this.buttonFilter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFilter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonFilter.Location = new System.Drawing.Point(12, 561);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(146, 37);
            this.buttonFilter.TabIndex = 17;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // textBoxMod1
            // 
            this.textBoxMod1.Location = new System.Drawing.Point(12, 522);
            this.textBoxMod1.Name = "textBoxMod1";
            this.textBoxMod1.Size = new System.Drawing.Size(146, 23);
            this.textBoxMod1.TabIndex = 16;
            // 
            // textBoxNominal
            // 
            this.textBoxNominal.Location = new System.Drawing.Point(12, 472);
            this.textBoxNominal.Name = "textBoxNominal";
            this.textBoxNominal.Size = new System.Drawing.Size(146, 23);
            this.textBoxNominal.TabIndex = 15;
            // 
            // dataGridViewSelectedRanges
            // 
            this.dataGridViewSelectedRanges.AllowUserToAddRows = false;
            this.dataGridViewSelectedRanges.AllowUserToDeleteRows = false;
            this.dataGridViewSelectedRanges.AllowUserToResizeColumns = false;
            this.dataGridViewSelectedRanges.AllowUserToResizeRows = false;
            this.dataGridViewSelectedRanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSelectedRanges.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSelectedRanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedRanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nominalLower,
            this.nominalUpper,
            this.mod1Lower,
            this.mod1Upper,
            this.tolerance,
            this.floor,
            this.resolution});
            this.dataGridViewSelectedRanges.Location = new System.Drawing.Point(198, 252);
            this.dataGridViewSelectedRanges.MultiSelect = false;
            this.dataGridViewSelectedRanges.Name = "dataGridViewSelectedRanges";
            this.dataGridViewSelectedRanges.ReadOnly = true;
            this.dataGridViewSelectedRanges.RowHeadersVisible = false;
            this.dataGridViewSelectedRanges.RowTemplate.Height = 25;
            this.dataGridViewSelectedRanges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSelectedRanges.Size = new System.Drawing.Size(740, 160);
            this.dataGridViewSelectedRanges.TabIndex = 16;
            this.dataGridViewSelectedRanges.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.rangesDataGridView_RowStateChanged);
            // 
            // nominalLower
            // 
            this.nominalLower.HeaderText = "Nominal - Lower";
            this.nominalLower.Name = "nominalLower";
            this.nominalLower.ReadOnly = true;
            this.nominalLower.Width = 120;
            // 
            // nominalUpper
            // 
            this.nominalUpper.HeaderText = "Nominal - Upper";
            this.nominalUpper.Name = "nominalUpper";
            this.nominalUpper.ReadOnly = true;
            this.nominalUpper.Width = 120;
            // 
            // mod1Lower
            // 
            this.mod1Lower.HeaderText = "Mod1 - Lower";
            this.mod1Lower.Name = "mod1Lower";
            this.mod1Lower.ReadOnly = true;
            this.mod1Lower.Width = 110;
            // 
            // mod1Upper
            // 
            this.mod1Upper.HeaderText = "Mod1 - Upper";
            this.mod1Upper.Name = "mod1Upper";
            this.mod1Upper.ReadOnly = true;
            this.mod1Upper.Width = 110;
            // 
            // tolerance
            // 
            this.tolerance.HeaderText = "Tolerance";
            this.tolerance.Name = "tolerance";
            this.tolerance.ReadOnly = true;
            this.tolerance.Width = 80;
            // 
            // floor
            // 
            this.floor.HeaderText = "Floor";
            this.floor.Name = "floor";
            this.floor.ReadOnly = true;
            this.floor.Width = 80;
            // 
            // resolution
            // 
            this.resolution.HeaderText = "Resolution";
            this.resolution.Name = "resolution";
            this.resolution.ReadOnly = true;
            this.resolution.Width = 80;
            // 
            // fileContentRichTextBox
            // 
            this.fileContentRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileContentRichTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fileContentRichTextBox.Location = new System.Drawing.Point(198, 68);
            this.fileContentRichTextBox.Name = "fileContentRichTextBox";
            this.fileContentRichTextBox.Size = new System.Drawing.Size(740, 160);
            this.fileContentRichTextBox.TabIndex = 17;
            this.fileContentRichTextBox.Text = "";
            // 
            // guideLabel
            // 
            this.guideLabel.AutoSize = true;
            this.guideLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guideLabel.Location = new System.Drawing.Point(198, 48);
            this.guideLabel.Name = "guideLabel";
            this.guideLabel.Size = new System.Drawing.Size(214, 17);
            this.guideLabel.TabIndex = 10;
            this.guideLabel.Text = "Select a file to load the content...";
            // 
            // labelFilteredRanges
            // 
            this.labelFilteredRanges.AutoSize = true;
            this.labelFilteredRanges.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFilteredRanges.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelFilteredRanges.Location = new System.Drawing.Point(201, 418);
            this.labelFilteredRanges.Name = "labelFilteredRanges";
            this.labelFilteredRanges.Size = new System.Drawing.Size(104, 17);
            this.labelFilteredRanges.TabIndex = 19;
            this.labelFilteredRanges.Text = "Filtered Ranges:";
            // 
            // dataGridViewFilteredRanges
            // 
            this.dataGridViewFilteredRanges.AllowUserToAddRows = false;
            this.dataGridViewFilteredRanges.AllowUserToDeleteRows = false;
            this.dataGridViewFilteredRanges.AllowUserToResizeColumns = false;
            this.dataGridViewFilteredRanges.AllowUserToResizeRows = false;
            this.dataGridViewFilteredRanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFilteredRanges.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewFilteredRanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilteredRanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridViewFilteredRanges.Location = new System.Drawing.Point(201, 438);
            this.dataGridViewFilteredRanges.MultiSelect = false;
            this.dataGridViewFilteredRanges.Name = "dataGridViewFilteredRanges";
            this.dataGridViewFilteredRanges.ReadOnly = true;
            this.dataGridViewFilteredRanges.RowHeadersVisible = false;
            this.dataGridViewFilteredRanges.RowTemplate.Height = 25;
            this.dataGridViewFilteredRanges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFilteredRanges.Size = new System.Drawing.Size(740, 160);
            this.dataGridViewFilteredRanges.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nominal - Lower";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nominal - Upper";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Mod1 - Lower";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Mod1 - Upper";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tolerance";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Floor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Resolution";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // MetCalAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 610);
            this.Controls.Add(this.dataGridViewFilteredRanges);
            this.Controls.Add(this.labelFilteredRanges);
            this.Controls.Add(this.nominalLabel);
            this.Controls.Add(this.textBoxNominal);
            this.Controls.Add(this.textBoxMod1);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.mod1Label);
            this.Controls.Add(this.fileContentRichTextBox);
            this.Controls.Add(this.dataGridViewSelectedRanges);
            this.Controls.Add(this.guideLabel);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.buttonModeListSort);
            this.Controls.Add(this.selectedModeLabel);
            this.Controls.Add(this.modeListBoxLabel);
            this.Controls.Add(this.modeListBox);
            this.Controls.Add(this.openAccFileButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MetCalAccForm";
            this.Text = "Accuracy File Handler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedRanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilteredRanges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openAccFileButton;
        private System.Windows.Forms.ListBox modeListBox;
        private System.Windows.Forms.Label modeListBoxLabel;
        private System.Windows.Forms.Label selectedModeLabel;
        private System.Windows.Forms.Button buttonModeListSort;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label nominalLabel;
        private System.Windows.Forms.Label mod1Label;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.TextBox textBoxMod1;
        private System.Windows.Forms.TextBox textBoxNominal;
        private System.Windows.Forms.DataGridView dataGridViewSelectedRanges;
        private System.Windows.Forms.RichTextBox fileContentRichTextBox;
        private System.Windows.Forms.Label guideLabel;
        private System.Windows.Forms.Label labelFilteredRanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominalLower;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominalUpper;
        private System.Windows.Forms.DataGridViewTextBoxColumn mod1Lower;
        private System.Windows.Forms.DataGridViewTextBoxColumn mod1Upper;
        private System.Windows.Forms.DataGridViewTextBoxColumn tolerance;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolution;
        private System.Windows.Forms.DataGridView dataGridViewFilteredRanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

