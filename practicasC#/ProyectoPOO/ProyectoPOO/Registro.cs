using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOO
{
    class Registro
    {
        List<Pedido> pedidos = new List<Pedido>();
        private double totalPagado=0;

        public void getCarrito(Carrito carrito)
        {
            setPedidos(carrito.getPedidos());

        }
        private void setTotal(Carrito carrito)
        {
            totalPagado += carrito.getMonto();
        }
        private void setPedidos(List<Pedido>pedidosCarrito)
        {
            for(int i  = 0; i < pedidosCarrito.Count; i++)
            {
                pedidos.Add(pedidosCarrito[i]);
            }
        }
        public void mostrarRegistro()
        {
            if(verificarVacio())
            {
                Console.WriteLine("REGISTRO VACIO");
            }
            else
            {
                Console.WriteLine("TOTAL PAGADO: $" + totalPagado);
                foreach(Pedido pedido in pedidos)
                {
                    pedido.mostrarPedido();
                }
            }
        }
        private Boolean verificarVacio()
        {
            return pedidos.Count == 0 || pedidos == null;
        }
    }
}
