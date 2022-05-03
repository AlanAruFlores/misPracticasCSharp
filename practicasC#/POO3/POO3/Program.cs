using System;
using System.Collections;
using System.Collections.Generic;
namespace POO3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa donde el usuario pueda comprar y cargar respuesstos de autos
            List<Repuesto> listaRepuesto = new List <Repuesto>();
            int opcion, exit = 0;
            double monto = 0;
            String continueProgram = null;

            do
            {
                opcion = inputOption();

                switch(opcion)
                {
                    case 1:
                        {
                            if (listaRepuesto != null)
                            {
                                buyAnyProduct(ref listaRepuesto, ref monto);
                            }
                            else
                            {
                                Console.WriteLine("NO HAY NINGUN REPUESTO REGISTRADO");
                            }
                            break;
                        }
                    case 2:
                        {
                            listaRepuesto.Add(loadRepuesto());
                            break;
                        }
                    case 3:
                        {
                            exit = 1; break;
                        }
                    default:
                        {
                            Console.WriteLine("ERROR\nOPCION INCORRECTA");
                            break;
                        }
                }
                Console.WriteLine("DESEA CONTINUAR? DIGITE SI/NO");
                continueProgram = Console.ReadLine();
                continueProgram = continueProgram.ToUpper();
            } while (continueProgram != "SI" || exit != 1);

            Console.WriteLine("GRACIAS POR VISITAR");
            Console.WriteLine("MONTO TOTAL A PAGAR: $" + monto);

            

        }
        static int inputOption()
        {
            int opcion;
            Console.WriteLine("DIGITE UNA OPCION" +
                "\n[1]COMPRAR RESPUESTO" +
                "\n[2]CARGAR REPUESTO" +
                "\n[3]SALIR");
            opcion = int.Parse(Console.ReadLine());

            return opcion;
        }
        static List<Repuesto> buyAnyProduct(ref List <Repuesto> listaRepuesto, ref double monto)
        {
            int opcion, indiceArticulo, cantidad;


            foreach(Repuesto repuesto in listaRepuesto)
            {
                repuesto.mostrarRepuesto();
            }

            Console.Write("\nDIGITE EL ID: ");
            opcion = int.Parse(Console.ReadLine());
            indiceArticulo = searchProductByID(listaRepuesto, opcion);

            if (indiceArticulo != -1)
            {
                Console.Write("DIGITE LA CANTIDAD:");
                cantidad = int.Parse(Console.ReadLine());
                monto += listaRepuesto[indiceArticulo].getPrecio() * cantidad;

                Console.WriteLine("EFECTIVO POR EL MOMENTO: $" + monto);
            }

            return listaRepuesto;

        }
        static Repuesto loadRepuesto()
        {
            String nombre;
            double precio;
            int stock;

            Console.WriteLine("DIGITE EL NOMBRE DEL REPUESTO");
            nombre = Console.ReadLine();
            Console.WriteLine("DIGITE EL PRECIO DEL REPUESTO");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE EL STOCK DEL REPUESTO");
            stock = int.Parse(Console.ReadLine());

            return new Repuesto(nombre, precio, stock);
        }


        static int searchProductByID(List <Repuesto> listaRepuesto, int opcion)
        {
            int i = 0, indice = -1;

            foreach(Repuesto repuesto in listaRepuesto )
            {
                if (repuesto.getID() == opcion)
                {
                    indice = i;
                }
                i++;
            }

            if(indice == -1)
            {
                Console.WriteLine("ID INCORRECTO");
            }
            return indice;
        }


    }
}
