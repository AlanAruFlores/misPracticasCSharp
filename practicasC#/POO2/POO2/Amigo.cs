using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace POO2
{
    class Amigo
    {
        private String nombre;

        public Amigo(String nombre)
        {
            this.nombre = nombre;
        }

        public void mostrar()
        {     
            Console.WriteLine(nombre);
        }
    }
}
