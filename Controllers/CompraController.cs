using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practica02.Models;
using practica02.Data;
namespace practica02.Controllers
{
   public class CompraController : Controller

    {
        private PresentacionContext _context;
        public CompraController(PresentacionContext context)
        {
            _context = context;
        }

        public IActionResult Nuevo() {
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(Compra p) {
            if (ModelState.IsValid) {
                // Guardar el objeto Pokemon (p)
                _context.Add(p);
                _context.SaveChanges();
                
                return RedirectToAction("Lista");
            }
            
            return View(p);
        }

        public IActionResult Lista() {
            var pokemones = _context.Pokemones.OrderBy(x => x.Nombre).ToList();
            
    
            return View(pokemones);
                   
        }
       
        }
}
