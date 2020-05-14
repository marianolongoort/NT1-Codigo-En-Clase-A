using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NT1A_wAuthentication.Data;
using NT1A_wAuthentication.Models;
using NT1A_wAuthentication.Services;

namespace NT1A_wAuthentication.Controllers
{
    public class PersonaController : Controller
    {
        private readonly MiDbContext _context;

        public PersonaController(MiDbContext context)
        {
            _context = context;
        }


        public IActionResult ListarPersonas()
        {
            var per = PersonasRepositorio.GetPersona();
            _context.Personas.Remove(per);
                
            _context.SaveChanges();


            return View(_context.Personas.ToList());
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(
            string nombre = "Pedro",
            string apellido = "Picapiedra",
            int tj = 0
            )
        {

            Persona per1 = new Persona();
            per1.Nombre = nombre;
            per1.Apellido = apellido;
            per1.TarjetaCreditoNro = tj;


            return View(per1);
        }
    }
}