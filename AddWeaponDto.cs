using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace relationships
{
    public class AddWeaponDto
    {
        public string Name {get;set;} = string.Empty;
        public int Damage {get;set;} = 10;
        public int CharacterId { get; set; }
    }
}