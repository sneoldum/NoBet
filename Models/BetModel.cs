﻿using System.Collections;
using System.Diagnostics.Tracing;
using Newtonsoft.Json;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using static NoBet.Models.BetModel;

namespace NoBet.Models
{

    public class BetModel
    {
        public string json { get; set; }
        [JsonPropertyName("isSuccess")]
        public bool isSuccess { get; set; }

        [JsonPropertyName("data")]
        public Data Datas { get; set; }

        public class Data
        {
            [JsonPropertyName("isdiff")]
            public bool isDiff { get; set; }

            [JsonPropertyName("version")]
            public long version { get; set; }

            [JsonPropertyName("events")]
            public List<Event> events { get; set; }

        }

        public class Event
        {
            [JsonPropertyName("i")]
            public int i { get; set; }

            [JsonPropertyName("bri")]
            public int bri { get; set; }

            [JsonPropertyName("v")]
            public int v { get; set; }

            [JsonPropertyName("hn")]
            public string hn { get; set; }

            [JsonPropertyName("an")]
            public string an { get; set; }

            [JsonPropertyName("sid")]
            public int sid { get; set; }

            [JsonPropertyName("s")]
            public int s { get; set; }

            [JsonPropertyName("bp")]
            public int bp { get; set; }

            [JsonPropertyName("il")]
            public bool il { get; set; }

            [JsonPropertyName("mbc")]
            public int mbc { get; set; }

            [JsonPropertyName("kOdd")]
            public bool kOdd { get; set; }

            [JsonPropertyName("m")]
            public List<Match> m { get; set; }

            [JsonPropertyName("ci")]
            public int ci { get; set; }

            [JsonPropertyName("oc")]
            public int oc { get; set; }

            [JsonPropertyName("d")]
            public long d { get; set; }

        }

        public class Match
        {
            [JsonPropertyName("i")]
            public int I { get; set; }
            [JsonPropertyName("t")]
            public int T { get; set; }
            [JsonPropertyName("st")]
            public int St { get; set; }
            [JsonPropertyName("v")]
            public int V { get; set; }
            [JsonPropertyName("s")]
            public int S { get; set; }
            [JsonPropertyName("mbc")]
            public int Mbc { get; set; }
            [JsonPropertyName("sov")]
            public string Sov { get; set; }
            [JsonPropertyName("o")]
            public List<Outcome> o { get; set; }
        }

        public class Outcome
        {
            [JsonPropertyName("no")]
            public int No { get; set; }
            [JsonPropertyName("odd")]
            public double Odd { get; set; }
            [JsonPropertyName("wodd")]
            public double WOdd { get; set; }
            [JsonPropertyName("n")]
            public string N { get; set; }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class MatchModel
    {
        public string json { get; set; }

        [JsonPropertyName("isSuccess")]
        public bool isSuccess { get; set; }

        [JsonPropertyName("data")]
        public Data Datas { get; set; }

        public class Data
        {
            [JsonPropertyName("i")]
            public int i { get; set; }

            [JsonPropertyName("bri")]
            public int bri { get; set; }

            [JsonPropertyName("v")]
            public int v { get; set; }

            [JsonPropertyName("hn")]
            public string hn { get; set; }

            [JsonPropertyName("an")]
            public string an { get; set; }

            [JsonPropertyName("sid")]
            public int sid { get; set; }

            [JsonPropertyName("s")]
            public int s { get; set; }

            [JsonPropertyName("bp")]
            public int bp { get; set; }

            [JsonPropertyName("il")]
            public bool il { get; set; }

            [JsonPropertyName("mbc")]
            public int mbc { get; set; }

            [JsonPropertyName("kOdd")]
            public bool kOdd { get; set; }

            [JsonPropertyName("m")]
            public List<Match> m { get; set; }

            [JsonPropertyName("ci")]
            public int ci { get; set; }

            [JsonPropertyName("oc")]
            public int oc { get; set; }

            [JsonPropertyName("d")]
            public long d { get; set; }
        }
        public class Match
        {
            [JsonPropertyName("i")]
            public int i { get; set; }
            [JsonPropertyName("t")]
            public int t { get; set; }
            [JsonPropertyName("st")]
            public int st { get; set; }
            [JsonPropertyName("v")]
            public int v { get; set; }
            [JsonPropertyName("s")]
            public int s { get; set; }
            [JsonPropertyName("mbc")]
            public int mbc { get; set; }
            [JsonPropertyName("sov")]
            public string sov { get; set; }
            [JsonPropertyName("o")]
            public List<Outcome> o { get; set; }
        }
        public class Outcome
        {
            [JsonPropertyName("no")]
            public int no { get; set; }
            [JsonPropertyName("odd")]
            public double odd { get; set; }
            [JsonPropertyName("wodd")]
            public double wOdd { get; set; }
            [JsonPropertyName("n")]
            public string n { get; set; }
        }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
