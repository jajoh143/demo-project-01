using System;
using System.Collections.Generic;

namespace dotnet_test_project_2.Models
{
    public class MonsterList
    {
        public int Count { get; set; }
        List<MonsterListResultDetail> Results { get; set; }

        public string getMonsterApiEndpoint()
        {
            Random rand = new Random();
            return this.Results[rand.Next(Count)].Url;
        }

        internal class MonsterListResultDetail
        {
            public string Index { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }
    }
}