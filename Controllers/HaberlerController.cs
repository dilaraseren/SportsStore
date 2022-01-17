using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Controllers
{
    public class HaberlerController : Controller
    {
        private IStoreRepository repository;
        public HaberlerController(IStoreRepository repo)
        {
            repository = repo;
        }
        public IActionResult Teknoloji()
        {
            var result = repository.Products.Where(x => x.Category == "Teknoloji").ToList();
            return View(result);
        }
        public IActionResult Yasam()
        {
            var result = repository.Products.Select(x => x.Category).Contains("Yaşam").ToString();
            return View(result);
        }
        public IActionResult Spor()
        {
            var result = repository.Products.Select(x => x.Category).Contains("Spor").ToString();
            return View(result);
        }


        

       
    }
}
