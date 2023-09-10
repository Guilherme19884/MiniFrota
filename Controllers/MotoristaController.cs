using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniFrota.Context;
using MiniFrota.Models;

namespace MiniFrota.Controllers
{
    public class MotoristaController : Controller
    {
        private readonly ILogger<MotoristaController> _logger;
        private readonly AppDbContext _context;

        public MotoristaController(ILogger<MotoristaController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Motorista motorista)
        {
            if (ModelState.IsValid)
            {
                _context.Motoristas.Add(motorista);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            
            return View(motorista);
        }

        public IActionResult Listar()
        {
            var motoristas = _context.Motoristas.ToList();
            return View(motoristas);
        }

        public IActionResult Editar(int id)
        {
            var veiculo = _context.Veiculos.Find(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            return View(veiculo);
        }

        [HttpPost]
        public IActionResult Editar(Motorista motorista)
        {
            if (ModelState.IsValid)
            {
                _context.Motoristas.Update(motorista);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(motorista);
        }

        public IActionResult Excluir(int id)
        {
            var motorista = _context.Motoristas.Find(id);
            if (motorista == null)
            {
                return NotFound();
            }

            _context.Motoristas.Remove(motorista);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}