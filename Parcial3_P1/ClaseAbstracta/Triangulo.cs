using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    // Clase triangulo que hereda de figura
    public class Triangulo : Figura
    {
        // Propiedades del triangulo
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        // Constructor
        public Triangulo(double b, double h, double l1, double l2)
        {
            Base = b;
            Altura = h;
            Lado1 = l1;
            Lado2 = l2;
        }

        // Calcula area
        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        // Calcula perimetro
        public override double CalcularPerimetro()
        {
            return Base + Lado1 + Lado2;
        }
    }
}