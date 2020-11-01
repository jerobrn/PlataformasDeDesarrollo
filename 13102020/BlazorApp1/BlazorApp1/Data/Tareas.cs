using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorApp1.Data
{
    public class Tareas
    {
        [Key]
        public int IDTarea { get; set; }
        public String Titulo { get; set; }
        public String Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public String Responsable { get; set; }
        public bool bo { get; set; }

        public Tareas(int iDTarea, string titulo, string vencimiento, int estimacion, string responsable, bool bo)
        {
            
            IDTarea = iDTarea;
            Titulo = titulo;
            Vencimiento = vencimiento;
            Estimacion = estimacion;
            Responsable = responsable;
            this.bo = bo;
        }

        public Tareas()
        {

        }
    }
}
