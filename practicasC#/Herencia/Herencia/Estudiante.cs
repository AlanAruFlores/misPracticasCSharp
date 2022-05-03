using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{ 

    class Estudiante : Persona
    {

        private String escuela;
        public Estudiante(String nombreEstudiante, int edad, int dni, String escuela) : base(nombreEstudiante,edad,dni)
        {
            this.escuela = escuela;
        }
        public void mostrarEscuela()
        {
            Console.WriteLine("Estudia en la escuela: " + escuela);
        }
    }
}
