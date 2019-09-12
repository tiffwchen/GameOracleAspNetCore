using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GameOracle.Models
{
    public class Game
    {
        // I think you can create a non-mutable object like this... 
        public int Id { get; set; }
        public string Name { get; private set; }
        public int MinPlayers { get; private set; }
        public int MaxPlayers { get; private set; }
        public bool IsExpansion { get; }
        // only not null if isExpansion is true
        public int BaseGameId { get; }
        //public ReadOnlyCollection<GameGenres> Genre { get; }

        public Game(string name,int minPlayers, int maxPlayers)
        {
            Name = name;
            MinPlayers = minPlayers;
            MaxPlayers = maxPlayers;
        }
    }
}
