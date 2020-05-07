using NT1A_wAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT1A_wAuthentication.Services
{
    public static class PersonasRepositorio
    {
        public static List<Persona> GetPersonas()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona()
            {
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
            return personas;
        }

        public static Persona GetPersona()
        {
            return new Persona()
            {
                PersonaId = 7,
                Apellido = "Longo",
                Nombre = "Mariano",
                TarjetaCreditoNro = 11112222
            };
        }
    }
}
