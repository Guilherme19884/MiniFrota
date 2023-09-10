using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniFrota.Context;
using MiniFrota.Models;

namespace MiniFrota.Controllers
{
    public class SeguroController : Controller
    {
        private readonly ILogger<SeguroController> _logger;
        private readonly AppDbContext _context;

        public SeguroController(ILogger<SeguroController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index() => View();

          [HttpPost]
        public IActionResult Index(Seguro seguro)
        {
            if (ModelState.IsValid)
            {
                _context.Seguros.Add(seguro);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            
            return View(seguro);
        }

        public IActionResult Listar()
        {
            var seguros = _context.Seguros.ToList();
            return View(seguros);
        }

        public IActionResult Editar(int id)
        {
            var seguro = _context.Seguros.Find(id);
            if (seguro == null)
            {
                return NotFound();
            }

            return View(seguro);
        }

        [HttpPost]
        public IActionResult Editar(Seguro seguro)
        {
            if (ModelState.IsValid)
            {
                _context.Seguros.Update(seguro);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(seguro);
        }

        public IActionResult Excluir(int id)
        {
            var seguro = _context.Seguros.Find(id);
            if (seguro == null)
            {
                return NotFound();
            }

            _context.Seguros.Remove(seguro);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        
    }
}