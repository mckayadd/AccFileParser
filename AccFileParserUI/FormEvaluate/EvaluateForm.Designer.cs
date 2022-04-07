
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
            this.panelTopSUF = new System.Windows.Forms.Panel();
            this.buttonPtbDcc = new System.Windows.Forms.Button();
            this.buttonMetrologyNetEvaluate = new System.Windows.Forms.Button();
            this.buttonSoAEvaluate = new System.Windows.Forms.Button();
            this.panelMainEval = new System.Windows.Forms.Panel();
            this.panelTopSUF.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopSUF
            // 
            this.panelTopSUF.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelTopSUF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTopSUF.Controls.Add(this.buttonPtbDcc);
            this.panelTopSUF.Controls.Add(this.buttonMetrologyNetEvaluate);
            this.panelTopSUF.Controls.Add(this.buttonSoAEvaluate);
            this.panelTopSUF.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSUF.Location = new System.Drawing.Point(0, 0);
            this.panelTopSUF.Name = "panelTopSUF";
            this.panelTopSUF.Size = new System.Drawing.Size(950, 40);
            this.panelTopSUF.TabIndex = 1;
            // 
            // buttonPtbDcc
            // 
            this.buttonPtbDcc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPtbDcc.FlatAppearance.BorderSize = 0;
            this.buttonPtbDcc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPtbDcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPtbDcc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPtbDcc.ForeColor = System.Drawing.Color.White;
            this.buttonPtbDcc.Location = new System.Drawing.Point(299, 2);
            this.buttonPtbDcc.Name = "buttonPtbDcc";
            this.buttonPtbDcc.Size = new System.Drawing.Size(122, 30);
            this.buttonPtbDcc.TabIndex = 5;
            this.buttonPtbDcc.Text = "PTB DCC Evaluate";
            this.buttonPtbDcc.UseVisualStyleBackColor = false;
            this.buttonPtbDcc.Click += new System.EventHandler(this.buttonPtbDcc_Click);
            // 
            // buttonMetrologyNetEvaluate
            // 
            this.buttonMetrologyNetEvaluate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonMetrologyNetEvaluate.FlatAppearance.BorderSize = 0;
            this.buttonMetrologyNetEvaluate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonMetrologyNetEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMetrologyNetEvaluate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMetrologyNetEvaluate.ForeColor = System.Drawing.Color.White;
            this.buttonMetrologyNetEvaluate.Location = new System.Drawing.Point(140, 3);
            this.buttonMetrologyNetEvaluate.Name = "buttonMetrologyNetEvaluate";
            this.buttonMetrologyNetEvaluate.Size = new System.Drawing.Size(153, 30);
            this.buttonMetrologyNetEvaluate.TabIndex = 4;
            this.buttonMetrologyNetEvaluate.Text = "Metrology.Net Evaluate";
            this.buttonMetrologyNetEvaluate.UseVisualStyleBackColor = false;
            this.buttonMetrologyNetEvaluate.Click += new System.EventHandler(this.buttonMetrologyNetEvaluate_Click);
            // 
            // buttonSoAEvaluate
            // 
            this.buttonSoAEvaluate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSoAEvaluate.FlatAppearance.BorderSize = 0;
            this.buttonSoAEvaluate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSoAEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoAEvaluate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSoAEvaluate.ForeColor = System.Drawing.Color.White;
            this.buttonSoAEvaluate.Location = new System.Drawing.Point(3, 3);
            this.buttonSoAEvaluate.Name = "buttonSoAEvaluate";
            this.buttonSoAEvaluate.Size = new System.Drawing.Size(138, 30);
            this.buttonSoAEvaluate.TabIndex = 3;
            this.buttonSoAEvaluate.Text = "MET/CAL Evaluate";
            this.buttonSoAEvaluate.UseVisualStyleBackColor = false;
            this.buttonSoAEvaluate.Click += new System.EventHandler(this.buttonSoAEvaluate_Click);
            // 
            // panelMainEval
            // 
            this.panelMainEval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainEval.Location = new System.Drawing.Point(0, 40);
            this.panelMainEval.Name = "panelMainEval";
            this.panelMainEval.Size = new System.Drawing.Size(950, 610);
            this.panelMainEval.TabIndex = 2;
            // 
            // EvaluateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.panelMainEval);
            this.Controls.Add(this.panelTopSUF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EvaluateForm";
            this.Text = "EvaluateForm";
            this.panelTopSUF.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSUF;
        private System.Windows.Forms.Button buttonMetrologyNetEvaluate;
        private System.Windows.Forms.Button buttonSoAEvaluate;
        private System.Windows.Forms.Panel panelMainEval;
        private System.Windows.Forms.Button buttonPtbDcc;
    }
}