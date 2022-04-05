using SOA_DataAccessLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccFileParserUI
{
    public partial class SoAUncertaintyForm : Form
    {
        private Soa soa;
        private SOA_DataAccess dao;
        private List<string> rangeRows;
        private List<Unc_Range> ranges = new List<Unc_Range>(); 
        private Dictionary<string, string> filters = new Dictionary<string, string>();

        public SoAUncertaintyForm()
        {
            InitializeComponent();
            clearContent();
        }

        #region Events

        private void openSoAFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = true;
            dlg.Filter = "XML Files (*.xml)|*.xml";
            dlg.Multiselect = false;
            try
            {
                var result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    clearContent(true);
                    soa = new Soa();
                    dao = new SOA_DataAccess();
                    dao.load(dlg.FileName);
                    soa = dao.SOADataMaster;
                    loadContent(dlg.SafeFileName);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("The data file is invalid!");
                return;
            }
        }

        private void taxonListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var taxon = soa.CapabilityScope.Activities[0].Taxons[taxonListBox.SelectedItem.ToString()];
            if (taxon != null)
            {
                loadTechniqueList(taxon.name);
                loadTaxonInfo(taxon.Taxon);
            }
        }

        private void techniqueListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var technique = soa.CapabilityScope.Activities[0].Techniques[techniqueListBox.SelectedItem.ToString()];
            if (technique != null)
            {
                loadTechniqueInfo(technique.Technique);
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            //useFilters = true;
            filters.Clear();
            foreach (var control in filtersPanel.Controls)
            {
                if (control is TextBox)
                {
                    var textBox = (TextBox)control;
                    if (textBox.Text != null && textBox.Text != "")
                        filters.Add(textBox.Name, textBox.Text.Trim());
                }
            }
            if (filters.Count == 0)
            {
                loadRanges(techniqueName.Text);
                return;
            }
            foreach (var keyVal in filters)
            {
                var colname = keyVal.Key;
                var filterVal = keyVal.Value.Trim().ToLower().Replace(" ", "");
                var rowsToRemove = new List<DataGridViewRow>();
                var rangesToRemove = new List<Unc_Range>();
                for (int i = 0; i < rangesDataGrid.Rows.Count; i++)
                {
                    string rowVal = rangesDataGrid[colname, i].Value.ToString().ToLower().Replace(" ", "");
                    if (!rowVal.Contains(filterVal))
                    {
                        rowsToRemove.Add(rangesDataGrid.Rows[i]);
                        rangesToRemove.Add(ranges[i]);
                    }
                }
                foreach (var row in rowsToRemove)
                {
                    rangesDataGrid.Rows.Remove(row);
                }
                foreach (var range in rangesToRemove)
                {
                    ranges.Remove(range);
                }
                rangesDataGrid.Refresh();
            }
        }

        #endregion


        #region Helper Methods

        private void loadContent(string fileName)
        {
            if (soa == null) return;
            guideLabel.Text = "Seleted File: " + fileName;
            loadTaxonomyList();
        }

        private void loadTaxonomyList()
        {
            if (soa.CapabilityScope.Activities[0].Taxons.Count() > 0)
            {
                foreach (var taxon in soa.CapabilityScope.Activities[0].Taxons)
                {
                    taxonListBox.Items.Add(taxon.name);
                }
            }
        }

        private void loadTaxonInfo(Mtc_Taxon taxon)
        {
            taxonName.Text = taxon.Name;
            taxonDefinition.Text = taxon.Definition.Value;
            BindingSource source = new BindingSource();
            foreach (var param in taxon.Parameters)
            {
                source.Add(new TaxonParam(param));
            }
            taxonParamDataGrid.DataSource = source;

        }

        private void loadTechniqueList(string taxon)
        {
            clearContent();
            foreach (var technique in soa.CapabilityScope.Activities[0].Techniques)
            {
                if (technique.Taxon == taxon)
                {
                    techniqueListBox.Items.Add(technique.Name);
                }
            }
        }

        private void loadTechniqueInfo(Mtc_Technique technique)
        {
            techniqueName.Text = technique.Name;
            functionName.Text = "Function: " + technique.CMCUncertainties[0].function_name;
            expression.Text = technique.CMCUncertainties[0].Expression;
            BindingSource source = new BindingSource();
            var symbols = technique.CMCUncertainties[0].SymbolDefinitions;
            foreach (var param in technique.Parameters)
            {
                source.Add(new TechniqueParam(param, technique.ParameterRanges[param.name], symbols));
            }
            techniqueParamDataGrid.DataSource = source;
            loadRanges(technique.Name);
            var x = 0;
            if (technique.RangeAssertions.Count() > 0)
            {
                foreach (string assertion in technique.RangeAssertions)
                {
                    x = createFilterInput(assertion, x);
                }
            }
            var template = soa.CapabilityScope.Activities[0].GetTemplateByTemplateTechnique(technique.Name);
            var cases = template.CMCUncertaintyFunctions[technique.CMCUncertainties[0].function_name].Cases;
            var infulenceQuatnties = new List<string>();
            var variables = new List<string>();
            bool checkNestedRanges = false;
            foreach (var _case in cases)
            {
                var ranges = _case.Ranges.RangesByVarType("influence_quantity");
                if (ranges != null && ranges.Count() > 0)
                {
                    checkNestedRanges = true;
                    if (!infulenceQuatnties.Contains(ranges[0].Variable_name))
                    {
                        infulenceQuatnties.Add(ranges[0].Variable_name);
                    }

                }
                if (!checkNestedRanges) ranges = _case.Ranges.RangesByVarType("parameter");
                if (checkNestedRanges) ranges = _case.Ranges[0].Ranges.RangesByVarType("parameter");
                if (ranges != null && ranges.Count() > 0)
                {
                    if (!variables.Contains(ranges[0].Variable_name))
                    {
                        variables.Add(ranges[0].Variable_name);
                    }
                }
            }
            foreach (var infQty in infulenceQuatnties)
            {
                x = createFilterInput(infQty, x);
            }
            
            foreach (var symbol in symbols)
            {
                if (symbol.type.ToLower() == "variable" && variables.Contains(symbol.parameter))
                {
                    x = createFilterInput(symbol.parameter, x);
                }
            }
        }

        private void loadRanges(string techniqueName)
        {
            var template = soa.CapabilityScope.Activities[0].GetTemplateByTemplateTechnique(techniqueName);
            var technique = soa.CapabilityScope.Activities[0].Techniques[techniqueName];
            rangeRows = new();
            rangesDataGrid.Rows.Clear();
            rangesDataGrid.Columns.Clear();
            ranges.Clear();
            if (template == null) return;
            if (technique == null) return;
            var cases = template.CMCUncertaintyFunctions[technique.Technique.CMCUncertainties[0].function_name].Cases;
            foreach (string assertion in technique.Technique.RangeAssertions)
            {
                rangesDataGrid.Columns.Add(assertion, assertion);
            }
            if (cases[0].Ranges != null)
            {
                addColumnToDataTable(cases[0].Ranges);
            }
            int caseCount = cases.Count();
            for (int caseIndex = 0; caseIndex < caseCount; caseIndex++)
            {
                int assertCount = cases[caseIndex].Assertions.Count();
                rangeRows.Clear();
                for (int assetIndex =0; assetIndex < assertCount; assetIndex++)
                {
                    rangeRows.Add(cases[caseIndex].Assertions[assetIndex].Value);
                }
                if (cases[caseIndex].Ranges != null)
                {
                    addRowsToDataTable(cases[caseIndex].Ranges);
                }
            }
        }

        private void clearContent(bool fullReset = false)
        {
            if (fullReset) guideLabel.Text = "Select a file to load the content...";
            if (fullReset) taxonListBox.Items.Clear();
            techniqueListBox.Items.Clear();
            taxonName.Text = "";
            taxonDefinition.Text = "";
            taxonParamDataGrid.Rows.Clear();
            techniqueName.Text = "";
            functionName.Text = "";
            expression.Text = "";
            techniqueParamDataGrid.Rows.Clear();
            rangesDataGrid.Rows.Clear();
            rangesDataGrid.Columns.Clear();
            filtersPanel.Controls.Clear();
        }

        private void addColumnToDataTable(Unc_Ranges ranges)
        {
            string varName = ranges.variable_name;
            rangesDataGrid.Columns.Add(varName, varName);
            if (ranges.getRanges() != null && ranges.getRanges()[0].Ranges != null && ranges.getRanges()[0].Ranges.variable_name != "")
            {
                addColumnToDataTable(ranges.getRanges()[0].Ranges);
            }
            else
            {
                if (ranges.getRanges()[0].ConstantValues != null)
                {
                    rangesDataGrid.Columns.Add("Constants", "Constants");
                    rangesDataGrid.Columns["Constants"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    rangesDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    rangesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
        }

        private void addRowsToDataTable(Unc_Ranges ranges)
        {
            int rangeCount = ranges.getRanges().Count;
            for (int rangeIndex = 0; rangeIndex < rangeCount; rangeIndex++)
            {
                rangeRows.Add(ranges.getRanges()[rangeIndex].Start.Value + " to " + ranges.getRanges()[rangeIndex].End.Value);
                if (ranges.getRanges()[rangeIndex].Ranges != null && ranges.getRanges()[0].Ranges.variable_name != "")
                {
                    addRowsToDataTable(ranges.getRanges()[rangeIndex].Ranges);
                }
                else
                {
                    string constVals = "";
                    int constValCount = ranges.getRanges()[rangeIndex].ConstantValues.Count();
                    for (int constValIndex = 0; constValIndex < constValCount; constValIndex++)
                    {
                        constVals += ranges.getRanges()[rangeIndex].ConstantValues[constValIndex].const_parameter_name + " = " + ranges.getRanges()[rangeIndex].ConstantValues[constValIndex].Value + Environment.NewLine;
                    }
                    rangeRows.Add(constVals);
                    DataGridViewRow row = new();
                    for (int index = 0; index < rangesDataGrid.Columns.Count; index++)
                    {
                        DataGridViewTextBoxCell cell = new();
                        cell.Value = rangeRows[index];
                        row.Cells.Add(cell);                        
                    }
                    rangesDataGrid.Rows.Add(row);
                    this.ranges.Add(ranges.getRanges()[rangeIndex]);
                    rangeRows.RemoveAt(rangeRows.Count - 1);
                }
                rangeRows.RemoveAt(rangeRows.Count - 1);
            }
        }

        private int createFilterInput(string name, int x)
        {
            var label = new Label();
            var textBox = new TextBox();
            textBox.Name = name;
            label.Text = name;
            filtersPanel.Controls.Add(label);
            filtersPanel.Controls.Add(textBox);
            label.Location = new Point(x, 10);
            textBox.Location = new Point(x, 35);
            textBox.Width = label.Width - 5;
            x += label.Width;
            return x;
        }

        public SoAUncFunction getSelectedFunction()
        {
            if (soa == null) return null;
            if (ranges.Count == 0) return null;
            var template = soa.CapabilityScope.Activities[0].GetTemplateByTemplateTechnique(techniqueName.Text);
            if (template == null) return null;
            SoAUncFunction function = new();
            function.Range = ranges[rangesDataGrid.SelectedRows[0].Index];
            function.Template = template;
            function.Uncertainty = template.getCMCUncertaintyTechniqueName(techniqueName.Text)[0];
            return function;
        }

        public List<SoAUncFunction> GetSoaFunctions()
        {
            List<SoAUncFunction> functions = new List<SoAUncFunction>();
            if (soa == null) return null;
            if (ranges.Count == 0) return null;
            var template = soa.CapabilityScope.Activities[0].GetTemplateByTemplateTechnique(techniqueName.Text);
            if (template == null) return null;
            foreach (var range in ranges)
            {
                SoAUncFunction function = new();
                function.Range = range;
                function.Template = template;
                function.Uncertainty = template.getCMCUncertaintyTechniqueName(techniqueName.Text)[0];
                functions.Add(function);
            }
            return functions;
        }

        public string getSelectedTechnique()
        {
            return techniqueName.Text;
        }

        #endregion

        #region Helper Classes
        protected class TaxonParam
        {
            public string Name { get; set; }
            public bool Required { get; set; }
            public string Quantity { get; set; }

            public TaxonParam(Mtc_Parameter param)
            {
                Name = param.name;
                Required = !param.optional;
                Quantity = param.Quantity != null ? param.Quantity.name : "";
            }
        }

        protected class TechniqueParam
        {
            public string Name { get; set; }
            public bool Required { get; set; }
            public string Quantity { get; set; }
            public string Type { get; set; }
            public string Range { get; set; }

            public TechniqueParam(Mtc_Parameter param, Mtc_Range range, Mtc_Symbols symbols)
            {
                Name = param.name;
                Required = !param.optional;
                Quantity = param.Quantity != null ? param.Quantity.name : "";
                Type = "Influence Quantity";
                foreach (var symbol in symbols)
                {
                    if (symbol.parameter == param.name)
                    {
                        Type = symbol.type.ToLower() == "variable" ? "Variable" : "Constant";
                        break;
                    }
                }

                Range = "";
                if (range != null)
                {
                    Range = range.Start.ValueString + " to " + range.End.ValueString;
                }
            }
        }

        public class SoAUncFunction
        {
            public Unc_Template Template { get; set; }
            public Unc_Range Range { get; set; }
            public Mtc_CMCUncertainty Uncertainty { get; set; }
        }

        #endregion
    }
}
