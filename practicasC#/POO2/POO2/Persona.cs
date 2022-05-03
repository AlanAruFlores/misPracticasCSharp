using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace POO2
{
    class Persona
    {
        private String nombre;
        private int edad;
        private int dni;
        private List<Amigo> amigos;

        public Persona(String nombre, int edad, int dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            amigos = new List<Amigo>();
        }
        public void setAmigo(Amigo amigo)
        {
            amigos.Add(amigo);
        }
        public String getNombre()
        {
            return nombre;
        }
        public void mostrarDatos()
        {
            Console.WriteLine(nombre + " | " + edad + " | " + dni );

            Console.WriteLine("AMIGOS: ");
            if(amigos.Count == 0)
            {
                Console.WriteLine("NO TIENE AMIGOS");
            }
            else
            {
                foreach (Amigo amigo in amigos)
                {
                    amigo.mostrar();
                }
            }

        }

    }
}
