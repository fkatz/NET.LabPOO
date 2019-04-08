using System;

namespace Lab5
{
    public class Jugada
    {
        public Jugada(int maxNumero)
        {
            Random rnd = (new Random());
            Numero = rnd.Next(maxNumero);
        }

        public bool Adivino { get; set; } = false;

        public int Intentos { get; set; } = 0;

        public int Numero { get; set; }

        public void Comparar(int n)
        {
            if (n == Numero)
            {
                Adivino = true;
            }
            Intentos++;
        }
    }
}