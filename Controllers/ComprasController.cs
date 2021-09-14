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
    public class ComprasController : Controller
    {
        private readonly ILogger<ComprasController> _logger;

        public ComprasController(ILogger<ComprasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Indexb(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}