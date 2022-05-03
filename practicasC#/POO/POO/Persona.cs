using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Persona
    {
        private static int cont = 1;
        private int id;
        private String nombre;
        private String mail;
        private Pais pais;
        private int edad;

        public Persona(String nombre , String mail, int edad, Pais pais)
        {
            this.id = cont;
            this.nombre = nombre;
            setMail(mail);
            this.edad = edad;
            this.pais = pais;
            cont++;
        }
        public Persona(String nombre, int edad, Pais pais)
        {
            this.id = cont;
            this.nombre = nombre;
            setMail(null);
            this.edad = edad;
            this.pais = pais;

        }
        private void setMail(String mail)
        {
            if(verificarMail(mail))
            {
                this.mail = "SIN MAIL";
            }
            else
            {
                this.mail = mail;
            }
        }
        private Boolean verificarMail(String mail)
        {
            return mail == null;
        }
        
        
        public void mostrarPersona()
        {
            Console.WriteLine(" | " + id + " | " + nombre + " | " + edad + " | " + mail + " | "+pais);
        }
    }
}
