﻿using Microsoft.AspNetCore.Mvc;

namespace ReservierungsApp.Controllers
{
    public class ReservationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create() 
        { 
            return View(); 
        
        }

    }
}
