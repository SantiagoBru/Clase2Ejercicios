using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    public class Rectangulo : FiguraGeometrica
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public Rectangulo(double ladoA, double ladoB)
        {
            LadoA = ladoA;
            LadoB = ladoB;
        }
        public override double CalcularArea()
        {
            return LadoA * LadoB;
        }
        public override double CalcularPerimetro()
        {
            return 2 * (LadoA + LadoB);
        }
    }
}