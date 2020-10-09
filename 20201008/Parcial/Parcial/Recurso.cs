using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Parcial
{
    public class Recurso
    {

        [Key]
        public int IDRecurso { get; set; }
        public String Nombre { get; set; }
        public Usuario Usuario { get; set; }


    }
}
