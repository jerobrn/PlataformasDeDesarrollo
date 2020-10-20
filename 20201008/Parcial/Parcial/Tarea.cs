using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial
{
    public class Tarea
    {

        [Key]
        public int IDTarea { get; set; }
        public String Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public String Responsable { get; set; }
        public bool String { get; set; }


    }
}
