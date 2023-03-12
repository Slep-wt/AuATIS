using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace AuATIS.Client
{
    public class Configuration
    {
        public UserConfiguration user { get; set; }
    }

    public class UserConfiguration
    {
        public string name { get; set; }
        public string cid { get; set; }
        public int rating { get; set; }
        public string server { get; set; }
        public string profile { get; set; }
        public UserConfiguration() { }
        public UserConfiguration(string Name, string Cid, int Rating, string Server, string Profile)
        {
            this.name = Name;
            this.cid = Cid;
            this.rating = Rating;
            this.server = Server;
            this.profile = Profile;
        }
    }

    public class SystemConfig
    {
        public Configuration Config { get; set; }
        internal readonly string FileDir = Session.AsmDir + "\\config.json";
        public SystemConfig()
        {
            GetData();
        }

        private void GetData()
        {
            if (File.Exists(FileDir))
            {
                try
                {
                    string RawData = File.ReadAllText(Session.AsmDir + "\\config.json");
                    Config = JsonConvert.DeserializeObject<Configuration>(RawData);
                } 
                catch (Exception e)
                {
                    Session.LogThis("[SystemConfig.GetData()] " + e.Message);
                }

            } 
            else
            {
                try
                {
                    Config = new Configuration();
                    Config.user = new UserConfiguration("", "123456", 1, "AUTOMATIC", "");
                    SaveData();
                }
                catch (Exception e)
                {
                    Session.LogThis("[SystemConfig.GetData()] " + e.Message);
                }
            }
        }

        public void SaveData()
        {
            try
            {
                File.WriteAllText(FileDir, JsonConvert.SerializeObject(Config, Formatting.Indented));
            }
            catch (Exception e) 
            {
                Session.LogThis("[SystemConfig.SaveData()] " + e.Message);
            }
        }
    }
}
