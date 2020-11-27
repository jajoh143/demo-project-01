using System;

namespace dotnet_test_project_2.Models
{
    public class Monster
    {
       public string Name { get; set; }
       
       public string Size { get; set; }
       
       public string Type { get; set; }

       public string Subtype {get; set; }

       public string Alignment { get; set; }

       public int ArmorClass { get; set; }

       public int HitPoints { get; set; }

       public string[] Languages { get; set; }
    }
}
