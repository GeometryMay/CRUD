using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoEscritorio.modelo
{
    internal class Alumno
    {
        private string nombre;
        private int calificacion;

        public Alumno()
        {
            this.nombre = "";
            this.calificacion = 0;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Calificacion { get => calificacion; set => calificacion=value; }
    }
}
