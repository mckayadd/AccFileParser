using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AccFileParserLibrary;
using SOA_DataAccessLib;

namespace AccFileParserUI
{
    public partial class MainForm : Form
    {
        List<Button> menuButtons;
        Parser parser;

        SelectTaxonForm selectTaxonForm;
        SourceUncForm sourceUncForm;
        SoAUncertaintyForm soAUncertaintyForm;
        MetrologyNetUncertaintyForm metrologyNetUncForm;
        EvaluateForm evaluateForm;
        SoaEvaluateForm soaEvaluateForm;

        bool isFirstClickButtonSelectTaxon = true;
        bool isFirstClickButtonSourceUncertainty = true;
        bool isFirstClickButtonSoAUncertainty = true;
        bool isFirstClickButtonMetrologyNetUncertainty = true;
        bool isFirstClickButtonEvaluate = true;

        public MainForm()
        {
            InitializeComponent();
            parser = new Parser();
            menuButtons = new List<Button>();
            menuButtons.Add(buttonMetrologyNetUnc);
            menuButtons.Add(buttonSourceUncertainty);
            menuButtons.Add(buttonSoAUncertainty);
            menuButtons.Add(buttonEvaluate);
        }

        public void loadForm(object formToLoad)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form form = formToLoad as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(form);
            this.panelMain.Tag = form;
            form.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSelectTaxon_Click(object sender, EventArgs e)
        {
            manageButtons(buttonSelectTaxon);
            if(isFirstClickButtonSelectTaxon)
            {
                isFirstClickButtonSelectTaxon = false;
                selectTaxonForm = new SelectTaxonForm();
                loadForm(selectTaxonForm);
            }
            else
                loadForm(selectTaxonForm);
        }

        private void buttonSourceUncertainty_Click(object sender, EventArgs e)
        {
            manageButtons(buttonSourceUncertainty);
            if(isFirstClickButtonSourceUncertainty)
            {
                isFirstClickButtonSourceUncertainty = false;
                sourceUncForm = new SourceUncForm(parser);
                loadForm(sourceUncForm);
            }
            else
                loadForm(sourceUncForm);
        }

        private void buttonSoAUncertainty_Click(object sender, EventArgs e)
        {
            manageButtons(buttonSoAUncertainty);
            if(isFirstClickButtonSoAUncertainty)
            {
                isFirstClickButtonSoAUncertainty = false;
                soAUncertaintyForm = new SoAUncertaintyForm();
                loadForm(soAUncertaintyForm);
            }
            else
                loadForm(soAUncertaintyForm);
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            manageButtons(buttonEvaluate);
            if(isFirstClickButtonEvaluate)
            {
                isFirstClickButtonEvaluate = false;
                evaluateForm = new EvaluateForm(parser);
                // load the soaEval form now
                soaEvaluateForm = new SoaEvaluateForm(parser);
                evaluateForm.soaEvalForm = soaEvaluateForm;
                loadForm(evaluateForm);
            }
            else
                loadForm(evaluateForm);

            // Load only controls when we have ranges to work with and only reload if the technique has changed
            if (soAUncertaintyForm != null)
            {
                soaEvaluateForm.rangeUncFunctions = soAUncertaintyForm.GetSoaFunctions();

                if (soaEvaluateForm.rangeUncFunctions != null && soaEvaluateForm.rangeUncFunctions.Count > 0
                    && soAUncertaintyForm.getSelectedTechnique() != soaEvaluateForm.currentTechnique)
                {
                    soaEvaluateForm.currentTechnique = soAUncertaintyForm.getSelectedTechnique();
                    soaEvaluateForm.loadStartStopStep();
                }
            }
        }

        private void buttonMetrolgoyButtonUncertainty_Click(object sender, EventArgs e)
        {
            manageButtons(buttonMetrologyNetUnc);
            if (isFirstClickButtonMetrologyNetUncertainty)
            {
                isFirstClickButtonMetrologyNetUncertainty = false;
                metrologyNetUncForm = new MetrologyNetUncertaintyForm();
                loadForm(metrologyNetUncForm);
            }
            else
                loadForm(metrologyNetUncForm);
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

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
