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
        public DateTime Fecha { get; set; }
        public String Tiempo { get; set; }
        public Recursos Recurso { get; set; }

        public Detalles(int iDDetalle, DateTime fecha, string tiempo, Recursos recurso)
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
