using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT1A_wAuthentication.Models
{
    public class Persona
    {        
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int TarjetaCreditoNro { get; set; }

        
    }
}
