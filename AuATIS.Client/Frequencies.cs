using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Resolvers;

namespace AuATIS.Client
{
    public class Frequencies
    {
        private IDictionary<string, string> LookupTable;

        public string Find(string ICAO)
        {
            string QResult;
            try
            {
                QResult = LookupTable[ICAO];
            } 
            catch (Exception e)
            {
                Session.LogThis("[Frequencies.Find()] " + e.Message);
                QResult = "199.998";
            }
                
            return QResult;
        }

        public IDictionary<string, string> Table
        {
            get { return LookupTable; }
        }

        public Frequencies(string profile)
        {
            LookupTable = Initialise(profile);
        }

        public Frequencies()
        {

        }

        public string this[string key]
        {
            get
            {
                return Find(key);
            }
        }

        public Dictionary<string, string> Initialise(string Profile)
        {
            Dictionary<string, string> TempDic = new Dictionary<string, string>();
            try
            {
                var ATISXml = XElement.Load(Program.UtilityHandle.Profiles[Profile] + "\\ATIS.xml");

                var Frequencies = ATISXml.Elements("Frequencies").Elements();
                foreach (var f in Frequencies)
                {
                    TempDic.Add((string)f.Attribute("Airport"), (string)f.Attribute("Frequency"));
                }

            }
            catch (Exception e)
            {
                Session.LogThis("[Frequencies.GetFreqs()] " + e.Message);
            }

            return TempDic;
        }
    }
}
