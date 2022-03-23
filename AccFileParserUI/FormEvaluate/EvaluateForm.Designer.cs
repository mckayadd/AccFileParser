
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.soaUncEvalGroupBox = new System.Windows.Forms.GroupBox();
            this.inputsLabel = new System.Windows.Forms.Label();
            this.constantsLabel = new System.Windows.Forms.Label();
            this.constants = new System.Windows.Forms.TextBox();
            this.functionOutput = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.range = new System.Windows.Forms.Label();
            this.expression = new System.Windows.Forms.Label();
            this.function = new System.Windows.Forms.Label();
            this.soaUncEvalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // evaluateButton
            // 
            this.evaluateButton.Location = new System.Drawing.Point(61, 65);
            this.evaluateButton.Name = "evaluateButton";
            this.evaluateButton.Size = new System.Drawing.Size(75, 23);
            this.evaluateButton.TabIndex = 0;
            this.evaluateButton.Text = "Evaluate";
            this.evaluateButton.UseVisualStyleBackColor = true;
            this.evaluateButton.Click += new System.EventHandler(this.buttonEvaluate_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(61, 94);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(265, 169);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // soaUncEvalGroupBox
            // 
            this.soaUncEvalGroupBox.Controls.Add(this.inputsLabel);
            this.soaUncEvalGroupBox.Controls.Add(this.constantsLabel);
            this.soaUncEvalGroupBox.Controls.Add(this.constants);
            this.soaUncEvalGroupBox.Controls.Add(this.functionOutput);
            this.soaUncEvalGroupBox.Controls.Add(this.inputPanel);
            this.soaUncEvalGroupBox.Controls.Add(this.range);
            this.soaUncEvalGroupBox.Controls.Add(this.expression);
            this.soaUncEvalGroupBox.Controls.Add(this.function);
            this.soaUncEvalGroupBox.Location = new System.Drawing.Point(354, 94);
            this.soaUncEvalGroupBox.Name = "soaUncEvalGroupBox";
            this.soaUncEvalGroupBox.Size = new System.Drawing.Size(352, 404);
            this.soaUncEvalGroupBox.TabIndex = 2;
            this.soaUncEvalGroupBox.TabStop = false;
            this.soaUncEvalGroupBox.Text = "SoA Uncertainty Function";
            // 
            // inputsLabel
            // 
            this.inputsLabel.AutoSize = true;
            this.inputsLabel.Location = new System.Drawing.Point(6, 224);
            this.inputsLabel.Name = "inputsLabel";
            this.inputsLabel.Size = new System.Drawing.Size(48, 15);
            this.inputsLabel.TabIndex = 7;
            this.inputsLabel.Text = "Input(s)";
            // 
            // constantsLabel
            // 
            this.constantsLabel.AutoSize = true;
            this.constantsLabel.Location = new System.Drawing.Point(6, 119);
            this.constantsLabel.Name = "constantsLabel";
            this.constantsLabel.Size = new System.Drawing.Size(63, 15);
            this.constantsLabel.TabIndex = 6;
            this.constantsLabel.Text = "Constants:";
            // 
            // constants
            // 
            this.constants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.constants.Location = new System.Drawing.Point(6, 137);
            this.constants.Multiline = true;
            this.constants.Name = "constants";
            this.constants.ReadOnly = true;
            this.constants.Size = new System.Drawing.Size(335, 75);
            this.constants.TabIndex = 5;
            // 
            // functionOutput
            // 
            this.functionOutput.AutoSize = true;
            this.functionOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.functionOutput.Location = new System.Drawing.Point(6, 371);
            this.functionOutput.Name = "functionOutput";
            this.functionOutput.Size = new System.Drawing.Size(94, 15);
            this.functionOutput.TabIndex = 4;
            this.functionOutput.Text = "functionOutput";
            // 
            // inputPanel
            // 
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputPanel.Location = new System.Drawing.Point(6, 242);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(340, 115);
            this.inputPanel.TabIndex = 3;
            // 
            // range
            // 
            this.range.AutoSize = true;
            this.range.Location = new System.Drawing.Point(6, 71);
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(37, 15);
            this.range.TabIndex = 2;
            this.range.Text = "range";
            // 
            // expression
            // 
            this.expression.AutoSize = true;
            this.expression.Location = new System.Drawing.Point(6, 45);
            this.expression.Name = "expression";
            this.expression.Size = new System.Drawing.Size(63, 15);
            this.expression.TabIndex = 1;
            this.expression.Text = "expression";
            // 
            // function
            // 
            this.function.AutoSize = true;
            this.function.Location = new System.Drawing.Point(6, 19);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(52, 15);
            this.function.TabIndex = 0;
            this.function.Text = "function";
            // 
            // EvaluateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.soaUncEvalGroupBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.evaluateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EvaluateForm";
            this.Text = "EvaluateForm";
            this.soaUncEvalGroupBox.ResumeLayout(false);
            this.soaUncEvalGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button evaluateButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox soaUncEvalGroupBox;
        private System.Windows.Forms.Label function;
        private System.Windows.Forms.Label range;
        private System.Windows.Forms.Label expression;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Label functionOutput;
        private System.Windows.Forms.Label inputsLabel;
        private System.Windows.Forms.Label constantsLabel;
        private System.Windows.Forms.TextBox constants;
    }
}