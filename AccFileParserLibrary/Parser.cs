using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace AccFileParserLibrary
{
    public class Parser
    {
        private string fileContent { get; set; }
        public ReferenceStandard refStd;
        public Function selectedFunction;

        // flags - indicating the region currently being read
        private bool readingValues = false;
        private bool isFirstMode = false; // to separate mode blocks

        public Parser()
        {
            refStd = new ReferenceStandard();
        }

        public void loadFileContent(string aFileContent) 
        {
            fileContent = aFileContent;
            parseContent();
        }

        private void parseContent()
        {
            if(fileContent == "") 
            {
                return;        
            }
            using var sr = new StringReader(fileContent);
            string line;

            #region reading the header
            while ((line = sr.ReadLine()) != null)
            {
                line = System.Text.RegularExpressions.Regex.Replace(line, @"\s+", " ");
                if (line.Contains("Begin Header")) continue;
                else if (line.Contains("End Header")) break;
                else if (line.Contains("instrument"))
                {
                    string tempstr = line.Trim();
                    string[] tempstrlist = tempstr.Split("=");
                    refStd.instrument = tempstrlist[1].Trim();
                }
                else if (line.Contains("interval"))
                {
                    string tempstr = line.Trim();
                    string[] tempstrlist = tempstr.Split("=");
                    string[] templistValueUnit = tempstrlist[1].Trim().Split(" ");
                    refStd.interval = Int32.Parse(templistValueUnit[0].Trim());
                    refStd.intervalUnit = templistValueUnit[1].Trim();
                }
                else if (line.Contains("confidence"))
                {
                    string tempstr = line.Trim();
                    string[] tempstrlist = tempstr.Split("=");
                    string[] templistValueUnit = tempstrlist[1].Trim().Split(" ");
                    refStd.confidence = Double.Parse(templistValueUnit[0].Trim());
                    refStd.confidenceUnit = templistValueUnit[1].Trim();
                }
            }
            #endregion

            #region reading comments
            while ((line = sr.ReadLine()) != null)
            {
                line = System.Text.RegularExpressions.Regex.Replace(line, @"\s+", " ");
                if (line.Contains("#") || line.Trim() == "") refStd.comments += line + "\n";
                else if(line.Contains("Mode") || line.Contains("Mode"))
                {
                    readingValues = true;
                    break;
                }
            }
            #endregion

            #region reading values
            // string line contains the first "Mode:..." line from previous region
            isFirstMode = true;
            string currentMode = "";
            string[] tempStringList = line.Split(":");
            currentMode = tempStringList[1].Trim();
            Function currentFunction = new Function();
            
            //List<string> temp_valueList = new List<string>();
            
            while (true)
            {
                line = sr.ReadLine();
                if (line == null) break;
                line = System.Text.RegularExpressions.Regex.Replace(line, @"\s+", " ");

                if (line.Contains("Mode"))
                {
                    refStd.AddToModeDictionary(currentMode, currentFunction);
                    currentMode = "";
                    currentFunction = new Function();
                    string[] tempStrList = line.Split(":");
                    currentMode = tempStrList[1].Trim();
                    continue;
                }
               
                if (line.Contains("#")) continue;
                else if(line.Trim() == "") continue;
                else 
                {
                    RangeAcc currentRangeAcc = new RangeAcc();
                    string[] tempStrList = line.Trim().Split(" "); // 7 elements must be obtained
                    AttributeValue lowerLimitNominal = new AttributeValue(tempStrList[0].Trim());
                    AttributeValue upperLimitNominal = new AttributeValue(tempStrList[1].Trim());
                    RangeLimit currentNominal = new RangeLimit(lowerLimitNominal, upperLimitNominal);

                    AttributeValue lowerLimitMod1 = new AttributeValue(tempStrList[2].Trim());
                    AttributeValue upperLimitMod1 = new AttributeValue(tempStrList[3].Trim());
                    RangeLimit currentMod1 = new RangeLimit(lowerLimitMod1, upperLimitMod1);

                    AttributeValue currentTolerance = new AttributeValue(tempStrList[4].Trim()); ; // can be string/double
                    AttributeValue currentFloor = new AttributeValue(tempStrList[5].Trim()); // can be string/double
                    AttributeValue currentResolution = new AttributeValue(tempStrList[6].Trim()); // can be string/double

                    currentRangeAcc.nominal = currentNominal;
                    currentRangeAcc.mod1 = currentMod1;
                    currentRangeAcc.tolerance = currentTolerance;
                    currentRangeAcc.floor = currentFloor;
                    currentRangeAcc.resolution = currentResolution;

                    currentFunction.rangeList.Add(currentRangeAcc);
                    currentRangeAcc = new RangeAcc();
                    // break; // break after first value line
                }
                
            }

            if (currentMode != "" && currentFunction != null) 
            {
                refStd.AddToModeDictionary(currentMode, currentFunction);
            }

            refStd.createModeList();

            #endregion

        }
    }
}
