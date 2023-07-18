using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniFrota.Context;
using MiniFrota.Models;

namespace MiniFrota.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly ILogger<VeiculoController> _logger;
        private readonly AppDbContext _context;

        public VeiculoController(ILogger<VeiculoController> logger, AppDbContext context) 
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Veiculos.Add(veiculo);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }
            
            return View(veiculo);
        }
            public IActionResult Listar()
        {
            var veiculos = _context.Veiculos.ToList();
            return View(veiculos);
        }

        public IActionResult Editar(string placa)
        {
            var veiculo = _context.Veiculos.Find(placa);
            if (veiculo == null)
            {
                return NotFound();
            }else if(veiculo != veiculo){
                return NotFound();
            }

            return View(veiculo);
        }

        [HttpPost]
        public IActionResult Editar(Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Veiculos.Update(veiculo);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }

            return View(veiculo);
        }

        public IActionResult Excluir(string placa)
        {
            var veiculo = _context.Veiculos.Find(placa);
            if (veiculo == null)
            {
                return NotFound();
            }

            _context.Veiculos.Remove(veiculo);
            _context.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}