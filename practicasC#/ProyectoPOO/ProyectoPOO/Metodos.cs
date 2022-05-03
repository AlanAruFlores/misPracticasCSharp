using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOO
{
    class Metodos
    {
        public static Usuario createUser()
        {
            String mail, contraseña, nombre;
            Console.Clear();
            Console.WriteLine("***REGISTRO****");
            Console.Write("\nMAIL: ");
            mail = Console.ReadLine();
            Console.Write("\nCONTRASEÑA: ");
            contraseña = Console.ReadLine();
            Console.Write("\nNOMBRE: ");
            nombre = Console.ReadLine();

            return new Usuario(mail, contraseña, nombre);
        }
        public static int indiceUser(List<Usuario> usuarios)
        {
            int indice = -1;
            String mail, contraseña;
            Console.Clear();
            Console.WriteLine(".....LOGIN.......");
            Console.Write("DIGITE MAIL: ");
            mail = Console.ReadLine();
            Console.Write("\nCONTRASEÑA:");
            contraseña = Console.ReadLine();

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].getMail().Equals(mail))
                {
                    if (usuarios[i].getConstraseña().Equals(contraseña))
                    {
                        indice = i;
                    }
                }
            }
            if (indice == -1)
            {
                Console.WriteLine("ERROR, EL USUARIO NO EXISTE");
            }
            return indice;
        }
        public static int selectAction()
        {
            int opcion;
            do
            {
                Console.WriteLine("........MENU USUARIO........" +
                    "\n[1]COMPRAR PRODUCTO" +
                    "\n[2]VER CARRITO" +
                    "\n[3]CONFIRMAR CARRITO" +
                    "\n[4]VER REGISTRO" +
                    "\n[5]SALIR");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion < 1 || opcion > 1);

            return opcion;

        }
        public static void inputOption(int opcion, ref List<Usuario> usuario, ref List<Articulo> articulos, int indiceUser)
        {
            int exitMenu = 0;
            String confirmarCarrito;
            
                switch (opcion)
                {
                    case 1:
                        {
                            comprarProducto(ref usuario, ref articulos, indiceUser);
                            break;
                        }
                    case 2:
                        {
                            usuario[indiceUser].getCarrito().mostrarCarrito();
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("¿DESEA COMPRAR LO QUE HAY EN EL CARRITO? DIGITE SI/NO" +
                                "\nTOTAL A PAGAR: $" + usuario[indiceUser].getCarrito().getMonto());
                            confirmarCarrito = Console.ReadLine();
                            confirmarCarrito = confirmarCarrito.ToUpper();
                            if (confirmarCarrito.Equals("SI"))
                            {
                                usuario[indiceUser].getRegistro().getCarrito(usuario[indiceUser].getCarrito());
                                usuario[indiceUser].getCarrito().getPedidos().Clear();
                                Console.WriteLine("COMPRA EXITOSA");
                            }
                            else
                            {
                                usuario[indiceUser].getCarrito().getPedidos().Clear();
                                Console.WriteLine("COMPRA NEGADA");
                            }
                            break;
                        }
                    case 4:
                        {
                            usuario[indiceUser].getRegistro().mostrarRegistro();
                            break;
                        }
                    case 5:
                        {
                            exitMenu = 1;
                            break;
                        }
                }

        }
        static void comprarProducto(ref List<Usuario> usuarios, ref List<Articulo> articulos, int indiceUser)
        {
            Pedido pedido = new Pedido();
            int selectID, indiceProducto, cantidad;
            foreach (Articulo articulo in articulos)
            {
                articulo.mostrarArticulo();
            }
            Console.WriteLine("DIGITE EL ID DEL PRODUCTO");
            selectID = int.Parse(Console.ReadLine());

            indiceProducto = encontrarIndiceProducto(articulos, selectID);
            if (indiceProducto != -1)
            {
                Console.Write("DIGITE LA CANTIDAD DEL PRODUCTO SELECCIONADO");
                cantidad = int.Parse(Console.ReadLine());
                pedido.getArticulo(articulos[indiceProducto], cantidad);
                usuarios[indiceUser].getCarrito().setPedido(pedido);
            }


        }
        static int encontrarIndiceProducto(List<Articulo> articulos, int selectID)
        {
            int indice = -1, i = 0;

            foreach (Articulo articulo in articulos)
            {
                if (selectID == articulo.getID())
                {
                    indice = i;
                }
                i++;
            }
            if (indice == -1)
            {
                Console.WriteLine("NO SE ENCONTRO EL PRODUCTO");
            }
            return indice;
        }


        public static int selectOption()
        {
            int opcion;
            do
            {
                Console.WriteLine("......MENU........" +
                    "\n[1]REGISTRAR NUEVO USUARIO" +
                    "\n[2]LOGEAR USUARIO" +
                    "\n[3]ADMINISTRADOR" +
                    "\n[4]SALIR");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion < 1 || opcion > 4);


            return opcion;
        }
    }
}
