using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido, fullName;
            int dni, año, mes, dia;

            Console.WriteLine("Ingrese el nombre de la persona");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido de la persona");
            apellido = Console.ReadLine();

            Console.WriteLine("Ingrese el dni de la persona");
            dni = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de año de nacimiento de la persona");
            año = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de mes de nacimiento de la persona");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de dia de nacimiento de la persona");
            dia = int.Parse(Console.ReadLine());

            DateTime fechaNacimiento = new DateTime(año, mes, dia);

            Persona persona = new Persona(nombre, apellido, dni);

            fullName = persona.GetFullName();

            persona.Edad = persona.getAge(fechaNacimiento);

            Console.WriteLine("La edad de " + fullName + " es " + persona.Edad);

            Console.ReadKey();


        }
    }
}
