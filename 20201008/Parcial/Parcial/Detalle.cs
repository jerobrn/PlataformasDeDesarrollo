using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Parcial
{
    public class Detalle
    {

        [Key]
        public int IDDetalle { get; set; }
        public DateTime Fecha { get; set; }
        public String Tiempo { get; set; }
        public Recurso Recurso { get; set; }




    }
}
