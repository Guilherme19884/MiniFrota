using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniFrota.Context;
using MiniFrota.Models;

namespace MiniFrota.Controllers
{
    public class EntrarController : Controller
    {
        private readonly AppDbContext _context;

        public EntrarController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Entar()
        {
            var veiculos = _context.Veiculos.ToList();
            return View(veiculos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Veiculos.Add(veiculo);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(veiculo);
        }

        public IActionResult Editar(int id)
        {

            var veiculo = _context.Veiculos.Find(id);
            if (veiculo == null)
            {
                // return NotFound();
                return RedirectToAction(nameof(Index));
            }
            return View(veiculo);
        }

        [HttpPost]
        public IActionResult Editar(Veiculo veiculo)
        {

            var veiculoBanco = _context.Veiculos.Find(veiculo.Placa);

            veiculoBanco.Modelo = veiculo.Modelo;
            veiculoBanco.Marca = veiculo.Marca;
            veiculoBanco.Placa = veiculo.Placa;

            _context.Veiculos.Update(veiculoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(string placa)
        {
            var veiculo = _context.Veiculos.Find(placa);

            if (veiculo == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(veiculo);
        }

        public IActionResult Deletar(string placa)
        {

            var contato = _context.Veiculos.Find(placa);

            if (contato == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        [HttpPost]
        public IActionResult Deletar(Veiculo veiculo)
        {
            var contatoBanco = _context.Veiculos.Find(veiculo.Placa);

            _context.Veiculos.Remove(contatoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }

}