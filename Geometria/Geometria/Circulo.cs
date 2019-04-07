using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Circulo : Poligono
    {
        public Circulo(double radio)
        {
            Radio = radio;
        }
        public double Radio { get; set; }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}
