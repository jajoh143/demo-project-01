using System;
using System.Net.Http;

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
               string jsonMonsters = await http.GetStringAsync("https://www.dnd5eapi.co/api/monsters");
               
           }
       }
    }
}
