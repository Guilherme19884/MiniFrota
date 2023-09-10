using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniFrota.Context;
using MiniFrota.Models;

namespace MiniFrota.Controllers
{
    public class EmplacamentoController : Controller
    {
        private readonly ILogger<Emplacamento> _logger;
        private readonly AppDbContext _context;

        public EmplacamentoController(ILogger<Emplacamento> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Emplacamento emplacamento)
        {
            if (ModelState.IsValid)
            {
                _context.Emplacamentos.Add(emplacamento);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            
            return View(emplacamento);
        }

         public IActionResult Listar()
        {
            var emplacamentos = _context.Emplacamentos.ToList();
            return View(emplacamentos);
        }
 
        public IActionResult Editar(string placa)
        {
            var emplacamento = _context.Emplacamentos.Find(placa);
            if (emplacamento== null)
            {
                return NotFound();
            }

            return View(emplacamento);
        }

        [HttpPost]
        public IActionResult Editar(Emplacamento emplacamento)
        {
            if (ModelState.IsValid)
            {
                _context.Emplacamentos.Update(emplacamento);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(emplacamento);
        }

        public IActionResult Excluir(string placa)
        {
            var emplacamento = _context.Emplacamentos.Find(placa);
            if (emplacamento == null)
            {
                return NotFound();
            }

            _context.Emplacamentos.Remove(emplacamento);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}