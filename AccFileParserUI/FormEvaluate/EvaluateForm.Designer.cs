
namespace AccFileParserUI
{
    partial class EvaluateForm
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
            this.evaluateButton = new System.Windows.Forms.Button();
            this.inputsPanel = new System.Windows.Forms.Panel();
            this.labelResults = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.resultsDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewSourceUnc = new System.Windows.Forms.DataGridView();
            this.voltage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soaRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soaUncertainty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceUncertainty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSourceUnc)).BeginInit();
            this.SuspendLayout();
            // 
            // evaluateButton
            // 
            this.evaluateButton.Location = new System.Drawing.Point(12, 150);
            this.evaluateButton.Name = "evaluateButton";
            this.evaluateButton.Size = new System.Drawing.Size(75, 23);
            this.evaluateButton.TabIndex = 0;
            this.evaluateButton.Text = "Evaluate";
            this.evaluateButton.UseVisualStyleBackColor = true;
            this.evaluateButton.Click += new System.EventHandler(this.buttonEvaluate_Click);
            // 
            // inputsPanel
            // 
            this.inputsPanel.Controls.Add(this.dataGridViewSourceUnc);
            this.inputsPanel.Location = new System.Drawing.Point(12, 12);
            this.inputsPanel.Name = "inputsPanel";
            this.inputsPanel.Size = new System.Drawing.Size(926, 123);
            this.inputsPanel.TabIndex = 1;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResults.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelResults.Location = new System.Drawing.Point(12, 179);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(51, 17);
            this.labelResults.TabIndex = 22;
            this.labelResults.Text = "Results";
            // 
            // dividerLabel
            // 
            this.dividerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dividerLabel.Location = new System.Drawing.Point(12, 145);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(926, 2);
            this.dividerLabel.TabIndex = 23;
            // 
            // resultsDataGrid
            // 
            this.resultsDataGrid.AllowUserToAddRows = false;
            this.resultsDataGrid.AllowUserToDeleteRows = false;
            this.resultsDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.resultsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGrid.Location = new System.Drawing.Point(12, 199);
            this.resultsDataGrid.Name = "resultsDataGrid";
            this.resultsDataGrid.ReadOnly = true;
            this.resultsDataGrid.RowHeadersVisible = false;
            this.resultsDataGrid.RowTemplate.Height = 25;
            this.resultsDataGrid.Size = new System.Drawing.Size(926, 439);
            this.resultsDataGrid.TabIndex = 24;
            // 
            // dataGridViewSourceUnc
            // 
            this.dataGridViewSourceUnc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSourceUnc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voltage,
            this.soaRange,
            this.soaUncertainty,
            this.sourceRange,
            this.sourceUncertainty,
            this.evaluate});
            this.dataGridViewSourceUnc.Location = new System.Drawing.Point(3, 67);
            this.dataGridViewSourceUnc.Name = "dataGridViewSourceUnc";
            this.dataGridViewSourceUnc.RowTemplate.Height = 25;
            this.dataGridViewSourceUnc.Size = new System.Drawing.Size(920, 53);
            this.dataGridViewSourceUnc.TabIndex = 25;
            this.dataGridViewSourceUnc.Visible = false;
            // 
            // voltage
            // 
            this.voltage.HeaderText = "Voltage";
            this.voltage.Name = "voltage";
            this.voltage.Width = 120;
            // 
            // soaRange
            // 
            this.soaRange.HeaderText = "SoA Range";
            this.soaRange.Name = "soaRange";
            this.soaRange.Width = 120;
            // 
            // soaUncertainty
            // 
            this.soaUncertainty.HeaderText = "SoA Uncertainty";
            this.soaUncertainty.Name = "soaUncertainty";
            this.soaUncertainty.Width = 120;
            // 
            // sourceRange
            // 
            this.sourceRange.HeaderText = "Source Range";
            this.sourceRange.Name = "sourceRange";
            this.sourceRange.Width = 120;
            // 
            // sourceUncertainty
            // 
            this.sourceUncertainty.HeaderText = "Source Uncertainty";
            this.sourceUncertainty.Name = "sourceUncertainty";
            this.sourceUncertainty.Width = 140;
            // 
            // evaluate
            // 
            this.evaluate.HeaderText = "Evaluate";
            this.evaluate.Name = "evaluate";
            this.evaluate.Width = 120;
            // 
            // EvaluateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.resultsDataGrid);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.inputsPanel);
            this.Controls.Add(this.evaluateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EvaluateForm";
            this.Text = "EvaluateForm";
            this.inputsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSourceUnc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button evaluateButton;
        private System.Windows.Forms.Panel inputsPanel;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.DataGridView resultsDataGrid;
        private System.Windows.Forms.DataGridView dataGridViewSourceUnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltage;
        private System.Windows.Forms.DataGridViewTextBoxColumn soaRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn soaUncertainty;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceUncertainty;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluate;
    }
}