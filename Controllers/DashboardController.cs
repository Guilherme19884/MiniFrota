using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniFrota.Models;

namespace MiniFrota.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ILogger<DashboardController> logger)
        {
            _logger = logger;
        }
        
         public IActionResult Index()
        {
            var dashboard = new Dashboard
            {
                Id = 1,
                Total = 10000.50m,
                TotalEmplacamento = 5000.25m,
                TotalAbastecimentoAno = 7500.75m,
                TotalSeguro = 2000.00m,
                MultaAno = 100.50m,
                TotalManutencao = 300.00m
            };

            return View(dashboard);
        }
    }
}