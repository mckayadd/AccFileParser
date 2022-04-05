namespace AccFileParserUI
{
    partial class SoaEvaluateForm
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
            this.resultsDataGrid = new System.Windows.Forms.DataGridView();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.inputsPanel = new System.Windows.Forms.Panel();
            this.evaluateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).BeginInit();
            this.SuspendLayout();
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
            this.resultsDataGrid.Size = new System.Drawing.Size(926, 399);
            this.resultsDataGrid.TabIndex = 29;
            // 
            // dividerLabel
            // 
            this.dividerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dividerLabel.Location = new System.Drawing.Point(12, 145);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(926, 2);
            this.dividerLabel.TabIndex = 28;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResults.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelResults.Location = new System.Drawing.Point(12, 179);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(51, 17);
            this.labelResults.TabIndex = 27;
            this.labelResults.Text = "Results";
            // 
            // inputsPanel
            // 
            this.inputsPanel.Location = new System.Drawing.Point(12, 12);
            this.inputsPanel.Name = "inputsPanel";
            this.inputsPanel.Size = new System.Drawing.Size(926, 123);
            this.inputsPanel.TabIndex = 26;
            // 
            // evaluateButton
            // 
            this.evaluateButton.Location = new System.Drawing.Point(12, 150);
            this.evaluateButton.Name = "evaluateButton";
            this.evaluateButton.Size = new System.Drawing.Size(75, 23);
            this.evaluateButton.TabIndex = 25;
            this.evaluateButton.Text = "Evaluate";
            this.evaluateButton.UseVisualStyleBackColor = true;
            this.evaluateButton.Click += new System.EventHandler(this.evaluateButton_Click);
            // 
            // SoaEvaluateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 610);
            this.Controls.Add(this.resultsDataGrid);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.inputsPanel);
            this.Controls.Add(this.evaluateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoaEvaluateForm";
            this.Text = "SoaEvaluateForm";
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView resultsDataGrid;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Panel inputsPanel;
        private System.Windows.Forms.Button evaluateButton;
    }
}