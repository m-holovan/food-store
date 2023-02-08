using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using food_store.Models;
using System.Diagnostics;

namespace food_store.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Success");
            }
            else
            {
                return View(model);
            }

        }
    }
}
