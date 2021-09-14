using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using progra4.Models;

namespace g.programacion1.progra4.Controllers
{
    public class CuentasController : Controller
    {
        private readonly ILogger<CuentasController> _logger;

        public CuentasController(ILogger<CuentasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Indexc(){
            return View();
        }

        [HttpPost]
        public IActionResult Indexc(string nombre_completo, string mensaje)
        {
            Console.WriteLine(nombre_completo);
            Console.WriteLine(mensaje);
            return RedirectToAction("IndexcConfirmacion");
        }

        public IActionResult IndexcConfirmacion()
        {
            return View();
        }

         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}