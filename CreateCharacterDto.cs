using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace relationships
{
    public class CreateCharacterDto
    {
        public string Name {get;set;} = "Character";
        public string RpgClass {get;set;} = "Knight";
        public int UserId {get;set;}=1;
    }
}