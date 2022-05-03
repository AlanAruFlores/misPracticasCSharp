using System;
using System.Collections;
using System.Collections.Generic;

namespace POO2
{
    class Program
    {
        static int encontrarIndice(List<Persona>personas, String nombre)
        {
            int indice = -1;
            for (int i = 0; i<personas.Count; i++)
            {
                if(personas[i].getNombre() == nombre)
                {
                    indice = i;
                }
            }
            if(indice==-1)
            {
                Console.WriteLine("NO SE ENCONTRO A LA PERSONA");
            }
            return indice;
        }
        static void Main(string[] args)
        {
            List<Persona> personas = new List <Persona>();
            int opcion, exit = 0;
            String continuar = null;

            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("...MENU..." +
                    "\n[1]INGRESAR PERSONA" +
                    "\n[2]INGRESAR AMIGO DE UNA PERSONA" +
                    "\n[3]MOSTRAR DATOS DE UNA PERSONA" +
                    "\n[4]MOSTRAR DATOS DE TODAS LAS PERSONAS" +
                    "\n[5]SALIR");
                opcion = int.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        {
                            Persona persona;
                            persona = getPersona();
                            personas.Add(persona);
                            Console.WriteLine("SE INGRESO A LA PERSONA DE FORMA EXITOSA");
                            break;
                        }
                    case 2:
                        {
                            if(personas.Count != 0)
                            {
                                String searchName;
                                int indice;
                                Console.WriteLine("DIGITE EL NOMBRE DE LA PERSONA PARA AGREGAR SU AMIGO");
                                searchName = Console.ReadLine();
                                indice = encontrarIndice(personas, searchName);
                                if (indice != -1)
                                {
                                    Amigo amigo;
                                    amigo = getAmigo();
                                    personas[indice].setAmigo(amigo);
                                    Console.WriteLine("AMIGO EXITOSO");
                                }
                                
                            }
                            else
                            {
                                Console.WriteLine("NO HAY NINGUNA PERSONA REGISTRADA");
                            }

                            break;
                        }
                    case 3:
                        {
                            String searchName;
                            int indice;
                            if(personas.Count != 0)
                            {
                                Console.WriteLine("DIGITE EL NOMBRE DE LA PERSONA PARA VER SUS DATOS");
                                searchName = Console.ReadLine();
                                indice = encontrarIndice(personas, searchName);
                                if (indice != -1)
                                {
                                    personas[indice].mostrarDatos();
                                }
                            }
                            else
                            {
                                Console.WriteLine("NO EXISTE NINGUNA PERSONA");
                            }

                            break;
                        }
                    case 4:
                        {
                            if(personas.Count == 0)
                            {
                                Console.WriteLine("NO HAY NINGUNA PERSONA REGISTRADA");
                            }
                            else
                            {
                                foreach (Persona persona in personas)
                                {
                                    persona.mostrarDatos();
                                }
                            }

                            break;
                        }
                    case 5:
                        {
                            exit = 1;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("ERROR OPCION INCORRECTA");
                            break;
                        }
                }
                if(opcion != 5)
                {
                    Console.WriteLine("DESEA CONTINUAR? DIGITE SI/NO");
                    continuar = Console.ReadLine();
                    continuar = continuar.ToUpper();
                }
            } while (exit != 1 && continuar == "SI");



        }
        static Persona getPersona()
        {

            String nombre;
            int edad, dni;

            Console.WriteLine("DIGITE EL NOMBRE");
            nombre = Console.ReadLine();
            nombre = nombre.ToUpper();
            Console.WriteLine("DIGITE LA EDAD");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE EL DNI");
            dni = int.Parse(Console.ReadLine());

            return new Persona(nombre, edad, dni);
        }
        static Amigo getAmigo()
        {
            String nombre;
            Console.WriteLine("DIGITE EL NOMBRE DEL AMIGO");
            nombre = Console.ReadLine();
            nombre = nombre.ToUpper();

            return new Amigo(nombre);
        }
    }
}
