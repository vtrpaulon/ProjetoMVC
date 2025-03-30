using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoMVC.Controllers
{
    public class PessoaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}