using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using passport_validation_task.Models;

namespace passport_validation_task.Controllers
{
    public class HomeController : Controller
    {

        private readonly IFullPassport fullPassport;

        public HomeController(IFullPassport _fullPassport)
        {
            fullPassport = _fullPassport;
        }

        public IActionResult Index()
        {
            return View( new PassPort());
        }
        [HttpPost]
        public async Task<IActionResult> Index(PassPort passport)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.message = "Incorrect PassPort Data";
                return View();
            }
            PassPort fullPassportVal =  new PassPort();
            fullPassportVal.fullPassport = fullPassport.fullPassport(passport.passSeries, passport.passNumber);
            ViewBag.message = "Correct PassPort Data " + fullPassportVal.fullPassport;
            return  View(passport);
        }

       

    }
}
