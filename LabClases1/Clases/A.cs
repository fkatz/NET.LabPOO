using System;

namespace Clases
{
    public class A
    {
        public A()
        {
            NombreInstancia = "Instancia sin nombre";
        }
        public A(string nombre)
        {
            NombreInstancia = nombre;
        }
        public string MostrarNombre() {
            return NombreInstancia;
        }
        public string NombreInstancia{
            get;
            set;
        }
        public void M1()
        {
            Console.WriteLine("M1 fue invocado");
        }
        public void M2()
        {
            Console.WriteLine("M2 fue invocado");
        }
        public void M3()
        {
            Console.WriteLine("M3 fue invocado");
        }
    }
}
