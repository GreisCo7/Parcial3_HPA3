using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    // Clase cuadrado que hereda de figura
    public class Cuadrado : Figura
    {
        // Propiedad lado del cuadrado
        public double Lado { get; set; }

        // Constructor
        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        // Calcula el área 
        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        // Calcula el perimetro 
        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}