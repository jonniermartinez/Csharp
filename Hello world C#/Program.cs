using Hello_world_C_.Models;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora myCalculadora = new Calculadora();
            int suma = myCalculadora.sumar(3, 5);
            int resta = myCalculadora.restar(3, 5);
            int divicion = myCalculadora.dividir(3, 5);
            int multiplicar = myCalculadora.multiplicar(3, 5);

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Division: {divicion}");
            Console.WriteLine($"Multiplicacion: {multiplicar}");
        }
    }
}