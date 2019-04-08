using System;

namespace Lab5
{
    public class Juego
    {
        private int Record { set; get; } = 0;

        public Juego(){}

        public void ComenzarJuego()
        {
            Jugada jugada;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvendio a Adivinar el numerin");
                jugada = new Jugada(PreguntarMaximo());
                jugada.Comparar(PreguntarNumero()); // el 1º afuera del while para mostrar el "Número incorrecto"
                while (!jugada.Adivino)
                {
                    Console.WriteLine("Número incorrecto.");
                    jugada.Comparar(PreguntarNumero());
                }
                Console.WriteLine("ADIVINASTEEEEEE! Solo te tomó " + jugada.Intentos + " intentos.");
                CompararRecord(jugada);
                jugada = null;
            } while (Continuar());
        }

        private void CompararRecord(Jugada j)
        {
            int old = Record;
            if (Record == 0)
            {
                Console.WriteLine("Tu nuevo record es: " + j.Intentos);
                Record = j.Intentos;
            }
            else
            {
                if (j.Intentos < Record)
                {
                    Record = j.Intentos;
                    Console.WriteLine("Superaste el record de " + old + " intentos.");
                }
                else
                {
                    Console.WriteLine("No superaste el record de " + old + " intentos.");
                }
            }
        }

        private bool Continuar()
        {
            ConsoleKeyInfo k;
            do
            {
                Console.WriteLine("Desea jugar otra partida? Y/N");
                k = Console.ReadKey();
                Console.WriteLine();
            } while (k.Key != ConsoleKey.Y && k.Key != ConsoleKey.N);
            if (k.Key == ConsoleKey.Y) return true;
            return false;
        }

        private int PreguntarMaximo()
        {
            int max = 0;
            do
            {
                Console.WriteLine("Ingrese maximo: ");
                try
                {
                    max = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("El número ingresado no es válido. "+e.Message);
                }
            } while (max == 0);
            return max;
        }

        private int PreguntarNumero()
        {
            int n = -1;
            do
            {
                Console.WriteLine("Ingrese numero: ");
                try
                {
                    n = Int32.Parse(Console.ReadLine());
                } catch(Exception e)
                {
                    Console.WriteLine("El número ingresado no es válido. "+e.Message);
                }
            } while (n == -1);
            return n;
        }
    }
}
