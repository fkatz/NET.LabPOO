using System;

namespace Lab6
{
    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero)
        {
        }

        public override void Comparar(int n)
        {
            string m = "";
            if (n == Numero)
            {
                Adivino = true;
            }
            else
            {
                if (n < Numero)
                {
                    m += "Tu numero es menor. ";
                }
                else
                {
                    m += "Tu numero es mayor. ";
                }
                if (Math.Abs(n - Numero) >= 100)
                {
                    m += "Estás muy lejos.";
                }
                else if (Math.Abs(n - Numero) <= 5)
                {
                    m += "Estás muy cerca.";
                }
                Console.WriteLine(m);
            }
            Intentos++;
        }
    }
}