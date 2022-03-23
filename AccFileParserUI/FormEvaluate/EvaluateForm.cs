using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AccFileParserLibrary;
using static AccFileParserUI.SoAUncertaintyForm;

namespace AccFileParserUI
{
    public partial class EvaluateForm : Form
    {
        Parser parser;
        public SoAUncFunction soaUncFunction { get; set; }
        public EvaluateForm(Parser aParser)
        {
            InitializeComponent();
            parser = aParser;
            clearContents();
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            String str = "";
            str += parser.refStd.instrument + "\n";
            str += parser.refStd.interval + "\n";
            richTextBox1.Text = str;

            // if we have a SoAUncFuntion lets try to evaluate it
            if (soaUncFunction != null)
            {
                // loop through our variables
                foreach(var variable in soaUncFunction.Template.getCMCFunctionVariables(function.Text))
                {
                    // get the related text box
                    foreach (var control in inputPanel.Controls)
                    {
                        if (control is TextBox)
                        {
                            var textBox = (TextBox)control;
                            decimal test;
                            // make sure our input is a number
                            if (!decimal.TryParse(textBox.Text, out test))
                            {
                                MessageBox.Show("Validation Error", string.Format("The input \"{0}\" is must be a valid number.", variable),
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            decimal val = decimal.Parse(textBox.Text);
                            // make sure input is in the Unc Range
                            if (textBox.Text == variable && soaUncFunction.Range.Variable_name == variable)
                            {
                                var start = soaUncFunction.Range.Start.Value;
                                var end = soaUncFunction.Range.End.Value;
                                if (val >= start && val <= end)
                                {
                                    MessageBox.Show("Out of Range", string.Format("The input \"{0}\" is out of the Uncertainty Range.", variable),
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                            }
                            // add the variable to our function
                            soaUncFunction.Template.setCMCFunctionSymbol(function.Text, variable, double.Parse(textBox.Text));
                        }
                    }
                }
                // add our constant values
                foreach (var constant in soaUncFunction.Range.ConstantValues)
                {
                    soaUncFunction.Template.setCMCFunctionSymbol(function.Text, constant.const_parameter_name, double.Parse(constant.ValueString));
                }
                // evaluate the function
                try
                {
                    decimal? output = soaUncFunction.Template.evaluateCMCFunction(function.Text);              
                    if (output.HasValue && output.Value < 1)
                        functionOutput.Text = output.Value.ToString("E2");
                    else
                        functionOutput.Text = output.Value.ToString("0.##");
                }
                catch (Exception ex){
                    functionOutput.Text = ex.Message;
                }
            }
        }

        private void clearContents()
        {
            function.Text = "";
            expression.Text = "";
            range.Text = "";
            inputPanel.Controls.Clear();
            constants.Text = "";
            functionOutput.Text = "";
        }

        // Use the SoAUncFuntion Class from our SoAUncertaintyForm to build our form
        public void loadSoAUncFuncGroupBox()
        {
            inputPanel.Controls.Clear();
            constants.Text = "";
            functionOutput.Text = "";
            if (soaUncFunction != null)
            {
                function.Text = soaUncFunction.Uncertainty.function_name;
                expression.Text = soaUncFunction.Uncertainty.Expression;
                range.Text = String.Format("Range:\n{0} {1} to {2}", soaUncFunction.Range.Variable_name, soaUncFunction.Range.Start.ValueString, soaUncFunction.Range.End.ValueString);
                var vars = soaUncFunction.Template.getCMCFunctionVariables(function.Text);
                foreach (var constant in soaUncFunction.Range.ConstantValues)
                {
                    constants.AppendText(string.Format("{0} = {1}", constant.const_parameter_name, constant.ValueString));
                    constants.AppendText(Environment.NewLine);
                }
                int y = 5;
                foreach (var varialbe in vars)
                {
                    Label lbl = new Label();
                    lbl.Text = varialbe;
                    TextBox textBox = new TextBox();
                    textBox.Name = varialbe;
                    inputPanel.Controls.Add(lbl);
                    inputPanel.Controls.Add(textBox);
                    lbl.Location = new Point(0, y);
                    textBox.Location = new Point(lbl.Width, y);
                    y += textBox.Height + 5;
                }
            }
        }
    }
}
