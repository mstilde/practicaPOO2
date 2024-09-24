using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tanto de un Profesor como de un Alumnos se guarda su DNI, Nombre, Apellido y Fecha de Nacimiento.

namespace ComunidadIT
{
    internal class Persona
    {
        private int dni;
        private string nombre;
        private string apellido;
        private string nacimiento;

        public Persona()
        {
            dni = 0;
            nombre = "";
            apellido = "";
            nacimiento = "";
        }

        public Persona(int dni, string nombre, string apellido, string nacimiento)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        public int GetDni(int dni)
        {
            return dni;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre(string nombre)
        {
            return nombre;
        }
        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string GetApellido(string apellido)
        {
            return apellido;
        }
        public void SetNacimiento(string nacimiento)
        {
            this.nacimiento = nacimiento;
        }

        public string GetNacimiento(string nacimiento)
        {
            return nacimiento;
        }
    }
}
