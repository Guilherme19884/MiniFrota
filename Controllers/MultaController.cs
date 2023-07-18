using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniFrota.Controllers
{
    public class MultaController : Controller
    {
        private readonly ILogger<MultaController> _logger;

        public MultaController(ILogger<MultaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View();
    }
}