using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world_C_.Models
{
    internal class Calculadora
    {

        public int sumar (int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public int restar (int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        public int multiplicar (int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        public int dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
    }
}
