using System;
using System.Collections.Generic;
namespace POO_Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            int opcion, dniPersona, indice, exitProgram = 0;

            do
            {
                do
                {
                    Console.WriteLine("DIGITE UNA OPCION : " +
                        "\n[1]INGRESAR PERSONA" +
                        "\n[2]INGRESAR AMIGO DE UNA PERSONA" +
                        "\n[3]VER PERSONAS" +
                        "\n[7]SALIR");
                    opcion = int.Parse(Console.ReadLine());
                } while (opcion < 1 || opcion > 4);

                switch (opcion)
                {
                    case 1:
                        {
                            personas.Add(inputPersona());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("DIGITE EL DNI DE LA PERSONA ");
                            dniPersona = int.Parse(Console.ReadLine());

                            indice = encontrarIndiceDePersona(dniPersona, personas);

                            if (indice != -1)
                            {
                                personas[indice].setAmigo(inputAmigo());
                            }
                            break;
                        }
                    case 3:
                        {
                            if(personas.Count == 0)
                            {
                                Console.WriteLine("NO HAY NINGUNA PERSONA");
                            }
                            else
                            {
                                foreach(Persona persona  in personas)
                                {
                                    persona.mostrarPersona();
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            exitProgram = 1;
                            break;

                        }
                }
            } while (exitProgram != 1);


        }

        static int encontrarIndiceDePersona(int dniPersona, List<Persona> personas)
        {
            int indice = -1, i = 0;
            foreach(Persona persona in personas)
            {
                if(persona.getDni() == dniPersona)
                {
                    indice = i;
                }
                i++;
            }
            if(indice  == -1)
            {
                Console.WriteLine("NO SE ENCONTRO EL DNI");
            }
            return indice;
        }

        static Amigo inputAmigo()
        {
            String nombre;
            Console.WriteLine("DIGITE EL NOMBRE DEL AMIGO");
            nombre = Console.ReadLine();


            return new Amigo (nombre);
        }
        static Persona inputPersona()
        {
            int dni, edad;
            String nombre;

            Console.WriteLine("INGRESE EL DNI");
            dni = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE EL NOMBRE");
            nombre = Console.ReadLine();
            Console.WriteLine("DIGITE LA EDAD");
            edad = int.Parse(Console.ReadLine());

            return new Persona(dni, nombre, edad);
        }

    }
}
