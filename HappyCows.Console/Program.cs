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
    }
}
