using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace relationships
{
    public class Users
    {
        public int Id {get;set;}
        public string Username {get;set;} = string.Empty;
        public List<Characters> Characters {get;set;}
    }
}