using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniFrota.Controllers
{
    public class MotoristaController : Controller
    {
        private readonly ILogger<MotoristaController> _logger;

        public MotoristaController(ILogger<MotoristaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}