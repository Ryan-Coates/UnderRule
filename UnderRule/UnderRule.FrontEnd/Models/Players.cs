using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnderRule.FrontEnd.Models
{
    public class Players
    {
        public List<Player> _Players { get; set; }
    }
    public class Player
    {
        public string Name { get; set; }
        public int Farm { get; set; }
        public int Castle { get; set; }
    }
}
