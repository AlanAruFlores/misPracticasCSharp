using System;
using System.Collections.Generic;
using System.Text;

namespace POO3
{
    class Repuesto
    {
        private int id ;
        private String nombre;
        private double precio;
        private int stock;
        private static int contID=1;
        public Repuesto(String nombre, double precio , int stock)
        {
            this.id = contID;
            this.nombre = nombre.ToUpper();
            this.precio = precio;
            this.stock = stock;
            contID++;
        }
        public int getID()
        {
            return id;
        }

        public double getPrecio()
        {
            return precio;
        }
        public void setStock(int cantidad)
        {
            if(verificarStock(cantidad))
            {
                Console.WriteLine("CANTIDAD NO DISPONIBLE");
            }
            else
            {
                stock -= cantidad;
            }
        }
        private Boolean verificarStock(int cantidad)
        {
            return cantidad > stock;
        }
        public int getStock()
        {
            return stock;
        }

        public void mostrarRepuesto()
        {
            Console.WriteLine("ID: "+id+" | " + nombre + " | PRECIO: $" + precio + " | STOCK:" + stock);
        }
    }
}
