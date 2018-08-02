using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OSLEP.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(String userName, String userPassword)
        {
            return View();
        }
    }
}