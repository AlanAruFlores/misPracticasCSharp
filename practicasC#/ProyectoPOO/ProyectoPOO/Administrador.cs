using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOO
{
    class Administrador
    {
        private String mail;
        private String contraseña;

        public Administrador(String mail, String contraseña)
        {
            this.mail = mail;
            this.contraseña = contraseña;
        }
        public String getMail()
        {
            return mail;
        }
        public String getContraseña()
        {
            return contraseña;
        }

    }
}
