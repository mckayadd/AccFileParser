
namespace AccFileParserUI
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonEvaluate = new System.Windows.Forms.Button();
            this.buttonSoAUncertainty = new System.Windows.Forms.Button();
            this.buttonSourceUncertainty = new System.Windows.Forms.Button();
            this.buttonSelectTaxon = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTop.Controls.Add(this.buttonEvaluate);
            this.panelTop.Controls.Add(this.buttonSoAUncertainty);
            this.panelTop.Controls.Add(this.buttonSourceUncertainty);
            this.panelTop.Controls.Add(this.buttonSelectTaxon);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(950, 50);
            this.panelTop.TabIndex = 1;
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEvaluate.FlatAppearance.BorderSize = 0;
            this.buttonEvaluate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEvaluate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEvaluate.ForeColor = System.Drawing.Color.White;
            this.buttonEvaluate.Location = new System.Drawing.Point(408, 3);
            this.buttonEvaluate.Name = "buttonEvaluate";
            this.buttonEvaluate.Size = new System.Drawing.Size(86, 40);
            this.buttonEvaluate.TabIndex = 4;
            this.buttonEvaluate.Text = "Evaluate";
            this.buttonEvaluate.UseVisualStyleBackColor = false;
            this.buttonEvaluate.Click += new System.EventHandler(this.buttonEvaluate_Click);
            // 
            // buttonSoAUncertainty
            // 
            this.buttonSoAUncertainty.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSoAUncertainty.FlatAppearance.BorderSize = 0;
            this.buttonSoAUncertainty.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSoAUncertainty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoAUncertainty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSoAUncertainty.ForeColor = System.Drawing.Color.White;
            this.buttonSoAUncertainty.Location = new System.Drawing.Point(270, 2);
            this.buttonSoAUncertainty.Name = "buttonSoAUncertainty";
            this.buttonSoAUncertainty.Size = new System.Drawing.Size(132, 40);
            this.buttonSoAUncertainty.TabIndex = 3;
            this.buttonSoAUncertainty.Text = "SoA Uncertainty";
            this.buttonSoAUncertainty.UseVisualStyleBackColor = false;
            this.buttonSoAUncertainty.Click += new System.EventHandler(this.buttonSoAUncertainty_Click);
            // 
            // buttonSourceUncertainty
            // 
            this.buttonSourceUncertainty.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSourceUncertainty.FlatAppearance.BorderSize = 0;
            this.buttonSourceUncertainty.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSourceUncertainty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSourceUncertainty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSourceUncertainty.ForeColor = System.Drawing.Color.White;
            this.buttonSourceUncertainty.Location = new System.Drawing.Point(121, 3);
            this.buttonSourceUncertainty.Name = "buttonSourceUncertainty";
            this.buttonSourceUncertainty.Size = new System.Drawing.Size(143, 40);
            this.buttonSourceUncertainty.TabIndex = 2;
            this.buttonSourceUncertainty.Text = "Source Uncertainty";
            this.buttonSourceUncertainty.UseVisualStyleBackColor = false;
            this.buttonSourceUncertainty.Click += new System.EventHandler(this.buttonSourceUncertainty_Click);
            // 
            // buttonSelectTaxon
            // 
            this.buttonSelectTaxon.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSelectTaxon.FlatAppearance.BorderSize = 0;
            this.buttonSelectTaxon.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSelectTaxon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectTaxon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSelectTaxon.ForeColor = System.Drawing.Color.White;
            this.buttonSelectTaxon.Location = new System.Drawing.Point(10, 3);
            this.buttonSelectTaxon.Name = "buttonSelectTaxon";
            this.buttonSelectTaxon.Size = new System.Drawing.Size(105, 40);
            this.buttonSelectTaxon.TabIndex = 1;
            this.buttonSelectTaxon.Text = "Select Taxon";
            this.buttonSelectTaxon.UseVisualStyleBackColor = false;
            this.buttonSelectTaxon.Click += new System.EventHandler(this.buttonSelectTaxon_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(950, 650);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonSelectTaxon;
        private System.Windows.Forms.Button buttonEvaluate;
        private System.Windows.Forms.Button buttonSoAUncertainty;
        private System.Windows.Forms.Button buttonSourceUncertainty;
    }
}