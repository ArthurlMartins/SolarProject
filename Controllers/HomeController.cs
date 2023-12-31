﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SolarProject.Models;

namespace SolarProject.Controllers
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
            return View();
        }

        public IActionResult Cadastrar(Interesse i)
        {
            InteresseService iservice = new InteresseService();
            try
            {
                iservice.CadastraInteresse(i); 
                return View("Index", i);
            }
            catch(Exception e)
            {
                _logger.LogError("Falha ao cadastrar: " +e.Message);
                Console.WriteLine("Falha ao cadastrar: " +e.Message);
            }
            return View("Index", i);
        }
    }
}
