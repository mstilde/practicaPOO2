using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Del Profesor también se guarda la cantidad de años de Experiencia.

namespace ComunidadIT
{
    internal class Profesor : Persona
    {
        private int aExperiencia;

        public Profesor() 
        {
            aExperiencia = 0;
        }

        public Profesor(int dni, string nombre, string apellido, string fecha, int aExperiencia)
        {
            SetDni(dni);
            SetNombre(nombre);
            SetApellido(apellido);
            SetNacimiento(fecha);
            this.aExperiencia = aExperiencia;
        }

        public void SetExperiencia(int aExperiencia)
        {
            this.aExperiencia = aExperiencia;
        }

        public int GetExperiencia()
        {
            return this.aExperiencia;
        }
    }
}
