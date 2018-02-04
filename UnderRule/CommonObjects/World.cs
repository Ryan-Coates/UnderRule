using System;
using System.Collections.Generic;
using System.Text;

namespace CommonObjects
{
    /// <summary>
    /// contains all the bits for the world
    /// </summary>
    public class World
    {
        public List<OtherPlayer> OtherPlayers { get; set; }
        public Player Player { get; set; }
    }
}
