using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante e = new Estudiante("Ale",20,45348384,"Zaccagnini");
            Profesor p = new Profesor("Alejandro",40,5839293,"Garson");
           
            e.mostrarDatos();
            e.mostrarEscuela();

            p.mostrarDatos();
            p.mostrarEscuela();
        }
    }
    class Profesor : Persona
    {
        private String escuela;
        public Profesor(String nombreProfesor, int edad, int dni, String escuela):base(nombreProfesor, edad,  dni)
        {
            this.escuela = escuela;
        }
        public void mostrarEscuela()
        {
            Console.WriteLine("Trabaja en la escuela: " + escuela);
        }
    }
}
