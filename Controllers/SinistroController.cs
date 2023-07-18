using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniFrota.Controllers
{
    public class SinistroController : Controller
    {
        private readonly ILogger<SinistroController> _logger;

        public SinistroController(ILogger<SinistroController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View();
    }
}