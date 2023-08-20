using ExpenseTrackerInNETCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExpenseTrackerInNETCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserDbContext _userDbContext;

        public HomeController(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register ()
        {
            return View();
        }

    }
}