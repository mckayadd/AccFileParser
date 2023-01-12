using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AccFileParserLibrary;

namespace AccFileParserUI
{
    public partial class EvaluateForm : Form
    {
        List<Button> menuButtons;
        Parser parser;
        public SoaEvaluateForm soaEvalForm;
        SoAUncertaintyForm soAUncertaintyForm;

        bool isFirstClickButtonSoaEval = true;
        bool isFirstClickButtonMetNetEval = true;
        // example comment
        public EvaluateForm(Parser aParser)
        {
            InitializeComponent();
            menuButtons = new List<Button>();
            menuButtons.Add(buttonSoAEvaluate);
            menuButtons.Add(buttonMetrologyNetEvaluate);
            parser = aParser;
        }

        public void loadForm(object formToLoad)
        {
            if (this.panelMainEval.Controls.Count > 0)
                this.panelMainEval.Controls.RemoveAt(0);
            Form form = formToLoad as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelMainEval.Controls.Add(form);
            this.panelMainEval.Tag = form;
            form.Show();
        }

        private void manageButtons(Button clickedButton)
        {
            foreach (Button b in menuButtons)
            {
                if (b == clickedButton)
                {
                    b.Enabled = false;
                    b.BackColor = System.Drawing.SystemColors.MenuHighlight;
                    continue;
                }
                if (b.Enabled == false)
                {
                    b.BackColor = System.Drawing.SystemColors.HotTrack;
                    b.Enabled = true;
                }
            }
        }

        private void buttonSoAEvaluate_Click(object sender, EventArgs e)
        {
            manageButtons(buttonSoAEvaluate);
            if (isFirstClickButtonSoaEval)
            {
                isFirstClickButtonSoaEval = false;
                // soaEvalForm = new SoaEvaluateForm(parser); instanciated when Evaluate is clicked due to object access levels
                loadForm(soaEvalForm);
            }
            else
                loadForm(soaEvalForm);
        }

        private void buttonMetrologyNetEvaluate_Click(object sender, EventArgs e)
        {

        }

        private void buttonPtbDcc_Click(object sender, EventArgs e)
        {

        }
    }
}
