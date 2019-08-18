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
        public int Id { get; }
        public string Name { get; }
        public int MinPlayers { get; }
        public int MaxPlayers { get; }
        public bool IsExpansion { get; }
        // only not null if isExpansion is true
        public int BaseGameId { get; }
        public ReadOnlyCollection<GameGenres> Genre { get; }

        public Game(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
