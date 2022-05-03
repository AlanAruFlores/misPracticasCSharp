using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Practica
{
    class Amigo
    {
        private String nombre;


        public Amigo(String nombre)
        {
            this.nombre = nombre;
        }

        public void mostrarAmigo()
        {
            Console.WriteLine(nombre);
        }
    }
}
