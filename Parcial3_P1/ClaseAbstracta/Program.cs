using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arreglo unidimensional de tipo figura, squi se almacenan objetos de diferentes clases hijas
            Figura[] figuras =
            {
                new Rectangulo(10, 5),
                new Cuadrado(4),
                new Triangulo(6, 4, 5, 5)
            };

            // Recorrido polimorfico del arreglo
            foreach (Figura figura in figuras)
            {
                Console.WriteLine("--------------------------------");
   
                Console.WriteLine($"Figura: {figura.GetType().Name}");

                Console.WriteLine($"Área: {figura.CalcularArea()}");

                Console.WriteLine($"Perímetro: {figura.CalcularPerimetro()}");
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}