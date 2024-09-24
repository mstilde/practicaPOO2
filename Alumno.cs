using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Del Alumno se especifica si tiene trabajo o no.

namespace ComunidadIT
{
    internal class Alumno : Persona
    {
        private bool trabajo;

        public Alumno() 
        {
            trabajo = false;
        }

        public Alumno(int dni, string nombre, string apellido, string nacimiento, bool trabajo)
        {
            SetDni(dni);
            SetApellido(apellido);
            SetNombre(nombre);
            SetNacimiento(nacimiento);
            this.trabajo = trabajo;
        }

        public void SetTrabajo(bool trabajo)
        {
            this.trabajo = trabajo;
        }

        public bool GetTrabajo()
        {
            return trabajo;
        }
    }
}
