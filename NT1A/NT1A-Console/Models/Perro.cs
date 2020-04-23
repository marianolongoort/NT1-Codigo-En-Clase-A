using System;
using System.Collections.Generic;
using System.Text;

namespace NT1A_Console.Models
{
    class Perro : Animal , IAnimal 
    {
        public void Ladrar() { Console.WriteLine("guau guau"); }

        public void Pipi()
        {
            Console.WriteLine("HAciendo pipi");
        }
    }
}
