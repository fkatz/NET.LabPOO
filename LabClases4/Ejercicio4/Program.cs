using System;
using Clases;

namespace LabClases4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido;
            int dni, año, mes, dia;

            Console.Write("Ingrese el nombre de la persona: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido de la persona: ");
            apellido = Console.ReadLine();

            Console.Write("Ingrese el DNI de la persona: ");
            dni = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de dia de nacimiento de la persona: ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de mes de nacimiento de la persona: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el año de nacimiento de la persona: ");
            año = int.Parse(Console.ReadLine());

            DateTime fechaNacimiento = new DateTime(año, mes, dia);

            Persona persona = new Persona(nombre, apellido, dni, fechaNacimiento);

            Console.WriteLine("La edad de " + persona.GetFullName() + " es " + persona.getAge());

            Console.ReadKey();


        }
    }
}
