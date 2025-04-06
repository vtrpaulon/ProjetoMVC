using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Context;

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
        public IActionResult Criar()
        {
            return View();
        }
    }
}