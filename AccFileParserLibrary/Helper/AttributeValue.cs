using System;
using System.Collections.Generic;
using System.Text;

namespace AccFileParserLibrary
{
    public class AttributeValue
    {
        public double doubleValue { get; set; }
        public string strValue { get; set; }

        // flags to indicate which value used
        public bool doubleValueFlag { get; set; }
        public bool strValueFlag { get; set; }

        public AttributeValue(string aStrValue)
        {
            if (aStrValue == "NA") // if the file doesn't have numeric value for a limit, else it must be a double...
            {
                strValue = aStrValue;
                strValueFlag = true;
                doubleValue = 0.0;
                doubleValueFlag = false;
            }
            else
            {
                doubleValue = Double.Parse(aStrValue);
                strValue = aStrValue; // to help printing scientific notation
                doubleValueFlag = true;
                strValueFlag = false;
            }
        }
      
        public string returnContent()
        {
            string str = "";
            if (doubleValueFlag)
            {
                if (strValue.Contains("E") || strValue.Contains("e")) // scientific notation
                {
                    str += string.Format("{0:#.##E+0}", doubleValue) + "  ";
                }
                else
                    str += doubleValue.ToString() + "  ";
            }
            else if (strValueFlag) str += strValue + "  ";
            return str;
        }
    }
}
