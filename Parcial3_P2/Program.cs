using Newtonsoft.Json;

namespace Parcial3_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto Persona
            Persona persona = new Persona
            {
                Nombre = "Greisy",
                Edad = 20,
                Carrera = "Ingeniería en Sistemas"
            };

            // Convertir el objeto a formato JSON
            string json = JsonConvert.SerializeObject(persona);

            Console.WriteLine("Objeto convertido a JSON:");
            Console.WriteLine(json);

            Console.WriteLine("\nPresione tecla para salir");
            Console.ReadKey();
        }
    }
}
