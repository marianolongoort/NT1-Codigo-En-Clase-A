using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NT1A_wAuthentication.Models
{
    public class Persona
    {        
        public int PersonaId { get; set; }
        
        [StringLength(50,ErrorMessage ="El campo no debe superar el máximo {0}")]
        public string Nombre { get; set; }

        [Required(ErrorMessage ="El campo {0} es requerido.")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="El campo {0} debe tener como minimo {2} y max {1}")]        
        public string Apellido { get; set; }

        [DisplayName("Tarjeta de Credito")]
        [Range(1111,2222,ErrorMessage ="La tarjeta de credito, debe estar comprendida entre {1},{2}")]
        public int TarjetaCreditoNro { get; set; }


        public DateTime FechaNacimiento { get; set; }

        [NotMapped]
        public DateTime Hora { get; set; }

        public virtual Direccion Direccion { get; set; }

        [Range(1111, 2222, ErrorMessage = "El campo {0}, debe estar comprendido entre {1},{2}")]
        public int Dni { get; set; }

        public ICollection<Telefono> Telefonos { get; set; }

    }
}
