﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EXEMPLO_EPLAYERS_MVC.Models;
using Microsoft.AspNetCore.Http;

namespace EXEMPLO_EPLAYERS_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("_UserName");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
