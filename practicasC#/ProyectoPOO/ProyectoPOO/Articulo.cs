using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOO
{
    class Articulo
    {
        private static int contID = 1;
        private int id;
        private String nombre;
        private int stock;
        private double precio;
        
        public Articulo (String nombre, double precio, int stock)
        {
            this.id = contID;
            this.nombre = nombre;
            this.stock = stock;
            this.precio = precio;
            contID++;
        }
        public int getID()
        {
            return id;
        }
        public String getNombre()
        {
            return nombre;
        }
        public double getPrecio()
        {
            return precio;
        }

        public void mostrarArticulo()
        {
            Console.WriteLine("ID: " + id + " | " + nombre + " | PRECIO: $" + precio);
        }
    }
}
