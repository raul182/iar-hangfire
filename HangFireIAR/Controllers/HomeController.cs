using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HangFireIAR.Models;
using HangFireIAR.HangFireServices;

namespace HangFireIAR.Controllers
{
    public class HomeController : Controller
    {
        private IHangFireService hangfireService;
        public HomeController(IHangFireService hangfireService)
        {
            this.hangfireService = hangfireService;
        }

        public IActionResult Index()
        {
            var test =  hangfireService.test();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
