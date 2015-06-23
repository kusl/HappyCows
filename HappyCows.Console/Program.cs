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
                //client.Encoding = Encoding.UTF8;
                //var summonerInformation = GetSummonerInformationByName(client: client, apiKey: apiKey, summonerName: "kkus");
                //System.Console.WriteLine(summonerInformation);
                //var championInformation = GetAllChampionInformaiton(client: client, apiKey: apiKey);
                //System.Console.WriteLine(championInformation);
                //System.Console.Read();
                //var summonerLeague = GetLeagueBySummoner(client: client, apiKey: apiKey, summonerId: "20582960");
                var summonerLeague =
                    "{\"20582960\":[{\"name\":\"Corki's Buddies\",\"tier\":\"GOLD\",\"queue\":\"RANKED_SOLO_5x5\",\"entries\":[{\"playerOrTeamId\":\"20582960\",\"playerOrTeamName\":\"Best Dictator NK\",\"division\":\"IV\",\"leaguePoints\":39,\"wins\":26,\"losses\":26,\"isHotStreak\":false,\"isVeteran\":false,\"isFreshBlood\":false,\"isInactive\":false}]},{\"name\":\"Malzahar's Berserkers\",\"tier\":\"BRONZE\",\"queue\":\"RANKED_TEAM_5x5\",\"entries\":[{\"playerOrTeamId\":\"TEAM-29dfa190-fa7b-11e3-9c89-782bcb4d1861\",\"playerOrTeamName\":\"Fing Go Time\",\"division\":\"IV\",\"leaguePoints\":74,\"wins\":3,\"losses\":7,\"isHotStreak\":false,\"isVeteran\":false,\"isFreshBlood\":false,\"isInactive\":false}]},{\"name\":\"Wukong's Dervish\",\"tier\":\"GOLD\",\"queue\":\"RANKED_TEAM_5x5\",\"entries\":[{\"playerOrTeamId\":\"TEAM-a743b670-bc91-11e4-98cf-c81f66dd45c9\",\"playerOrTeamName\":\"Cuti3 Patooties\",\"division\":\"V\",\"leaguePoints\":26,\"wins\":10,\"losses\":5,\"isHotStreak\":false,\"isVeteran\":false,\"isFreshBlood\":false,\"isInactive\":false}]}]}";
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
