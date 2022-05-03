using System;
using System.Collections.Generic;
namespace ProyectoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Realizar un programa que contenga varios usuario y que estos usuarios tengan sus pedidos. En caso de confirmar se muestra
            el monto total a pagar
            */
            Administrador admin = new Administrador("admin@gmail.com", "admin1234");
            List<Usuario> listaUsuarios = new List<Usuario>();
            List<Articulo> listaArticulos = new List<Articulo>();

            listaUsuarios.Add(Metodos.createUser());

            int opcion, indice, opcionUser, exitProgram = 0;
            String mail, contraseña;
            Boolean verificarCuenta;
            Console.ForegroundColor = ConsoleColor.Green;

            do
            {
                opcion = Metodos.selectOption();
                switch (opcion)
                {
                    case 1:
                        {
                            Console.Clear();
                            listaUsuarios.Add(Metodos.createUser());
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            indice = Metodos.indiceUser(listaUsuarios);
                            if (indice != -1)
                            {
                                do
                                {
                                    opcionUser = Metodos.selectAction();
                                    Metodos.inputOption(opcionUser, ref listaUsuarios, ref listaArticulos, indice);
                                } while (opcionUser != 4);
                            }
                            break;

                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.Write("MAIL ADMINISTRADOR: ");
                            mail = Console.ReadLine();
                            mail = mail.ToLower();
                            Console.Write("\nCONTRASEÑA: ");
                            contraseña = Console.ReadLine();

                            if (verificarAdministrador(mail, contraseña, admin))
                            {
                                listaArticulos.Add(inputArticulo());
                            }
                            else
                            {
                                Console.WriteLine("ERROR\nNO SE PUDO INGRESAR A LA CUENTA DEL ADMINISTRADOR");
                            }
                            break;

                        }
                    case 4:
                        {
                            exitProgram = 1;
                            break;
                        }
                }
            } while (opcion != 4 || exitProgram == 1);


        }
        static Articulo inputArticulo()
        {
            String nombre;
            int stock;
            double precio;

            Console.WriteLine("DIGITE EL NOMBRE DEL ARTICULO");
            nombre = Console.ReadLine();
            Console.WriteLine("DIGITE EL STOCK DEL ARTICULO");
            stock = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE EL PRECIO DEL ARTICULO $");
            precio = double.Parse(Console.ReadLine());

            return new Articulo(nombre, precio, stock);
        }
        static Boolean verificarAdministrador(String mail, String contraseña, Administrador admin)
        {
            Boolean verificado = false;
            if(mail == admin.getMail())
            {
                if(contraseña == admin.getContraseña())
                {
                    verificado = true;
                }
            }
            return verificado;
        }


    }
}
