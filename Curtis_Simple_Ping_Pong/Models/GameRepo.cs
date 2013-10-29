using System;
using System.Collections.Generic;

namespace Curtis_Simple_Ping_Pong
{
    [Serializable()]
    public class GameRepo
    {
        public List<Game> GameHistory { get; set; }
    }
}
