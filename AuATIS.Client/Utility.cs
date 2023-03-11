using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.ComponentModel.Design.Serialization;
using System.Reflection;
using System.Runtime;
using System.Timers;
using System.Diagnostics.Eventing.Reader;

namespace AuATIS.Client
{
    public class Utility
    {
        readonly string ProfileDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\vatSys Files\\Profiles";
        public IDictionary<string, string> Profiles { get; }

        public Utility()
        {
            Profiles = GetProfiles();
        }

        internal Dictionary<string, string> GetProfiles()
        {
            Dictionary<string, string> Lookup = new Dictionary<string, string>();
            try
            {
                string[] ProDir = Directory.GetDirectories(ProfileDir);
                foreach (string x in ProDir)
                {
                    Lookup.Add(new DirectoryInfo(x).Name, x);
                }
            }
            catch (Exception e)
            {
                Session.LogThis("[Utility.GetProfiles()] " + e.Message);
            }

            return Lookup;
        }


    }

    public struct EditorValue
    {
        public string Name;
        public string Value;
        public bool NameIsSpoken;
        public string InputType;
        public bool NumbersSpokenGrouped;

        public EditorValue()
        {
            Name = "";
            Value = "";
            NameIsSpoken = false;
            InputType = ""; 
            NumbersSpokenGrouped = true;
        }
    }

    public class ATISOrder
    {
        private List<EditorValue> Order;
        public List<EditorValue> Table { get; }
        public ATISOrder()
        {

        }

        public ATISOrder(string Profile)
        {
            Order = Init(Profile);
        }

        public void Initialise(string Profile)
        {
            Order = Init(Profile);
        }

        public List<EditorValue> Init(string Profile)
        {
            List<EditorValue> EVL = new List<EditorValue>();
            try
            {
                var ATISXml = XElement.Load(Program.UtilityHandle.Profiles[Profile] + "\\ATIS.xml");

                var Inputs = ATISXml.Elements("Editor").Elements();
                foreach (var i in Inputs)
                {
                    EditorValue EV = new EditorValue();

                    IEnumerable<XAttribute> Attribs = i.Attributes();
                    foreach (var x in Attribs)
                    {
                        switch (x.Name.ToString())
                        {
                            case "name":
                                EV.Name = x.Value;
                                break;
                            case "value":
                                EV.Value = x.Value;
                                break;
                            case "NameIsSpoken":
                                if (x.Value.ToString() == "true")
                                    EV.NameIsSpoken = true;
                                else
                                    EV.NameIsSpoken = false;
                                break;
                            case "InputType":
                                EV.InputType = x.Value;
                                break;
                            case "NumbersSpokenGrouped":
                                if (x.Value.ToString() == "true")
                                    EV.NumbersSpokenGrouped = true;
                                else
                                    EV.NumbersSpokenGrouped = false;
                                break;
                        }
                    }
                    EVL.Append(EV);
                }
            } catch (Exception e)
            {
                Session.LogThis("[ATISOrder.Initialise()] " + e.Message);
                return EVL;
            }
            return EVL;
        }
    }

    internal class Session
    {
        internal static readonly string AsmDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static readonly string StartTime = DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss"); // Generates origin timestamp
        public static async void LogThis(object input)  // Crappy logger I threw together in a few mins
        {
            if (Directory.Exists(AsmDir + @"\Logs"))
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(AsmDir + @"\Logs\AuATIS_" + StartTime + ".log", true, Encoding.UTF8))
                    {
                        string curdate = DateTime.Now.ToString(@"[dd/MM/yyyy hh:mm:ss]");
                        await sw.WriteLineAsync(curdate + input);
                    }
                }
                catch (Exception e)
                {
                    LogThis(e.Message);
                }
            }
            else
            {
                Directory.CreateDirectory(AsmDir + @"\Logs");
                LogThis(input);
            }
        }
        public static async void GetUTC()
        {
           //DateTime.UtcNow.ToShortTimeString();
        }
    }
}
