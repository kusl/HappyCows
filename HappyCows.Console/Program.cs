using System.Net;
using System.Text;

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
                var summonerInformation = GetSummonerInformationByName(client: client, apiKey: apiKey, summonerName: "kkus");
                System.Console.WriteLine(summonerInformation);
                var championInformation = GetAllChampionInformaiton(client: client, apiKey: apiKey);
                System.Console.WriteLine(championInformation);
                System.Console.Read();
                var summonerLeague = GetLeagueBySummoner(client: client, apiKey: apiKey, summonerId: "20582960");
            }
        }

        private static string GetSummonerInformationByName(WebClient client, string apiKey, string summonerName)
        {
            const string urlPrefix = "https://na.api.pvp.net/api/lol/na/v1.4/summoner/";
            const string roster = "by-name";
            var apiKeySuffix = "?api_key=" + apiKey;
            return client.DownloadString(urlPrefix + roster + "/" + summonerName + apiKeySuffix);
        }

        private static string GetAllChampionInformaiton(WebClient client, string apiKey)
        {
            const string urlPrefix = "https://na.api.pvp.net/api/lol/na/v1.2/champion";
            var apiKeySuffix = "?api_key=" + apiKey;
            return client.DownloadString(urlPrefix + apiKeySuffix);
        }

        //https://na.api.pvp.net/api/lol/na/v2.5/league/by-summoner/' + SUMMONER_ID + '/entry?api_key=' + API_KEY
        //https://na.api.pvp.net/api/lol/na/v2.5/league/by-summoner/20582960/entry?api_key=
        private static string GetLeagueBySummoner(WebClient client, string apiKey, string summonerId)
        {
            const string urlPrefix = "https://na.api.pvp.net/api/lol/na/v2.5/league/by-summoner/";
            var apiKeySuffix = "/entry?api_key=" + apiKey;
            return client.DownloadString(urlPrefix + summonerId + apiKeySuffix);
        }
    }
}
