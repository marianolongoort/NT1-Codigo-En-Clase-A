namespace NT1A_wAuthentication.Models
{
    public class Direccion
    {
        public int DireccionId { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public int CodigoPostal { get; set; }


        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}