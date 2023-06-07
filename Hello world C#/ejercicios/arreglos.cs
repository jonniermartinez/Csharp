using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglosProgram
{
    internal class arreglos
    {
        public int[] ejercicio4(int[] array)
        {
            // Crea un arreglo de números enteros y muestra los elementos en orden inverso.
            var ArrayReversed = array.Reverse().ToArray();
            foreach (var number in ArrayReversed) { 
                Console.WriteLine(number);
            }
            return ArrayReversed.ToArray<int>();
        }
        public int ejercicio5()
        {
            // Crea un programa que encuentre el número mayor en un arreglo de enteros.
            return 0;
        }
    }
}
