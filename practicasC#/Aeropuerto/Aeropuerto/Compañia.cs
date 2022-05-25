using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Aeropuerto
{
    class Compañia
    {
        private string nombre;
        private ArrayList listaVuelos = new ArrayList();

        public Compañia (string nombre)
        {
            this.nombre = nombre;
        }
        public void SetVuelo(Vuelo vuelo)
        {
            listaVuelos.Add(vuelo);
        }
        public void MostrarVuelos()
        {
            if (VerificarLista())
            {
                Console.WriteLine("LA LISTA DE VUELOS ESTA VACIA");
            }
            else
            {
                int i = 0;
                foreach (Vuelo vuelo in listaVuelos)
                {
                    i++;
                    Console.WriteLine("["+i+"]"+vuelo);
                }
            }
        }
        public void MostrarPasajeros(int indiceVuelo)
        {
            if (VerificarPosicion(indiceVuelo))
            {
                Vuelo vuelo = (Vuelo)listaVuelos[indiceVuelo-1];
                vuelo.mostrarPasajeros();
            }
            else
            {
                Console.WriteLine("NO SE ENCONTRO LA POSICION");
            }
        }
        private bool VerificarPosicion(int indice) => (indice >=1 && indice <= listaVuelos.Count); 
        private bool VerificarLista() => this.listaVuelos.Count <= 0;

        override
        public string ToString() => "COMPAÑIA: "+nombre;

    }
}
