using System;
using System.Collections.Generic;
using System.Text;

namespace NT1A_Console.Models
{
    public abstract class Animal
    {
        private int edad;

        public string Nombre { get; set; }

        public int Edad { get => edad; set => edad = value; }

        public void Caminar() { Console.WriteLine("Estoy caminando"); }
        public void Comer() { Console.WriteLine("Estoy Comiendo"); }


    }
}
