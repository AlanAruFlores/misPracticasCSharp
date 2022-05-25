using System;
using System.Collections.Generic;
using System.Text;

namespace Aeropuerto
{
    class Patrocinador
    {
        private string nombre;
        public Patrocinador(string nombre)
        {
            this.nombre = nombre;
        }

        override
        public string ToString() => "PATROCINADOR: " + nombre;
    }
}
