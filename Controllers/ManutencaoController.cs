using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniFrota.Controllers
{
    public class ManutencaoController : Controller
    {
        private readonly ILogger<ManutencaoController> _logger;

        public ManutencaoController(ILogger<ManutencaoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View();
    }
}