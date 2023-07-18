using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniFrota.Controllers
{
    public class SeguroController : Controller
    {
        private readonly ILogger<SeguroController> _logger;

        public SeguroController(ILogger<SeguroController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View();
        
    }
}