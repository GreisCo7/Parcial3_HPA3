using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    // Clase rectangulo que hereda de figura
    public class Rectangulo : Figura
    {
        // Propiedades del rectangulo
        public double Base { get; set; }
        public double Altura { get; set; }


        // Constructor
        public Rectangulo(double b, double h)
        {
            Base = b;
            Altura = h;
        }


        // Implementación de metodo para calcular el area
        public override double CalcularArea()
        {
            return Base * Altura;

        }

        // Implementación del metodo para calcular el perimetro
        public override double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
