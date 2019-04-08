using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo : Poligono
    {
        public Rectangulo(double ladoBase,double ladoAltura)
        {
            LadoBase = ladoBase;
            LadoAltura = ladoAltura;
        }
        public double LadoBase { set; get; }
        public double LadoAltura { set; get; }
        public override double CalcularPerimetro()
        {
            return LadoBase * 2 + LadoAltura * 2;
        }

        public override double CalcularSuperficie()
        {
            return LadoAltura * LadoBase;
        }
    }

    public class Cuadrado : Rectangulo
    {
        public Cuadrado(double lado) : base(lado, lado) { }
    }
}