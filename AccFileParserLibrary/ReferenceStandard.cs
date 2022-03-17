using System;
using System.Collections.Generic;
using System.Text;

namespace AccFileParserLibrary
{
    public class ReferenceStandard 
    {
        public string instrument { get; set; }
        public int interval { get; set; } // numeric value, never decimal
        public string intervalUnit { get; set; } // hours, months, days, year
        public double confidence { get; set; } // numeric value, must be double
        public string confidenceUnit { get; set; } // unit - sigma
        public string comments { get; set; }
        public Dictionary<string, Function> modeDictionary; // lines are called 'Function', Function object holds the list of ranges,
        public Dictionary<string, Function> exceptDictionary;                                                         // taxon will also inside the function class, taxon is a string
        public List<string> modeList;
        // Mode is function, and all of the lines are ranges 
        // RangeAcc


        public ReferenceStandard()
        {
            modeDictionary = new Dictionary<string, Function>();
            exceptDictionary = new Dictionary<string, Function>();
            modeList = new List<string>();
            comments = "";
        }

        public void AddToModeDictionary(string key, Function value) 
        {
            try
            {
                modeDictionary.Add(key, value); // same keys (modes, Volts TC in 5520)
            }
            catch(Exception e)
            {
                exceptDictionary.Add(key, value);
            }
        }

        public void createModeList()
        {
            foreach (KeyValuePair<string, Function> item in modeDictionary) 
            {
                modeList.Add(item.Key);
            }
        }

        public string returnContent() 
        {
            string str = "";

            foreach (KeyValuePair<string, Function> item in modeDictionary)
            {
                str += "Mode: " + item.Key + ":\n";
                str += item.Value.returnContent();
                str += "\n";
            }

            str += "\n\n\nExceptions:\n";
            foreach (KeyValuePair<string, Function> item in exceptDictionary)
            {
                str += "Mode: " + item.Key + ":\n";
                str += item.Value.returnContent();
                str += "\n";
            }
            
            return str;
        }

        public string returnHeaderAndComments()
        {
            string str = "";
            str += "instrument: " + instrument + "\n";
            str += "interval: " + interval.ToString() + " " + intervalUnit + "\n";
            str += "confidence: " + confidence.ToString() + " " + confidenceUnit + "\n";
            str += "\n";
            str += comments;
            str += "\n\n";
            return str;
        }

        public void clearContent()
        {
            instrument = String.Empty;
            interval = int.MinValue;
            intervalUnit = String.Empty;
            confidence = double.MinValue;
            confidenceUnit = String.Empty;
            comments = String.Empty;
            modeDictionary.Clear();
            exceptDictionary.Clear();
            modeList.Clear();
        }
    }
}
