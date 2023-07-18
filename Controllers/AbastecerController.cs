using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniFrota.Models;

namespace MiniFrota.Controllers
{
    public class AbastecerController : Controller   
    {
        private readonly ILogger<AbastecerController> _logger;

        public AbastecerController(ILogger<AbastecerController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}