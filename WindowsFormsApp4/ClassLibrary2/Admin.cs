using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    class Admin : Persona
    {
        public string Nombre { get; set; }
        public string Appellido { get; set; }

        public Admin(string miNombre, string miApellido) : base(miNombre, miApellido)
        {

        }
    }
}
