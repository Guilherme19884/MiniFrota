using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniFrota.Context;
using MiniFrota.Models;

namespace MiniFrota.Controllers
{
    public class MultaController : Controller
    {
        private readonly ILogger<MultaController> _logger;
        private readonly AppDbContext _context;

        public MultaController(ILogger<MultaController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Adicionar(Multa multa)
        {
            if (ModelState.IsValid)
            {
                _context.Multas.Add(multa);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }
            
            return View(multa);
        }

        public IActionResult Listar()
        {
            var multas = _context.Multas.ToList();
            return View(multas);
        }

        public IActionResult Editar(int id)
        {
            var multa = _context.Multas.Find(id);
            if (multa == null)
            {
                return NotFound();
            }

            return View(multa);
        }

        [HttpPost]
        public IActionResult Editar(Multa multa)
        {
            if (ModelState.IsValid)
            {
                _context.Multas.Update(multa);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }

            return View(multa);
        }

        public IActionResult Excluir(int id)
        {
            var multa = _context.Multas.Find(id);
            if (multa == null)
            {
                return NotFound();
            }

            _context.Multas.Remove(multa);
            _context.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}