using ExpenseTrackerInNETCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ExpenseTrackerInNETCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserDbContext _userDbContext;
        private readonly IConfiguration _configuration;

        public HomeController(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext; 
        }

        public IActionResult Index()
        {
            return View();
        }

      

        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)

        {
            var existingStudent = _userDbContext.Users.FirstOrDefault(u => u.Email == user.Email);

            try
            {

                if (existingStudent != null)
                {
                    ModelState.AddModelError("Email", "Email is already taken.");
                    return View();
                }



                else
                {

                    _userDbContext.Users.Add(user);
                    _userDbContext.SaveChanges();
                    return RedirectToAction("Login");


                }
            }
            catch(Exception ex)
            {
              Console.WriteLine(ex.ToString()); 
            }
            return View(user);
            }
            
           

      
     

        public IActionResult Privacy()
        {
            return View();
        }

       
      
    }
}