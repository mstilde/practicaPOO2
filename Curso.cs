using ComunidadIT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// El Curso tendrá un nombre, una cantidad máxima de alumnos, un Profesor y un Listado de Alumnos.

namespace ComunidadIT
{
    internal class Curso
    {
        private string nombre;
        private int cantMaxAlumnos;
        private Profesor profesor;
        private List<Alumno> alumnos;
    
        public Curso() 
        {
            nombre = "";
            cantMaxAlumnos = 0;
            profesor = new Profesor();
            alumnos = new List<Alumno>();
        }

        public Curso(string nombre, int cantMaxAlumnos, string nomDocente, string apDocente, int dniDocente, string nacDocente, int añosExpP)
        {
            this.nombre = nombre;
            this.cantMaxAlumnos = cantMaxAlumnos;
            profesor = new Profesor(dniDocente, nomDocente, apDocente, nacDocente, añosExpP);
            alumnos = new List<Alumno>();
        }

        public void SetAlumnos()
        {
            for (int i = 1; i <= cantMaxAlumnos; i++)
            {
                alumnos.Add(SetAlumno());
            }

        }

        private Alumno SetAlumno()
        {
            Console.WriteLine("Ingresar datos alumno");
            Console.Write("DNI: ");
            int dni = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Nacimiento: ");
            string nacimiento = Console.ReadLine();
            Console.Write("Trabaja? (true/false): ");
            bool trabaja = Convert.ToBoolean(Console.ReadLine());

            return new Alumno(dni, nombre, apellido, nacimiento, trabaja);
        }

        public void SetNombre(string nombre) 
        {
            this.nombre = nombre;
        }

        public string GetNombre() 
        {
            return nombre;
        }

        public void SetAlumnosMax(int cantMaxAlumnos)
        {
            this.cantMaxAlumnos = cantMaxAlumnos;
        }

        public int GetNombre(int cantMaxAlumnos)
        {
            return cantMaxAlumnos;
        }
    }
}
