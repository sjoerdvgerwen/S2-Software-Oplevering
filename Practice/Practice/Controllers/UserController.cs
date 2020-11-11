using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Practice.Models;

namespace Practice.Controllers

    
{
    public class UserController : Controller
    {
        public User user;
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            return View();
        }
    }
}
