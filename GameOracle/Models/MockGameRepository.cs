using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOracle.Models
{

    public class MockGameRepository : IGameRepository
    {
        private List<Game> _games;

        public MockGameRepository()
        {
            if (_games == null)
            {
                InitializeGames();
            }
        }

        // Initializes the dummy games data
        public void InitializeGames()
        {

            _games = new List<Game>
            {
                new Game("Scythe", 1, 5),
                new Game("Catan", 2, 5),
                new Game("Carcasonne", 2, 5)
            };
        }

        public IEnumerable<Game> GetAllGames()
        {
            return _games;
        }

        public Game GetGameById(int gameId)
        {
            return _games.FirstOrDefault(g => g.Id == gameId);
        }
    }
}
