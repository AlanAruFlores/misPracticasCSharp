using System;
using System.Collections;
namespace Aeropuerto
{
    class Program
    {
        static ArrayList listaAeropuertos = new ArrayList();
        static void Main(string[] args)
        {
            do
            {
                int opcion = IngresarOpcion();

                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            } while (IngresarOpcion() != 4);

        }
        static int IngresarOpcion()
        {
            int opcion;
            do
            {
                Console.WriteLine("DIGITE UNA OPCION" +
                "\n[1]VER AEROPUERTO" +
                "\n[2]INGRESAR AEROUERTO" +
                "\n[3]MOSTRAR PASAJEROS" +
                "\n[4]SALIR PROGRAMA");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion < 1 || opcion > 4);
            return opcion;
        }
        
        static void MostrarAeropuerto()
        {
            if (VerificarLista() != true)
            {
                Console.WriteLine("DIGITE EL ID");
                MostrarLista();
                int id = int.Parse(Console.ReadLine());
                int indice = encontrarIndice(id);
                if (indice != -1)
                {
                    Aeropuerto aeropuertoSeleccionado = (Aeropuerto)listaAeropuertos[indice];
                    Console.WriteLine(aeropuertoSeleccionado);
                }

            }
            else
                Console.WriteLine("NO HAY NINGUN AERPUERTO REGISTRADO EN EL MOMENTO");

        }
        private static int encontrarIndice(int id)
        {
            int indice = -1;
            for (int i = 0; i < listaAeropuertos.Count; i++)
            {
                Aeropuerto aeropuerto = (Aeropuerto)listaAeropuertos[i],
                if(aeropuerto.Id == id)
                {
                    indice = i;
                }
            }
            if (indice == -1)
                Console.WriteLine("ERROR, NO SE ENCONTRO EL ID ");
            return indice;
         }
        static void MostrarLista()
        {
            int i = 0;
            i++;

                foreach (Aeropuerto aeropuerto in listaAeropuertos)
                {
                    Console.WriteLine(aeropuerto);
                    i++;
                }
        }
        static bool VerificarLista() => listaAeropuertos.Count <= 0;

    }
}



        //interface IComputadora
        //{
        //    public void prenderPantalla();
        //}
        //interface IServidor
        //{
        //    public void prenderServidor();
        //}
        //class Dispositivo
        //{
        //    private int cantRam;
        //    private int cantAlmacenamiento;

//    public Dispositivo(int cantRam, int cantAlmacenamiento)
//    {
//        this.cantRam = cantRam;
//        this.cantAlmacenamiento = cantAlmacenamiento;
//    }
//}
//class Computadora : Dispositivo,IComputadora
//{
//    private string nombreTeclado;
//    public string NombreTeclado {get => nombreTeclado; set { nombreTeclado = value; } }

//    public Computadora(int cantRam, int cantAlmacenamiento, string nombreTeclado) : base(cantRam, cantAlmacenamiento)
//    {
//        this.nombreTeclado = nombreTeclado;
//    }
//    public void prenderPantalla()
//    {
//       Console.WriteLine("PRENDIENDO PANTALLA"); 
//    }
//}
//class Servidor : Dispositivo,IServidor
//{
//    public Servidor(int cantRam, int cantAlmacenamiento) : base(cantRam, cantAlmacenamiento) { }

//    public void prenderServidor()
//    {
//        Console.WriteLine("PRENDIENDO EL SERVIDOR");
//    }

//}