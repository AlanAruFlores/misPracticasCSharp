using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Persona
    {
        private String nombre;
        private int edad;
        private int dni;
        public Persona(String nombre, int edad, int dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        public void mostrarDatos()
        {
            Console.WriteLine("EL NOMBRE ES: " + nombre);
        }
    }
}
