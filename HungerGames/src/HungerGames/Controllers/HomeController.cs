using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HungerGames.Data;
using Microsoft.EntityFrameworkCore;

namespace HungerGames.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        List<string> testList;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            testList = new List<string>();
            for(int i=0;i<9; i++)
            {
                testList.Add(i.ToString());
            }
            return View(testList);
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

        public IActionResult Error()
        {
            return View();
        }
    }
}
