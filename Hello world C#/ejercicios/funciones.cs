using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs.funciones
{
    internal class funciones
    {
        public int Ejercicio6()
        {

            Console.WriteLine("Avergigue el numero factorial de un numero. Escriba el numero");
            string? input;
            input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Debes ingresar un numer");
                return 0;
            }
            int number = int.Parse(input);

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }
            Console.WriteLine($"El factorial de {number} es: {result}");
            return result;
        }

        public string Ejercicio7()
        {
            Console.WriteLine("Bienvenido a este programa /n Aqui podras saber si un numero es primo");
            string? input;
            input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Debes ingresar un numero");
                return "";
            }
            int number = int.Parse(input); 
            if (EsPrimo(number))
            {
                // Es un numero primo
                Console.WriteLine($"El numero {number} es PRIMO ");
            }
            else
            {
                // No es primo
                Console.WriteLine($"El numero {number} NO es PRIMO ");

            }
            return "result";
        }
        static bool EsPrimo(int number)
        {
            if (number == 0 || number == 1 || number == 4)
            {
                return false;
            }
            for (int i = 2;i <= number / 2; i++) {
                if ((number % i) == 0)
                {
                    // El numero no es primo
                    return false;
                }
            }
            return true;

        }
    }
}
