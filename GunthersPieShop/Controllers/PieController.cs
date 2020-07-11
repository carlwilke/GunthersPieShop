using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GunthersPieShop.Models;
using GunthersPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GunthersPieShop.Controller
{
    public class PieController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        // GET: /<controller>/
        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Cheese cakes";

            //return View(_pieRepository.AllPies);
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;

            piesListViewModel.CurrentCategory = "Cheese cakes";
            return View(piesListViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieByID(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }
    }
}
