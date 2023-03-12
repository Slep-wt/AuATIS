using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Collections.Specialized;

namespace AuATIS.Client
{
    public class Api
    {
        public readonly string METARUrl = "http://metar.vatsim.net/metar.php";
        public async Task<string> HttpGet(string url)
        {
            string result;
            using (HttpClient client = new HttpClient())
            {
                result = await client.GetStringAsync(url);
            }
            return result;
        }

        //Add Auto JSON decode for urls and whatnot
    }
}
