using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Context;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class PessoaController : Controller
    {
        private readonly CadastroContext _context;
        public PessoaController(CadastroContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            var pessoas = _context.Pessoas.ToList();
            return View(pessoas);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Pessoa pessoa)
        {
            if(ModelState.IsValid)
            {
                _context.Pessoas.Add(pessoa);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        public IActionResult Editar(int id)
        {
            var pessoa = _context.Pessoas.Find(id);
            if (pessoa == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        [HttpPost]
        public IActionResult Editar(Pessoa pessoa)
        {
            var pessoabanco = _context.Pessoas.Find(pessoa.Id);

            pessoabanco.Nome = pessoa.Nome;
            pessoabanco.CPF = pessoa.CPF;
            pessoabanco.RG = pessoa.RG;
            pessoabanco.DataNascimento = pessoa.DataNascimento;

            _context.Pessoas.Update(pessoabanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var pessoa = _context.Pessoas.Find(id);
            if(pessoa == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        public IActionResult Deletar(int id)
        {
            var pessoa = _context.Pessoas.Find(id);
            if(pessoa == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        [HttpPost]
        public IActionResult Deletar(Pessoa pessoa)
        {
            var pessoabanco = _context.Pessoas.Find(pessoa.Id);

            _context.Pessoas.Remove(pessoabanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}