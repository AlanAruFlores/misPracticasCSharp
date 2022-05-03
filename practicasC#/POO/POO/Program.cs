using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Ale", 20, Pais.CHINA);
            Persona p2 = new Persona("Alejandro", "ale@gmail.com", 20, Pais.EEUU);

            p1.mostrarPersona();
            p2.mostrarPersona();



        }
    }
}
