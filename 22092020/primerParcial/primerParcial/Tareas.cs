using System;
using System.Collections.Generic;
using System.Text;

namespace primerParcial
{
    public class Tareas
    {
        public string Titulo { get; set; }
        public string Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public Recursos Responsable { get; set; }
        public bool Estado { get; set; }


        public Tareas(string Titulo, string Vencimiento, int Estimacion, Recursos Responsable, bool Estado)
        {
            this.Titulo = Titulo;
            this.Vencimiento = Vencimiento;
            this.Estimacion = Estimacion;
            this.Responsable = Responsable;
            this.Estado = Estado;
        }





    }
}
