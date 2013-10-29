using System;

namespace Curtis_Simple_Ping_Pong
{
    [Serializable()]
    public class Game
    {
        public Player Winner { get; set; }
        public Player Loser { get; set; }
    }
}
