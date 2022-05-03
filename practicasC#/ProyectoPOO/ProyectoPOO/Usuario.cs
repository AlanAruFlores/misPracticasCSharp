using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOO
{
    class Usuario
    {

        private String mail;
        private String contraseña;
        private String nombre;
        private Carrito carrito;
        private Registro registro;

        public Usuario(String mail, String contraseña, String nombre)
        {
            this.mail = mail.ToLower();
            this.contraseña = contraseña;
            setNombre(nombre);
            carrito = new Carrito();
            registro = new Registro();
        }
        public void setNombre(String nombre)
        {
            if(verificarNombre(nombre))
            {
                this.nombre = "UNNAMED";
            }
            else
            {
                this.nombre = nombre;
            }
        }
        public Registro getRegistro()
        {
            return registro;
        }
        public Carrito getCarrito()
        {
            return carrito;
        }
        private Boolean verificarNombre(String nombre)
        {
            return nombre == null;
        }
        public String getMail()
        {
            return mail;
        }
        public String getConstraseña()
        {
            return contraseña;
        }
    }
}
