using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CrudMoura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudMoura.Controllers
{
    
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;

              public static List<Alunos> listaDeAlunos = new List<Alunos>
        {
            new Alunos{Id = 1, Nome = "Rawany", Idade = 15, cpf = 10},
            new Alunos{Id = 1, Nome = "Milena", Idade = 16, cpf = 12},
            new Alunos{Id = 1, Nome = "Gistavo", Idade = 17, cpf = 50},
        };

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarAlunos()
        {
            ViewBag.Alunos = listaDeAlunos;
            return View();
        }

        public IActionResult Creat()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SalvarAlunos(Alunos AlunoCadastrada)
        {
            AlunoCadastrada.Id = listaDeAlunos.Max(f => f.Id) + 1;

            listaDeAlunos.Add(AlunoCadastrada);

            Console.WriteLine(AlunoCadastrada.Nome);
            Console.WriteLine(AlunoCadastrada.Idade);
            Console.WriteLine(AlunoCadastrada.cpf);
            
            return RedirectToAction(nameof(ListarAlunos));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}