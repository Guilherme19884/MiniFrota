using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MiniFrota.Models;

namespace MiniFrota.Controllers
{
    public class CadastrarController : Controller
    {
        private readonly ILogger<CadastrarController> _logger;

        public CadastrarController(ILogger<CadastrarController> logger)
        {
            _logger = logger;
        }
    }
}