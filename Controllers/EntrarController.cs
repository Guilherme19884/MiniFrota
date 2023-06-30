using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MiniFrota.Controllers
{
    public class EntrarController : Controller
    {
        private readonly ILogger<EntrarController> _logger;

        public EntrarController(ILogger<EntrarController> logger)
        {
            _logger = logger;
        }

       
    }
}