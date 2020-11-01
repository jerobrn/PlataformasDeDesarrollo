using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Recursos
    {

        [Key]
        public int IDRecurso { get; set; }
        public String Nombre { get; set; }
        public String Usuario { get; set; }

        public Recursos()
        {

        }
        public Recursos(int iDRecurso, string nombre, string usuario)
        {
            IDRecurso = iDRecurso;
            Nombre = nombre;
            Usuario = usuario;
        }
    }
}
