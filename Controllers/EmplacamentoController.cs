using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniFrota.Controllers
{
    public class Emplacamento : Controller
    {
        private readonly ILogger<Emplacamento> _logger;

        public Emplacamento(ILogger<Emplacamento> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}