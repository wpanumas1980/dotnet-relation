using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace relationships
{
    public class Characters
    {
        public int Id {get;set;}
        public string Name {get;set;} = string.Empty;
        public string RpgClass {get;set;} = "Knight";
        [JsonIgnore]
        public Users User {get;set;}
        public int UserId {get;set;}
        public Weapons Weapon {get;set;}
        public List<Skills> Skills {get;set;}
        
    }
}