using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Parcial
{
    public class Usuario
    {

        [Key]
        public int IDUser { get; set; }
        public String User { get; set; }
        public String Clave { get; set; }


    }
}
