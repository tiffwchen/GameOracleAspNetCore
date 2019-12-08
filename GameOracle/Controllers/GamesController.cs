using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoardGamer.BoardGameGeek.BoardGameGeekXmlApi2;
using GameOracle.Models;
using GameOracle.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GameOracle.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGameRepository _gameRepository;
        private readonly IBoardGameGeekXmlApi2Client _bgg;


        public GamesController(IGameRepository gameRepository, IBoardGameGeekXmlApi2Client bggClient)
        {
            _gameRepository = gameRepository;
            _bgg = bggClient;
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

        // GET: /Games/TestAPIAsync
        public async Task<IActionResult> TestAPIAsync()
        {
            ThingRequest request = new ThingRequest(new[] { 161936 });
            ThingResponse response = await _bgg.GetThingAsync(request);
            // not sure that this will work
            ThingResponse.Item pandemicLegacySeason1 = response.Result[0];
            return View(pandemicLegacySeason1);
        }
    }
}