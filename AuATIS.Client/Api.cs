using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Collections.Specialized;
using Vatsim.Network;

namespace AuATIS.Client
{
    public class ServerInfo
    {
        public string ident { get; set; }
        public string hostname_or_ip { get; set; }
        public string location { get; set; }
        public string name { get; set; }
        public int clients_connection_allowed { get; set; }
        public bool client_connections_allowed { get; set; }
        public bool is_sweatbox { get; set; }
    }

    public class VatsimServerApi
    {
        public List<ServerInfo> servers { get; set; }
    }

    public class DataApi
    {
        public List<string> v3 { get; set; }
        public List<string> transceivers { get; set; }
        public List<string> servers_all { get; set; }
    }

    public class VatsimApi
    {
        public DataApi data { get; set; }
        public List<string> user { get; set; }
        public List<string> metar { get; set; }
    }

    public class Api
    {
        public readonly string ApiUrl = "https://status.vatsim.net/status.json";

        public IDictionary<string, ServerInfo> Servers;
        public IDictionary<string, int> Ratings;
        public IDictionary<int, string> RatingsReverseL;

        public bool Available { get; set; }

        public VatsimApi StatusApi { get; set; }
        public VatsimServerApi ServerApi { get; set; }
        
        public async Task<string> HttpGet(string url)
        {
            string result;
            using (HttpClient client = new HttpClient())
            {
                result = await client.GetStringAsync(url);
            }
            return result;
        }

        public Api()
        {
            Available = false;
            Initialise();
            CreateDictionaries();
        }

        public void Initialise()
        {
            try
            {
                string RawJSON = HttpGet(ApiUrl).Result;
                StatusApi = JsonConvert.DeserializeObject<VatsimApi>(RawJSON);
            } 
            catch (Exception e)
            {
                Session.LogThis("[Api.GetStatus()] " + e.Message);
            }

            if (StatusApi != null)
            {
                ServerApi = new VatsimServerApi();
                try
                {
                    string RawJSON = HttpGet(StatusApi.data.servers_all[0]).Result;
                    ServerApi.servers = JsonConvert.DeserializeObject<List<ServerInfo>>(RawJSON);
                } 
                catch (Exception e)
                {
                    Session.LogThis("[Api.GetStatus()] " + e.Message);
                }
            }
            Available = true;
        }

        public void CreateDictionaries()
        {
            Servers = new Dictionary<string, ServerInfo>();
            Ratings = Enum.GetValues(typeof(NetworkRating)).Cast<NetworkRating>().ToDictionary(t => t.ToString(), t => (int)t);
            RatingsReverseL = Ratings.ToDictionary(x => x.Value, x => x.Key);

            foreach (ServerInfo x in ServerApi.servers)
            {
                Servers.Add(x.ident, x);
            }
        }

        //Add Auto JSON decode for urls and whatnot
    }
}
