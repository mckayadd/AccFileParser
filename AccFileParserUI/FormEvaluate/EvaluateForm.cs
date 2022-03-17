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
    public partial class EvaluateForm : Form
    {
        Parser parser;
        public EvaluateForm(Parser aParser)
        {
            InitializeComponent();
            parser = aParser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "";
            str += parser.refStd.instrument + "\n";
            str += parser.refStd.interval + "\n";
            richTextBox1.Text = str;
        }
    }
}
