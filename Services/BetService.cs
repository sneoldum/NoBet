using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;
using NoBet.Models;

namespace NoBet.Services
{
    public class BetService
    {
        public BetModel GetAllMatches() {
            
            var webClient = new WebClient();
            string url = string.Concat("https://sportsbook.iddaa.com/sportsbook/events?st=1&type=0&version=0");

            string json = new WebClient().DownloadString(url);
            BetModel? betData = JsonSerializer.Deserialize<BetModel>(json);
            betData.json = json;
            Console.WriteLine(betData.Datas);

            return betData;

        }

        public MatchModel GetMatchById(int id)
        {
            var webClient = new WebClient();
            string url = string.Concat($"https://sportsbook.iddaa.com/sportsbook/event/{id}");

            string json = new WebClient().DownloadString(url);
            MatchModel? betData = JsonSerializer.Deserialize<MatchModel>(json);
            betData.json = json;
            return betData;
        }

    }
}
