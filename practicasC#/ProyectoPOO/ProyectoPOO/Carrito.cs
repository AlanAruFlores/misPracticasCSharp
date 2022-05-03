using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOO
{
    class Carrito
    {
        private List<Pedido> pedidos = new List<Pedido> ();
        private double montoTotal = 0;
        
        public void setPedido(Pedido pedido)
        {
            pedidos.Add(pedido);
            setMonto(pedido);
        }
        public List<Pedido> getPedidos()
        {
            return pedidos;
        }
        private void setMonto(Pedido pedido)
        {
            montoTotal += pedido.getPrecio();
        }
        public double getMonto()
        {
            return montoTotal;
        }
        public void mostrarCarrito()
        {
            if(verificarCarritoVacio())
            {
                Console.WriteLine("CARRITO VACIO");
            }
            else
            {
                foreach(Pedido pedido in pedidos)
                {
                    pedido.mostrarPedido();
                }    
            }
        }
        private Boolean verificarCarritoVacio()
        {
            return pedidos.Count == 0 || pedidos == null;
        }

    }
}
