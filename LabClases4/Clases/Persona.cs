using System;

namespace Clases
{
    public class Persona
    {
        public Persona(string nombre, string apellido, int dni, DateTime fechaNac)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            FechaNac = fechaNac;
            Console.WriteLine("Se creó una instancia de Persona");
        }

        ~Persona()
        {
            Console.WriteLine("Se destruyó una instancia de Persona");
        }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int DNI { get; set; }

        public DateTime FechaNac { get; set; }

        public string GetFullName()
        {
            return Nombre+" "+Apellido;
        }

        public int getAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - this.FechaNac.Year;
            if (FechaNac.Month > today.Month ||  (FechaNac.Month == today.Month && FechaNac.Day > today.Day)) age--;
            return age;
        }
    }
}
