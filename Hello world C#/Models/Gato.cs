using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world_C_.Models
{
    internal class Gato : Animal
    {
        public Gato(string Esclavo) {
            this.Esclavo = Esclavo;
        }
        string Esclavo { get; set; }
    }
}
