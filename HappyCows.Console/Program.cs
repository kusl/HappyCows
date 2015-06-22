using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HappyCows.Console
{
    static class Program
    {
        static void Main(string[] args)
        {
            const string apiKey = "";
            using (var client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                const string urlPrefix = "https://na.api.pvp.net/api/lol/na/v1.4/summoner/";
                const string roster = "by-name";
                const string myName = "kkus";
                string apiKeySuffix = "?api_key=" + apiKey;
                var myJson = client.DownloadString(urlPrefix + roster + "/" + myName + apiKeySuffix);
                System.Console.Write(myJson);
                System.Console.Read();
            }
        }
    }
}
