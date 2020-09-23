using System;
using System.Collections.Generic;
using System.Text;

namespace primerParcial
{
    public class Recursos
    {
        public string nombre { get; set; }
        public Usuarios usuario { get; set; }

        public Recursos(string nombre ,Usuarios usuario)
        {
            this.nombre = nombre;
            this.usuario = usuario;
        }





    }
}
