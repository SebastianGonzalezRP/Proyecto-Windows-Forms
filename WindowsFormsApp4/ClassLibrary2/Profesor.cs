using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    class Profesor : Persona
    {
        public string Nombre { get; set; }
        public string Appellido { get; set; }
        public string Facultad { get; set; }

        public Profesor(string nombre, string apellido, string facultad) : base(nombre, apellido)
        {
            this.Facultad = facultad;
        }
    }
}
