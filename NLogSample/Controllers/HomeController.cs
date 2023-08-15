using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLogSample.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NLogSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoggerManeger logmaneger;

        public HomeController(ILoggerManeger logger)
        {
            logmaneger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            logmaneger.LogInfo("INFO: İşlem gerçekleşti.");
            logmaneger.LogError("ERROR: hataaldık");
            return View();
        }
    }
}
