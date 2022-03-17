using AccFileParserLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AccFileParserUI
{
    public partial class MetCalAccForm : Form
    {
        BindingSource modeBinding = new BindingSource();
        Parser parser;
        public double nominalSelected { get; set; }
        public double mod1Selected { get; set; }
        public double toleranceSelected { get; set; }
        public double floorSelected { get; set; }

        String selectedMode = String.Empty;
        List<RangeAcc> filteredRanges;

        //flag
        public bool isFirstSelect { get; set; }

        public MetCalAccForm(Parser aParser)
        {
            InitializeComponent();
            //Measurement myDevice = new Measurement();
            //myDevice.confidence = 5;
            isFirstSelect = true;
            filteredRanges = new List<RangeAcc>();
            parser = aParser;
        }

        private void openAccFileButton_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            var fileName = string.Empty;

            // contains local path!!!!!!!!!!!!!!!!!!!!!!!!!!
            #region Reading the source file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\mckaya\\Documents\\ExampleAccFiles";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    fileName = openFileDialog.SafeFileName;
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            #endregion

            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);

            // Create a parser object with the file content
            clearPreviousContent();
            parser.loadFileContent(fileContent);
            // Disable button after reading the file
            // openAccFileButton.Enabled = false;

            string outputStr = parser.refStd.returnContent();

            //MessageBox.Show(outputStr);
            //headerAndCommentsLabel.Text = parser.refStd.returnHeaderAndComments();
            // headerInfoRichTextBox.Text = parser.refStd.returnHeaderAndComments();
            guideLabel.Text = "Selected File: " + fileName;
            
            //outputTextBox.Text = outputStr;

            modeBinding.DataSource = parser.refStd.modeList;
            modeListBox.DataSource = modeBinding;

            fileContentRichTextBox.Text = fileContent;

            //calculationPanel.Visible = true;
            modeBinding.ResetBindings(false);
            
        }

        private void clearPreviousContent()
        {
            parser.refStd.clearContent();
            fileContentRichTextBox.Text = "";
            dataGridViewSelectedRanges.Rows.Clear();
            dataGridViewFilteredRanges.Rows.Clear();
            textBoxNominal.Text = "";
            textBoxMod1.Text = "";
        }

        private void modeListBox_SelectedValueChanged(object sender, EventArgs e)
        {

            selectedMode = (String)modeListBox.SelectedItem;
            Function f = null;
            // String outputStr = "";
            try
            {
                selectedModeLabel.Text = selectedMode;
                f = parser.refStd.modeDictionary[selectedMode]; // Generates exception at runtime when user changes the file
                textBoxNominal.Text = "";
                textBoxMod1.Text = "";
                dataGridViewFilteredRanges.Rows.Clear();
                dataGridViewSelectedRanges.Rows.Clear();

                foreach (RangeAcc item in f.rangeList)
                {
                    String[] newRow = item.returnRange();
                    //DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    //dataGridViewRow.Cells.Add(newRow[0]);
                    dataGridViewSelectedRanges.Rows.Add(newRow[0], newRow[1], newRow[2], newRow[3], newRow[4], newRow[5], newRow[6]);
                }

                findSelectedModeInFileContentRichTextBox();
            }
            catch (Exception)
            {

            }
            //rangesDataGridView.CurrentCell.Selected = false;
        }

        private void findSelectedModeInFileContentRichTextBox()
        {

            if (selectedMode != "")
            {
                string content = fileContentRichTextBox.Text;
                int startIndex = 0;
                int pos = 0;
                while (true)
                {
                    pos = content.IndexOf(selectedMode, startIndex);
                    string subStr = string.Empty;
                    while (content[pos] != '\n')
                    {
                        subStr += content[pos++];
                    }
                    if (subStr.Trim() == selectedMode)
                    {
                        fileContentRichTextBox.SelectionStart = pos;
                        fileContentRichTextBox.ScrollToCaret();
                        break;
                    }
                    startIndex = pos + subStr.Length;
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonModeListSort_Click(object sender, EventArgs e)
        {
            parser.refStd.modeList.Sort();
            modeBinding.ResetBindings(false);   
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            //nominalSelected      = Double.Parse(nominalTextBox.Text); // must handle the case when the textbox is empty
            //mod1Selected         = Double.Parse(mod1TextBox.Text);

            //double result = nominalSelected * (toleranceSelected / 100) + floorSelected;
            //resultTextBox.Text = result.ToString();

            if (selectedMode == String.Empty) return;
            filteredRanges.Clear();
            findFilteredRanges(textBoxNominal.Text, textBoxMod1.Text);
            dataGridViewFilteredRanges.Rows.Clear();
            foreach (RangeAcc item in filteredRanges) 
            {
                String[] newRow = item.returnRange();
                dataGridViewFilteredRanges.Rows.Add(newRow[0], newRow[1], newRow[2], newRow[3], newRow[4], newRow[5], newRow[6]);
            }
        }

        public void findFilteredRanges(String nominalStr, String mod1Str)
        {

            Double nominal = 0.0;
            Double mod1 = 0.0;

            bool filterForNominal = false;
            bool filterForMod1 = false;

            if (nominalStr != "")
            {
                nominal = Double.Parse(nominalStr);
                filterForNominal = true;
            }
            
            if (mod1Str != "")
            {
                mod1 = Double.Parse(mod1Str);
                filterForMod1 = true;
            }

            Function f;
            try
            {
                f = parser.refStd.modeDictionary[selectedMode]; // Generates exception at runtime when user changes the file

                foreach (RangeAcc item in f.rangeList)
                {
                    RangeLimit nominalRangeLimit = item.nominal;
                    RangeLimit mod1RangeLimit = item.mod1;

                    bool nominalFlag = false;
                    bool mod1Flag = false;

                    if (filterForNominal && filterForMod1)
                    { 
                        if (nominalRangeLimit.lowerLimit.doubleValueFlag && nominalRangeLimit.upperLimit.doubleValueFlag) // is it possible to set only one limit?
                            nominalFlag = nominalRangeLimit.isInLimit(nominal);
                        else
                            nominalFlag = true;

                        if (mod1RangeLimit.lowerLimit.doubleValueFlag && mod1RangeLimit.upperLimit.doubleValueFlag)
                            mod1Flag = mod1RangeLimit.isInLimit(mod1);
                        else
                            mod1Flag = true;

                        if (nominalFlag && mod1Flag)
                            filteredRanges.Add(item);
                    }
                    else if (filterForNominal) 
                    {
                        if (nominalRangeLimit.lowerLimit.doubleValueFlag && nominalRangeLimit.upperLimit.doubleValueFlag) // is it possible to set only one limit?
                            if (nominalRangeLimit.isInLimit(nominal))
                                filteredRanges.Add(item);
                    }
                    else if (filterForMod1) 
                    {
                        if (mod1RangeLimit.lowerLimit.doubleValueFlag && mod1RangeLimit.upperLimit.doubleValueFlag)
                           if(mod1RangeLimit.isInLimit(mod1))
                                filteredRanges.Add(item);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void rangesDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                // SelectionMode is set to FullRowMode 
                DataGridViewRow row = dataGridViewSelectedRanges.SelectedRows[0]; // multiselect is false, only index 0 is available

                // nominalLowerUpperLabel.Text = "[" + row.Cells[0].Value.ToString() + ", " + row.Cells[1].Value.ToString() + "]";
                //mod1LowerUpperLabel.Text = "[" + row.Cells[2].Value.ToString() + ", " + row.Cells[3].Value.ToString() + "]";
                //selectedToleranceTextBox.Text = row.Cells[4].Value.ToString(); // enabled = false
                //selectedFloorTextBox.Text = row.Cells[5].Value.ToString(); // enabled = false
                //selectedResolutionTextBox.Text = row.Cells[6].Value.ToString(); // enabled = false
            }
            catch (Exception)
            {
                // works on selected index changed
            }
        }



        //private void rangeLineListView_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if(rangeLineListView.SelectedItems.Count > 0) 
        //        { 
        //            string strTol = rangeLineListView.SelectedItems[0].Text;
        //            string strFloor = rangeLineListView.SelectedItems[1].Text;
        //            string strRes = rangeLineListView.SelectedItems[2].Text;
        //            MessageBox.Show(strTol + " " + strFloor + " " + strRes);
        //        }


        //        //string itemsStr = items.ToString();
        //        //    selectedFloorLabel
        //        //    selectedResolutionLabel
        //    }
        //    catch (Exception)
        //    {
        //        // works on selected index changed
        //    }
        //}
    }
}
