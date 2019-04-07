using System;

namespace Geometria
{
    public class Triangulo : Poligono
    {
        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public override double CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }

        public override double CalcularSuperficie()
        {
            return 0.5 * LadoA * LadoB * Math.Sin(LadoC);
        }
    }
}