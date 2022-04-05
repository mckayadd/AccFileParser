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
        public List<SoAUncFunction> rangeUncFunctions { get; set; }
        public List<Tuple<double, RangeAcc>> filteredRanges;
        // Column constants
        private const string sourceUncColName = "sourcUnc";
        private const string sourceUncColValue = "Source Unc";
        private const string soaUncColName = "soaUnc";
        private const string soaUncColValue = "SoA Unc";

        public EvaluateForm(Parser aParser)
        {
            InitializeComponent();
            parser = aParser;
            List<SoAUncFunction> rangeUncFunctions = new List<SoAUncFunction>();
            filteredRanges =  new List<Tuple<double, RangeAcc>>();
            clearContents();
        }

        // TODO: Add conditional to evaluate the Source Unc and add it to the respective column
        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            List<SoAUncFunction> inRange = new List<SoAUncFunction>();
            Dictionary<string, List<double>> startStopStep = new Dictionary<string, List<double>>();

            #region mckaya
            double startG = 0.0;
            double stopG = 0.0;
            double stepG = 0.0;
            #endregion

            resultsDataGrid.Rows.Clear();
            if (rangeUncFunctions.Count > 0)
            {
                // lets check our inputs first
                var functionName = rangeUncFunctions[0].Uncertainty.function_name;
                var vars = rangeUncFunctions[0].Template.getCMCFunctionVariables(functionName);
                var count = 0;

               

                foreach (string variable in vars)
                {
                    startStopStep.Add(variable, new List<double>());
                    foreach (var control in inputsPanel.Controls)
                    {
                        if (control is TextBox)
                        {
                            TextBox textBox = (TextBox)control;
                            if (textBox.Name == "start" + variable + count)
                            {
                                if (!string.IsNullOrWhiteSpace(textBox.Text))
                                {
                                    if (double.TryParse(textBox.Text, out double test))
                                    {
                                        startStopStep[variable].Insert(0, double.Parse(textBox.Text));
                                    }
                                }
                            }
                            else if (textBox.Name == "stop" + variable + count)
                            {
                                if (!string.IsNullOrWhiteSpace(textBox.Text))
                                {
                                    if (double.TryParse(textBox.Text, out double test))
                                    {
                                        startStopStep[variable].Insert(1, double.Parse(textBox.Text));
                                    }
                                }
                            }
                            else if (textBox.Name == "step" + variable + count)
                            {
                                if (!string.IsNullOrWhiteSpace(textBox.Text))
                                {
                                    if (double.TryParse(textBox.Text, out double test))
                                    {
                                        startStopStep[variable].Insert(2, double.Parse(textBox.Text));
                                    }
                                }
                            }
                        }
                    }
                    count++;
                }
                // we need to loop through each variable and find the ranges that fall between start and stop for each step increment
                int row = 0;
                foreach (var rangeUncFunction in rangeUncFunctions)
                {
                    double current = 0;
                    foreach (var variable in vars)
                    {
                        if (startStopStep[variable].Count != 3) continue;
                        double start = startStopStep[variable][0];
                        double stop = startStopStep[variable][1];
                        double step = startStopStep[variable][2];

                        #region mckaya
                        startG = start;
                        stopG = stop;
                        stepG = step;
                        #endregion

                        if (current == 0) current = start; 
                        for (; current < stop; current += step)
                        {
                            if (current >= (double)rangeUncFunction.Range.Start.Value &&
                                current <= (double)rangeUncFunction.Range.End.Value)
                            {
                                rangeUncFunction.Template.setCMCFunctionSymbol(functionName, variable, current);
                                try
                                {
                                    _ = resultsDataGrid.Rows[row];
                                }
                                catch (Exception ex)
                                {
                                    resultsDataGrid.Rows.Add();
                                }
                                resultsDataGrid[variable, row].Value = current;
                                resultsDataGrid["range", row].Value = rangeUncFunction.Range.Start.ValueString + " to " + rangeUncFunction.Range.End.ValueString;
                                // set constant values
                                foreach (var constant in rangeUncFunction.Range.ConstantValues)
                                {
                                    rangeUncFunction.Template.setCMCFunctionSymbol(functionName, constant.const_parameter_name, (double)constant.Value);
                                }
                                // evaluate the function
                                string result;
                                try
                                {
                                    decimal? output = rangeUncFunction.Template.evaluateCMCFunction(functionName);
                                    if (output.HasValue && output.Value < 1)
                                        result = output.Value.ToString("E2");
                                    else
                                        result = output.Value.ToString("0.##");
                                }
                                catch (Exception)
                                {
                                    result = "Error";
                                }
                                // if we have a result lets finally add to our data grid
                                if (result != null)
                                {
                                    resultsDataGrid[soaUncColName, row].Value = result;
                                }
                                row++;
                            }
                        }
                    }
                }
            }

            populateDataGrid(startG, stopG, stepG);

        }

        public void populateDataGrid(double start, double stop, double step)
        {
            //MessageBox.Show(start.ToString() + " " + stop.ToString() + " " + step.ToString());
            List<Double> steps = new List<double>();
            for(double i = start; i <= stop; i += step)
            {
                steps.Add(i);
            }

            foreach(Double volt in steps) 
            {
                foreach (RangeAcc item in parser.selectedFunction.rangeList)
                {
                    RangeLimit nominalRangeLimit = item.nominal;

                    if (nominalRangeLimit.lowerLimit.doubleValueFlag && nominalRangeLimit.upperLimit.doubleValueFlag 
                        && item.mod1.lowerLimit.strValueFlag ) // focusing on DC only
                        if (nominalRangeLimit.isInLimit(volt))
                        {
                            Tuple<double, RangeAcc> t = Tuple.Create(volt, item);
                            filteredRanges.Add(t); 
                        }
                }
            }

            //dataGridViewSourceUnc.Rows.Clear();
            foreach (var t in filteredRanges)
            {
                double v = t.Item1;
                RangeAcc rangeAcc = t.Item2;
                double sourceUncertainty;
                double tolerance = rangeAcc.tolerance.doubleValue;
                double floor = rangeAcc.floor.doubleValue;
                sourceUncertainty = v * (tolerance / 100) + floor; // uncertainty calculation
                String[] newRow = rangeAcc.returnRange();
                dataGridViewSourceUnc.Rows.Add(v.ToString(), "", "", newRow[0] + " to " + newRow[1], sourceUncertainty.ToString(), "");
            }
        }


        private void clearContents()
        {
            inputsPanel.Controls.Clear();
            resultsDataGrid.Rows.Clear();
            resultsDataGrid.Columns.Clear();
        }

        // Use the SoAUncFuntion Class from our SoAUncertaintyForm to build our evaluate start/stop/step form
        public void loadStartStopStep()
        {
            clearContents();
            if (rangeUncFunctions.Count > 0)
            {
                var soaUncFunction = rangeUncFunctions[0];
                var functionName = soaUncFunction.Uncertainty.function_name;
                var vars = soaUncFunction.Template.getCMCFunctionVariables(functionName);
                
                int y = 15;
                int x = 5;
                int count = 0;
                foreach (var varialbe in vars)
                {
                    Label lbl = new Label();
                    lbl.Text = varialbe;
                    TextBox startTextBox = new TextBox();
                    TextBox stopTextBox = new TextBox();
                    TextBox stepTextBox = new TextBox();
                    startTextBox.Name = "start" + varialbe + count;
                    stopTextBox.Name = "stop" + varialbe + count;
                    stepTextBox.Name = "step" + varialbe + count;
                    startTextBox.Text = "Start";
                    stopTextBox.Text = "Stop";
                    stepTextBox.Text = "Step";
                    startTextBox.GotFocus += RemoveText;
                    startTextBox.LostFocus += AddText;
                    stopTextBox.GotFocus += RemoveText;
                    stopTextBox.LostFocus += AddText;
                    stepTextBox.GotFocus += RemoveText;
                    stepTextBox.LostFocus += AddText;
                    inputsPanel.Controls.Add(lbl);
                    inputsPanel.Controls.Add(startTextBox);
                    inputsPanel.Controls.Add(stopTextBox);
                    inputsPanel.Controls.Add(stepTextBox);
                    lbl.Location = new Point(x, y);
                    x += lbl.Width + 1;
                    startTextBox.Location = new Point(x, y);
                    x += lbl.Width + 5;
                    stopTextBox.Location = new Point(x, y);
                    x += lbl.Width + 5;
                    stepTextBox.Location = new Point(x, y);
                    x += lbl.Width + 5;
                    y += startTextBox.Height + 5;
                    x = 5;
                    count++;
                    resultsDataGrid.Columns.Add(varialbe, varialbe);
                }
                resultsDataGrid.Columns.Add("range", "Range");
                resultsDataGrid.Columns.Add(sourceUncColName, sourceUncColValue);
                resultsDataGrid.Columns.Add(soaUncColName, soaUncColValue);
            }
        }

        // place holders for start stop and step
        public void RemoveText(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Start")
            {
                textBox.Text = "";
            }
            if (textBox.Text == "Stop")
            {
                textBox.Text = "";
            }
            if (textBox.Text == "Step")
            {
                textBox.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {

            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text) && textBox.Name.Contains("start"))
                textBox.Text = "Start";
            if (string.IsNullOrWhiteSpace(textBox.Text) && textBox.Name.Contains("stop"))
                textBox.Text = "Stop";
            if (string.IsNullOrWhiteSpace(textBox.Text) && textBox.Name.Contains("step"))
                textBox.Text = "Step";
        }
    }
}
