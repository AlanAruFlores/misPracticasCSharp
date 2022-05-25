using System;
using System.Collections.Generic;
using System.Text;

namespace Aeropuerto
{
    class Pasajero
    {
        private string nombre;
        private Nacionalidad nacionalidad;
        private int nroPasajero;
        public Pasajero(string nombre, Nacionalidad nacionalidad, int nroPasajero)
        {
            this.nombre = nombre;
            this.nroPasajero = nroPasajero;
            this.nacionalidad = nacionalidad;
        }
        public Nacionalidad Nacionalidad{
            get => nacionalidad;
            set => nacionalidad = value;
        }

        public override string ToString() => nombre + " | " + nacionalidad + " | " + nroPasajero;
    }
}
