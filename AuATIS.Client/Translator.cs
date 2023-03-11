using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AuATIS.Client
{
    public struct Translation
    {
        public string Phrase { get; set; }
        public string Spoken { get; set; }
        public bool Regex { get; set; }
        public bool Phonetic { get; set; }
        public string Fallback { get; set; }

        public Translation()
        {
            Phrase = "";
            Spoken = "";
            Regex = false;
            Phonetic = false;
            Fallback = "";
        }
    }



    public class Translator
    {

        private IDictionary<string, Translation> LookupTable;

        public IDictionary<string, Translation> Table
        {
            get { return LookupTable; }
        }

        public Translation Find(string Phrase) 
        {
            Translation QResult = new Translation();
            try
            {
                QResult = LookupTable[Phrase];
            }
            catch (Exception e)
            {
                Session.LogThis("[Translation.Find()] " + e.Message);
                QResult.Phrase="TRANSLATION NOT FOUND";
            }

            return QResult;
        }

        public Translation this[string Key]
        {
            get
            {
                return Find(Key);
            }
        }

        public Translator(string Profile)
        {
            LookupTable = GetTranslations(Profile);
        }

        private Dictionary<string, Translation> GetTranslations(string Profile)
        {
            Dictionary<string, Translation> TempDic = new Dictionary<string, Translation>();
            try
            {
                var ATISXml = XElement.Load(Utility.Profiles[Profile] + "\\ATIS.xml");

                var Translations = ATISXml.Elements("Translations").Elements();
                foreach (var t in Translations)
                {
                    Translation TR = new Translation();

                    IEnumerable<XAttribute> Attribs = t.Attributes();

                    foreach (var a in Attribs)
                    {
                        switch (a.Name.ToString())
                        {
                            case "String":
                                TR.Phrase = a.Value;
                                break;
                            case "Regex":
                                TR.Phrase = a.Value;
                                TR.Regex = true;
                                break;
                            case "Spoken":
                                TR.Spoken = a.Value;
                                break;
                            case "Alphabet":
                                TR.Phonetic = true;
                                break;
                            case "FallbackSpoken":
                                TR.Fallback = a.Value;
                                break;
                        }
                    }
                    TempDic.Add(TR.Phrase, TR);
                }

            }
            catch (Exception e)
            {
                Session.LogThis("[Translator.GetTranslations()] " + e.Message);
            }

            return TempDic;
        }

    }
}
