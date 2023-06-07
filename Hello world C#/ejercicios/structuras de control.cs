using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world_C_.ejercicios
{
    internal class structuras_de_control
    {
        // Tipos de datos y var
        // En c# hay muchos tipos de datos
        // Ejercicio 2 : Crea un programa que solicite al usuario un número y determine si es par o impar.
        public int Ejercicio2()
        {
            Console.WriteLine("Escribe un numero");
            string? value;
            value = Console.ReadLine();
            int dividendo = int.Parse(value);
            int divisor = 2;
            int residuo = dividendo % divisor;
            if (residuo == 0)
            {
                Console.WriteLine("El numero que ingresaste es Par");
            }
            else
            {
                Console.WriteLine("El numero que ingresaste es impar");
            }
            return residuo;
        }


        // ejercicio 3: Crea un programa que solicite al usuario dos números y determine cuál es el mayor.

        public string Ejercicio3()
        {
            // get data
            Console.WriteLine("El objetivo de este programa es que tu me des dos numero y yo te digo cual es el mayor");
            Console.WriteLine("Escribe el primer numero");
            string? value1;
            value1 = Console.ReadLine();
            Console.WriteLine("Escribe el segundo numero");
            string? value2;
            value2 = Console.ReadLine();

            // calculate what is bigger
            var number1 = int.Parse(value1);
            var number2 = int.Parse(value2);

            switch (number1 > number2)
            {
                case true:
                    Console.WriteLine(number1.ToString());
                    break;
                case false:
                    Console.WriteLine(number2.ToString());
                    break;
                default:
                    Console.WriteLine("Los numero son completamente iguales");
                    break;
            }


            return "Se completo la funcion satisfatoriamente";
        }
    }
}
