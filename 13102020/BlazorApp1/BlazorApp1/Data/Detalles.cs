using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Detalles
    {

        [Key]
        public int IDDetalle { get; set; }
        public String Fecha { get; set; }
        public String Tiempo { get; set; }
        public String Recurso { get; set; }

        public Detalles(int iDDetalle, String fecha, String tiempo, String recurso)
        {
            IDDetalle = iDDetalle;
            Fecha = fecha;
            Tiempo = tiempo;
            Recurso = recurso;
        }

        public Detalles()
        {
        }
    }
}
