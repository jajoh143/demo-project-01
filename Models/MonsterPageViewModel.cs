using System;
using System.Net.Http;
using Json.Net;

namespace dotnet_test_project_2.Models
{
    public class MonsterPageViewModel
    {
       public Monster Monster { get; set; }

       MonsterPageViewModel() 
       {
          
       }

       public async void getMonster() 
       {
            using (HttpClient http = new HttpClient())
           {
               var jsonMonsters = await http.GetAsync("https://www.dnd5eapi.co/api/monsters");
               MonsterList monsterList = JsonNet.Deserialize<MonsterList>(jsonMonsters.Content.ToString());
               string randomMonsterApiEndpoint = monsterList.getMonsterApiEndpoint();
               
               var jsonMonsterDetail = await http.GetAsync("https://www.dnd5eapi.co/api/monsters/" + randomMonsterApiEndpoint);
               Console.WriteLine(jsonMonsterDetail);
               
           }
       }
    }
}
