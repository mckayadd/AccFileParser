using System;
using System.Collections.Generic;
using System.Text;

namespace AccFileParserLibrary
{
    public class Function
    {
        public string taxon { get; set; } 
        public List<RangeAcc> rangeList { get; set; }

        public Function()
        {
            rangeList = new List<RangeAcc>();
        }

        public string returnContent() 
        {
            string str = "";
            //string str = "# Nominal "
            foreach (RangeAcc item in rangeList)
            {
                str += item.returnContent();
                str += "\n";
            }
            return str;
        }
    }
}
