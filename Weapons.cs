using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace relationships
{
    public class Weapons
    {
        public int Id {get;set;}
        public string Name {get;set;} = string.Empty;
        public int Damage {get;set;} = 10;
        [JsonIgnore]
        public Characters Character {get;set;}
        public int CharacterId {get;set;}
    }
}