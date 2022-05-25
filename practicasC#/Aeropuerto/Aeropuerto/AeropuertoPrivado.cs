using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Aeropuerto
{
    class AeropuertoPrivado : Aeropuerto
    {
        public ArrayList listaPatrocinadores = new ArrayList();
        public AeropuertoPrivado(string nombre, string ciudad, string pais) : base(nombre, ciudad, pais){
            listaPatrocinadores = new ArrayList();
        }

        public void MostrarPatrocinadores()
        {
            if (VerificarLista(listaPatrocinadores))
                Console.WriteLine("NO HAY NINGUN PATROCINADOR");
            else
                foreach (Patrocinador patrocinador in listaPatrocinadores)
                {
                    Console.WriteLine(patrocinador);
                }
        }

        override
        public string ToString() => base.ToString() + "CANTIDAD PATROCINADORES: " + listaPatrocinadores.Count;
    }
}
