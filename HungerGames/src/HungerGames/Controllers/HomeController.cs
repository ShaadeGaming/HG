using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HungerGames.Data;
using Microsoft.EntityFrameworkCore;
using HungerGames.Models;

namespace HungerGames.Controllers
{
    public class HomeController : Controller
    {
        //en kommentar
        private readonly ApplicationDbContext _context;
        //test strängen är till för att fixa designen
        
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {


            var activities = _context.Activities.ToList();

            return View(activities);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Activity(int? ID)
        {
            
            var r = _context.Activities.Where(x => x.ActivityID ==ID);
            return View(r);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
