using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevConnect.Contexts;
using DevConnect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

//CADASTRO DE USUARIO
namespace DevConnect.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly DevConnectContext _context;

        private readonly ILogger<UsuarioController> _logger;


        public UsuarioController(ILogger<UsuarioController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.UsuarioNovoCadastrado = "";
            TempData["UsuarioNovoCadastrado"] = "";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {

            TbUsuario novoUsuario = new TbUsuario()
            {
                NomeCompleto = form["NomeCompleto"].ToString(),
                NomeUsuario = form["NomeUsuario"].ToString(),
                Email = form["Email"].ToString(),
                Senha = form["Senha"].ToString()
            };

            if (form.Files.Count > 0)
            {
                IFormFile file = form.Files[0];
                string folder = Path.Combine(Directory.GetCurrentDirectory(), "www/root/images");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string path = Path.Combine(folder, file.FileName);

                using (var Stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(Stream);
                }

                novoUsuario.FotoPerfilUrl = file.FileName;

            }
            else
            {
                novoUsuario.FotoPerfilUrl = "";
            }

            try
            {
                _context.TbUsuario.Add(novoUsuario);

                await _context.SaveChangesAsync();

                TempData["UsuarioNovoCadastrado"] = "Cadastrado";
                ViewBag.UsuarioNovoCadastrado = "";

                return RedirectToAction("Index", "Home");
            }
            catch (System.Exception)
            {
                ViewBag.UsuarioNovoCadastrado = "Nao cadastrado";
                TempData["UsuarioNovoCadastrado"] = "";
                return View();
            }

        }
        public IActionResult Perfil()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}