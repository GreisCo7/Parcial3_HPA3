using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{

    // Clase abstracta que sirve como plantilla para todas las figuras
    public abstract class Figura
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }
}