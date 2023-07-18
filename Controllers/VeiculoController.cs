using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniFrota.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly ILogger<VeiculoController> _logger;

        public VeiculoController(ILogger<VeiculoController> logger) 
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}