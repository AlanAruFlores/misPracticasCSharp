using System;
namespace Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vectorNumeros = new int [5];
            int i, numeroNuevo, aux;
            for ( i = 0; i < 4; i++) 
            {
                Console.WriteLine("DIGITE EL NUMERO " + (i + 1));
                vectorNumeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("DIGITE EL NUMERO NUEVO");
            numeroNuevo = int.Parse(Console.ReadLine());
            vectorNumeros[4] = numeroNuevo;

            for(int k = 0; k < 5; k++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if(vectorNumeros[k] > vectorNumeros[j])
                    {
                        aux = vectorNumeros[k];
                        vectorNumeros[k] = vectorNumeros[j];
                        vectorNumeros[j] = aux;
                    }
                }
            }

            Console.WriteLine("VECTOR ORDENADO DE MENOR A MAYOR");
            for(int m = 4; m >=0; m--)
            {
                Console.Write(vectorNumeros[m] + " | ");
            }
        }
    }
}
