using ExpenseTrackerInNETCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Identity;

namespace ExpenseTrackerInNETCore.Controllers
{
    public class HomeController : Controller
    {
        static string EmailId;
        private readonly UserDbContext _userDbContext;
		
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

        [HttpPost]
        public IActionResult Login(User user)
        
        
        {

            try
            { 
                    var student = _userDbContext.Users.FirstOrDefault(u => u.Email.Equals(user.Email));


                    if (student != null && student.Password == user.Password)
                    {
                        EmailId = user.Email;

                        return RedirectToAction("Dashboard");


                    }

                    else
                    {

                        return View();
                    }
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                return View();
            

        }



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
              Console.Write(ex.ToString()); 
            }
            return View();
        }
            
           

      
     

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
       
      
    }
}