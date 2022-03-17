using System;
using System.Collections.Generic;
using System.Text;

namespace AccFileParserLibrary
{
    public class RangeLimit
    {
        public AttributeValue lowerLimit { get; set; }
        public AttributeValue upperLimit { get; set; }

        public RangeLimit(AttributeValue aLowerLimit, AttributeValue aUpperLimit)
        {
            lowerLimit = aLowerLimit;
            upperLimit = aUpperLimit;
        }

        public string returnContent() 
        {
            string str = "";
            str += lowerLimit.returnContent() + upperLimit.returnContent();
            return str;
        }

        public bool isInLimit(Double value) 
        {
            if (lowerLimit.doubleValue <= value && value <= upperLimit.doubleValue)
                return true;
            else
                return false;
        }
    }
}
