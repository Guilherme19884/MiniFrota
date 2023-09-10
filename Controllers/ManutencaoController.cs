using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniFrota.Context;
using MiniFrota.Models;

namespace MiniFrota.Controllers
{
    public class ManutencaoController : Controller
    {
        private readonly ILogger<ManutencaoController> _logger;
        private readonly AppDbContext _context;

        public ManutencaoController(ILogger<ManutencaoController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index() => View();

            [HttpPost]
        public IActionResult Index(Manutencao manutencao)
        {
            if (ModelState.IsValid)
            {
                _context.Manutencoes.Add(manutencao);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            
            return View(manutencao);
        }

        public IActionResult Listar()
        {
            var manutencoes = _context.Manutencoes.ToList();
            return View(manutencoes);
        }

        public IActionResult Editar(int id)
        {
            var manutencoes = _context.Manutencoes.Find(id);
            if (manutencoes == null)
            {
                return NotFound();
            }

            return View(manutencoes);
        }

        [HttpPost]
        public IActionResult Editar(Manutencao manutencao)
        {
            if (ModelState.IsValid)
            {
                _context.Manutencoes.Update(manutencao);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(manutencao);
        }

        public IActionResult Excluir(int id)
        {
            var manutencao = _context.Manutencoes.Find(id);
            if (manutencao == null)
            {
                return NotFound();
            }

            _context.Manutencoes.Remove(manutencao);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}