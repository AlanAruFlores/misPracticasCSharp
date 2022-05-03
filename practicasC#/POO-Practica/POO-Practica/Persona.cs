using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Practica
{nnnn
    class Persona
    {
        private int dni;
        private String nombre;
        private int edad;
        private List<Amigo> amigos;
        public Persona(int dni , String nombre ,int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.edad = edad;
            amigos = new List<Amigo>();
        }
        

        public void setAmigo(Amigo amigo)
        {
            amigos.Add(amigo);
        }
        public int getDni()
        {
            return dni;
        }
        public void mostrarPersona()
        {
            Console.WriteLine("DNO: " + dni + " | NOMBRE: " + nombre + " | EDAD: " + edad);
        }

    }
}
