using System;
using System.Collections.Generic;
using System.Text;

namespace AccFileParserLibrary
{
    public class RangeAcc
    {
        public RangeLimit nominal { get; set; }
        public RangeLimit mod1 { get; set; }
        public AttributeValue tolerance { get; set; }
        public AttributeValue floor { get; set; }
        public AttributeValue resolution { get; set; }

        public RangeAcc()
        {
            
        }

        public string returnContent()
        {
            string str = "";
            str += nominal.returnContent().Trim() + "\t\t";
            str += mod1.returnContent().Trim() + "\t\t";
            str += tolerance.returnContent().Trim() + "\t\t";
            str += floor.returnContent().Trim() + "\t\t";
            str += resolution.returnContent().Trim();
            return str;
        }

        public String[] returnRange() // returns 7 values as a string array
        {
            String[] strList = {"", "", "", "", "", "", ""};
            strList[0] = nominal.lowerLimit.returnContent().Trim();
            strList[1] = nominal.upperLimit.returnContent().Trim();
            strList[2] = mod1.lowerLimit.returnContent().Trim();
            strList[3] = mod1.upperLimit.returnContent().Trim();
            strList[4] = tolerance.returnContent().Trim();
            strList[5] = floor.returnContent().Trim();
            strList[6] = resolution.returnContent().Trim();
            return strList;
        }
    }
}
