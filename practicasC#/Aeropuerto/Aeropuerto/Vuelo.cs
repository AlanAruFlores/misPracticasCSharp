using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Aeropuerto
{
    class Vuelo
    {
        private int id;
        private string ciudadOrigen;
        private string ciudadDestino;
        private int cantMaxima;
        private ArrayList listaPasajeros = new ArrayList();
        public Vuelo(int id, string ciudadOrigen, string ciudadDestino,  int cantMaxima)
        {
            this.id = id;
            this.ciudadOrigen = ciudadOrigen;
            this.ciudadDestino = ciudadDestino;
            SetCantMaxima(cantMaxima);
        }
        public void SetPasajero(Pasajero pasajero)
        {
            if(cantMaxima >= listaPasajeros.Count)
            {
                listaPasajeros.Add(pasajero);
            }
            else
            {
                Console.WriteLine("NO SE PUEDE EXCEDER DEL LIMITE");
            }
        }
        public void MostrarPasajeros()
        {
            if (VerificarPasajeros())
            {
                Console.WriteLine("NO HAY NINGUN PASAJERO REGISTRADO");
            }
            else
            {
                foreach (Pasajero pasajero in  listaPasajeros)
                {
                    Console.WriteLine(pasajero);
                }
            }
        }
        private bool VerificarPasajeros()
        {
            return this.listaPasajeros.Count <= 0;
        }
        public void SetCantMaxima(int cantidad)
        {
            if (VerificarCantidad(cantidad))
            {
                this.cantMaxima = 8;
            }
            else
            {
                this.cantMaxima = cantidad;
            }
        }
        private bool VerificarCantidad(int cantidad)
        {
            return cantidad < 8; 
        }
    }
}
