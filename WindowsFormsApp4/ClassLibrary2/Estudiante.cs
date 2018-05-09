using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Estudiante : Persona
    {
        public string Nombre { get; set; }
        public string Appellido { get; set; }
        public string Carrera{ get; set; }

        public Estudiante(string nombre, string apellido, string carrera) : base(nombre, apellido)
        {
            this.Carrera = carrera;

        }
    }
}
