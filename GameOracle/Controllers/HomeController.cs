using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameOracle.Models;
using GameOracle.ViewModels;

namespace GameOracle.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameRepository _gameRepository;
        public HomeController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                Title = "Home Page",
                Games = _gameRepository.GetAllGames().OrderBy(g => g.Name)
        };

            return View(homeViewModel);
        }
    }
}
