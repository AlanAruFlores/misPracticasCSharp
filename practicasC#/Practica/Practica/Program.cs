using System;
using System.Collections;
using System.Collections.Generic;


namespace Practica
{
    class Program
    {
        static ArrayList encontrarIndices(int [] numeros, int searchNumber)
        {
            ArrayList arrayIndices = new ArrayList ();
            
            for(int i = 0; i <  numeros.Length; i++)
            {
                if(searchNumber == numeros[i])
                {
                    arrayIndices.Add(i);
                }
            }
            if(arrayIndices == null) // Validar si el ArrayList esta vacio
            {
                Console.WriteLine("EL NUMERO NO SE ENCONTRO EN EL ARRAY");
            }
            return arrayIndices;
        }
        static void Main(string[] args)
        {
            int [] numero = new int [10];
            ArrayList indices = new ArrayList();
            int acum = 0, searchNumber;

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("DIGITE EL NUMERO " + (i + 1));
                numero[i] = int.Parse(Console.ReadLine());
                acum += numero[i];
            }

            Console.WriteLine("DIGITE EL NUMERO A BUSCAR DENTRO DEL ARRAY");
            searchNumber = int.Parse(Console.ReadLine());
            indices = encontrarIndices(numero,searchNumber);


            mostrarVector(numero);
            Console.WriteLine("\nPOSICIONES DONDE SE UBICA EL NRO");
            foreach(int indice in indices)
            {
                Console.Write((indice+1) + " | ");
            }
            Console.WriteLine($"\nLA SUMATORIA DE TODO EL VECTOR ES: {acum}")
                
                ;


        }
        static void mostrarVector(int [] arrayNumeros)
        {

            Console.WriteLine("VECTOR:");
            for(int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.Write(arrayNumeros[i]+" | ");
            }

        }
        //static int sumaNumeros(int num, int num2) => num + num2;
        //static int sumaNumeros(int num, int num2, int num3) => num + num2 + num3;
        //static int sumaNumeros(int contNum)
        //{
        //    int numero, acumNumeros=0;
        //    for(int i =  0; i < contNum; i++)
        //    {
        //        Console.WriteLine("DIGITE EL NUMERO " + (i + 1));
        //        numero = int.Parse(Console.ReadLine());
        //        acumNumeros += numero;
        //    }
        //    return acumNumeros;
        //}
    }
}
