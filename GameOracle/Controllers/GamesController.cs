using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameOracle.Models;
using GameOracle.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GameOracle.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public GamesController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        // GET: /Games/
        public IActionResult Index()
        {
            var gamesViewModel = new GamesViewModel()
            {
                Title = "Games",
                Games = _gameRepository.GetAllGames().OrderBy(g => g.Name)
            };

            return View(gamesViewModel);
        }

        // GET: /Games/Details/{id}
        public IActionResult Details(int id)
        {
            var game = _gameRepository.GetGameById(id);
            if (game == null){
                return NotFound();
            }
            return View(game);
        }
    }
}