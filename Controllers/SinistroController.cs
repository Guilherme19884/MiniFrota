using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniFrota.Context;
using MiniFrota.Models;

namespace MiniFrota.Controllers
{
    public class SinistroController : Controller
    {
        private readonly ILogger<SinistroController> _logger;
        private readonly AppDbContext _context;

        public SinistroController(ILogger<SinistroController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Adicionar(Sinistro sinistro)
        {
            if (ModelState.IsValid)
            {
                _context.Sinistros.Add(sinistro);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }
            
            return View(sinistro);
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
        public IActionResult Editar(Sinistro sinistro)
        {
            if (ModelState.IsValid)
            {
                _context.Sinistros.Update(sinistro);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }

            return View(sinistro);
        }

        public IActionResult Excluir(int id)
        {
            var sinistro = _context.Sinistros.Find(id);
            if (sinistro == null)
            {
                return NotFound();
            }

            _context.Sinistros.Remove(sinistro);
            _context.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}