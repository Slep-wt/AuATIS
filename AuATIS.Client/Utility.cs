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

namespace AuATIS.Client
{
    public static class Utility
    {
        static readonly string ProfileDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\vatSys Files\\Profiles";

        public static readonly IDictionary<string, string> Profiles = GetProfiles();

        internal static Dictionary<string, string> GetProfiles()
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
    }
}
