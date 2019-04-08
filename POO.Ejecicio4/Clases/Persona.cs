using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        private int edad;
        private string apellido;
        private int dni;
        private string nombre;

        public Persona(string nombre, string apellido, int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
        }

        ~Persona()
        {
            throw new System.NotImplementedException();
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        public string GetFullName()
        {
            return this.Nombre+" "+this.Apellido;
        }

        public int getAge(DateTime cumpleaños)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - cumpleaños.Year;
            if (cumpleaños.Month < today.Month && cumpleaños.Day < today.Day) age--;
            return age;
        }
    }
}
