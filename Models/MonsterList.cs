using System;
using System.Collections.Generic;

namespace dotnet_test_project_2.Models
{
    public class MonsterList
    {
        public int Count { get; set; }
        public List<KeyValuePair<string, string>> Results { get; set;}
    }
}