using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace relationships
{
    public class Skills
    {
        public int Id {get;set;}
        public string Name {get;set;} = string.Empty;
        public int Damage {get;set;} = 10;
        [JsonIgnore]
        public List<Characters> Characters {get;set;}
    }
}