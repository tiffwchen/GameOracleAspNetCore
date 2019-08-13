using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOracleV2.Models
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
                new Game(1),
                new Game(2),
                new Game(3)
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
