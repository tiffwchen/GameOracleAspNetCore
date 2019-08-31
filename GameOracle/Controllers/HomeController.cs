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
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                Title = "Home"
            };
            return View(homeViewModel);
        }
    }
}
