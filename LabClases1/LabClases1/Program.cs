using System;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            Console.WriteLine("Métodos clase A:");
            Console.WriteLine("Nombre de instancia: "+a.MostrarNombre());
            a.M1();
            a.M2();
            a.M3();
            Console.WriteLine("Métodos clase B:");
            Console.WriteLine("Nombre de instancia: " + b.MostrarNombre());
            b.MostrarNombre();
            b.M1();
            b.M2();
            b.M3();
            b.M4();
            Console.ReadKey();
        }
    }
}
