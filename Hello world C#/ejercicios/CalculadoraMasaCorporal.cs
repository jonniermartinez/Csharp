namespace Hello_world_C_.ejercicios
{
    internal class CalculadoraMasaCorporal
    {
        public void getMasaCoorporal()
        {
            //   Escribe un programa en C# que solicite al usuario su peso en kilogramos y su altura en metros, y luego calcule y muestre su Índice de Masa Corporal (IMC).
            //   El IMC se calcula dividiendo el peso en kilogramos entre el cuadrado de la altura en metros. La fórmula matemática es la siguiente:
            Console.WriteLine("Ingresa tu peso en KG");
            string peso;
            peso = Console.ReadLine();
            double pesoNumber = 0;
            if (peso != null)
            {
                pesoNumber = int.Parse(peso);
            }
            Console.WriteLine("Tu pesos es: " + pesoNumber.ToString() + "KG");
            Console.WriteLine("Ingresa tu altura en metros");
            string altura;
            altura = Console.ReadLine();
            double alturaNumber = 0;
            if (altura != null)
            {
                alturaNumber = int.Parse(altura);
            }
            Console.WriteLine("Tu altura es: " + alturaNumber.ToString() + "metros");

            double masaCorporal = pesoNumber / alturaNumber * alturaNumber;
            Console.WriteLine($"Tu indice de masa coorporal es de: {masaCorporal}");
            // IMC = peso / (altura * altura)
        }
    }
}
