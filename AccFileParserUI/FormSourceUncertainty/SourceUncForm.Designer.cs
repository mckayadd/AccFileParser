
namespace AccFileParserUI
{
    partial class SourceUncForm
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
            this.buttonMetCalAcc = new System.Windows.Forms.Button();
            this.panelMainSUF = new System.Windows.Forms.Panel();
            this.panelTopSUF.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopSUF
            // 
            this.panelTopSUF.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelTopSUF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTopSUF.Controls.Add(this.buttonPtbDcc);
            this.panelTopSUF.Controls.Add(this.buttonMetCalAcc);
            this.panelTopSUF.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSUF.Location = new System.Drawing.Point(0, 0);
            this.panelTopSUF.Name = "panelTopSUF";
            this.panelTopSUF.Size = new System.Drawing.Size(950, 40);
            this.panelTopSUF.TabIndex = 0;
            // 
            // buttonPtbDcc
            // 
            this.buttonPtbDcc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPtbDcc.FlatAppearance.BorderSize = 0;
            this.buttonPtbDcc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPtbDcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPtbDcc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPtbDcc.ForeColor = System.Drawing.Color.White;
            this.buttonPtbDcc.Location = new System.Drawing.Point(128, 3);
            this.buttonPtbDcc.Name = "buttonPtbDcc";
            this.buttonPtbDcc.Size = new System.Drawing.Size(130, 30);
            this.buttonPtbDcc.TabIndex = 4;
            this.buttonPtbDcc.Text = "PTB DCC";
            this.buttonPtbDcc.UseVisualStyleBackColor = false;
            this.buttonPtbDcc.Click += new System.EventHandler(this.buttonPtbDcc_Click);
            // 
            // buttonMetCalAcc
            // 
            this.buttonMetCalAcc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonMetCalAcc.FlatAppearance.BorderSize = 0;
            this.buttonMetCalAcc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonMetCalAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMetCalAcc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMetCalAcc.ForeColor = System.Drawing.Color.White;
            this.buttonMetCalAcc.Location = new System.Drawing.Point(3, 3);
            this.buttonMetCalAcc.Name = "buttonMetCalAcc";
            this.buttonMetCalAcc.Size = new System.Drawing.Size(130, 30);
            this.buttonMetCalAcc.TabIndex = 3;
            this.buttonMetCalAcc.Text = "MET/CAL ACC";
            this.buttonMetCalAcc.UseVisualStyleBackColor = false;
            this.buttonMetCalAcc.Click += new System.EventHandler(this.buttonMetCalAcc_Click);
            // 
            // panelMainSUF
            // 
            this.panelMainSUF.BackColor = System.Drawing.SystemColors.Control;
            this.panelMainSUF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainSUF.Location = new System.Drawing.Point(0, 40);
            this.panelMainSUF.Name = "panelMainSUF";
            this.panelMainSUF.Size = new System.Drawing.Size(950, 610);
            this.panelMainSUF.TabIndex = 1;
            // 
            // SourceUncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.panelMainSUF);
            this.Controls.Add(this.panelTopSUF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SourceUncForm";
            this.Text = "SourceUncForm";
            this.panelTopSUF.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSUF;
        private System.Windows.Forms.Button buttonMetCalAcc;
        private System.Windows.Forms.Button buttonPtbDcc;
        private System.Windows.Forms.Panel panelMainSUF;
    }
}