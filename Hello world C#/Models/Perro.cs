using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world_C_.Models
{
    internal class Perro : Animal
    {
        public Perro(string Amo) {
            this.Amo = Amo;
        }
        string Amo { get; set; }
       
    }
}
