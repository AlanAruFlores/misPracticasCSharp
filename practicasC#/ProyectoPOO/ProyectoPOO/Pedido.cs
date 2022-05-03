using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOO
{
    class Pedido
    {
        private String nombre;
        private int cantidad;
        private double precio;

        public void getArticulo(Articulo articulo, int cantidad)
        {
            setNombre(articulo.getNombre());
            setCantidad(cantidad);
            setPrecio(articulo.getPrecio(), cantidad);
        }
        private void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        private void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
        private void setPrecio(double precioAritculo, int cantidad)
        {
            precio = precioAritculo * cantidad;
        }
        public double getPrecio()
        {
            return precio;
        }

        public void mostrarPedido()
        {
            Console.WriteLine("" + nombre + " | CANTIDAD: " + cantidad + " | PRECIO A PAGAR: " + precio);
        }


    }
}
