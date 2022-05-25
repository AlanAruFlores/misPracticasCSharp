using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Aeropuerto
{
    abstract class Aeropuerto
    {

        static int cont = 0;
        private int id;
        private string nombre;
        private string ciudad;
        private string pais;
        private ArrayList listaCompañias;
        public Object superClase;
        public Aeropuerto(string nombre, string ciudad, string pais)
        {
            this.id = ++Aeropuerto.cont;
            listaCompañias = new ArrayList();
        }

        public int Id {
            get => id;
            set => this.id = value;
        }
        public void VerAeropuertos()
        {
            if (VerificarLista())
                Console.WriteLine("LISTA VACIA");
            else
                foreach (Compañia compañia in listaCompañias)
                {
                    Console.WriteLine(compañia);
                }
        }
        private bool VerificarLista() => listaCompañias.Count <= 0;
        protected bool VerificarLista(ArrayList lista) => lista.Count <= 0;
        override
        public string ToString() => "INFORMACION AEROPUERTO{"+id+" | " + nombre + " | " + ciudad + " | " + pais + "}";

    }
}
