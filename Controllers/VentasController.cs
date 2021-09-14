using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using progra4.Models;

namespace progra4.Controllers
{
    public class VentasController : Controller
    {
        private readonly ILogger<VentasController> _logger;

        public VentasController(ILogger<VentasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Indexa(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}