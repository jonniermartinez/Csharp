using Hello_world_C_.Models;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona Jonnier = new Persona("Jonnier", 18, "Developer");
            Persona Hanzeel = new Persona("Hanzeel", 14, "Musico");
            Persona Carlos = new Persona("Carlos", 25, "Creativo");
            Console.WriteLine(
                $"{Jonnier.Nombre} {Hanzeel.Nombre} {Carlos.Nombre}"
            );
            
        }
    }
}