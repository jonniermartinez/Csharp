using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world_C_.Models
{
    internal class Persona
    { 
        public Persona(string Nombre, int Edad, string Profesion)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Profesion = Profesion;
        }
        public string Nombre { get; set;}
        public int Edad { get; set;}
        public string Profesion { get; set;}
    }
}
