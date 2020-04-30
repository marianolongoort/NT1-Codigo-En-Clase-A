using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NT1A_wAuthentication.Models;

namespace NT1A_wAuthentication.Controllers
{
    public class PersonaController : Controller
    {

        public IActionResult ListarPersonas()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona() {
                Apellido = "Longo",
                Nombre = "Mariano",
                TarjetaCreditoNro = 11112222
            }
            );

            personas.Add(new Persona()
            {
                Apellido = "Picapiedra",
                Nombre = "Pedro",
                TarjetaCreditoNro = 33334444
            }
            );
            personas.Add(new Persona()
            {
                Apellido = "Marmol",
                Nombre = "Pablo",
                TarjetaCreditoNro = 55556666
            }
            );


            return View(personas);
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