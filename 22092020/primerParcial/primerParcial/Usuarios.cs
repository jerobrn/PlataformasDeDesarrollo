using System;
using System.Collections.Generic;
using System.Text;

namespace primerParcial
{
    public class Usuarios
    {
        private string v1;
        private string v2;

        public Usuarios(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}
