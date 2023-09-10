using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniFrota.Context;
using MiniFrota.Models;

namespace MiniFrota.Controllers
{
    public class AbastecerController : Controller   
    {
        private readonly ILogger<AbastecerController> _logger;
        private readonly AppDbContext _context;

        public AbastecerController(ILogger<AbastecerController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Abastecer abastecer)
        {
            if (ModelState.IsValid)
            {
                _context.Combustiveis.Add(abastecer);
                _context.SaveChanges();
                
                return RedirectToAction(nameof(Index));
            }

            return View(abastecer);
        }   

         public IActionResult Listar()
        {
            var combustiveis = _context.Combustiveis.ToList();
            return View(combustiveis);
        }

        public IActionResult Editar(int id)
        {
            var veiculo = _context.Combustiveis.Find(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            return View(veiculo);
        }

        [HttpPost]
        public IActionResult Editar(Abastecer abastecer)
        {
            if (ModelState.IsValid)
            {
                _context.Combustiveis.Update(abastecer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(abastecer);
        }

         public IActionResult Excluir(int id)
        {
            var abastecimento = _context.Combustiveis.Find(id);
            if (abastecimento == null)
            {
                return NotFound();
            }

            _context.Combustiveis.Remove(abastecimento);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}