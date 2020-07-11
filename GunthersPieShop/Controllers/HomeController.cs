using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GunthersPieShop.Models;
using GunthersPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GunthersPieShop.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
