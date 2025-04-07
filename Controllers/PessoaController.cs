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
    }
}