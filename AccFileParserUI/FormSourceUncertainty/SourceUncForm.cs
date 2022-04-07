using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AccFileParserLibrary;


namespace AccFileParserUI
{
    public partial class SourceUncForm : Form
    {
        List<Button> menuButtons;
        Parser parser;
        MetCalAccForm metCalAccForm;
        PtbDccForm ptbDccForm;

        bool isFirstClickButtonMetCalAcc = true;
        bool isFirstClickButtonPtbDcc = true;

        public SourceUncForm(Parser aParser)
        {
            InitializeComponent();
            menuButtons = new List<Button>();
            menuButtons.Add(buttonMetCalAcc);
            menuButtons.Add(buttonPtbDcc);
            parser = aParser;
        }

        public void loadForm(object formToLoad)
        {
            if (this.panelMainSUF.Controls.Count > 0)
                this.panelMainSUF.Controls.RemoveAt(0);
            Form form = formToLoad as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelMainSUF.Controls.Add(form);
            this.panelMainSUF.Tag = form;
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

        private void buttonMetCalAcc_Click(object sender, EventArgs e)
        {
            manageButtons(buttonMetCalAcc);
            if(isFirstClickButtonMetCalAcc)
            {
                isFirstClickButtonMetCalAcc = false;
                metCalAccForm = new MetCalAccForm(parser);
                loadForm(metCalAccForm);
            }
            else
                loadForm(metCalAccForm);
        }

        private void buttonPtbDcc_Click(object sender, EventArgs e)
        {
            manageButtons(buttonPtbDcc);
            if(isFirstClickButtonPtbDcc)
            {
                isFirstClickButtonPtbDcc = false;
                ptbDccForm = new PtbDccForm();
                loadForm(ptbDccForm);
            }
            else
                loadForm(ptbDccForm);

        }

    }
}
