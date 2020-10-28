using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareasService
    {

        public Tareas[] GetTareas()
        {
            Tareas[] lista = new Tareas[10];
            lista[0] = new Tareas ( 1, "Tarea0", "20/10/20", 2, "usuario1", true );
            lista[1] = new Tareas(1, "Tarea1", "20/10/20", 2, "usuario1", true);
            lista[2] = new Tareas(1, "Tarea2", "20/10/20", 2, "usuario1", true);
            lista[3] = new Tareas(1, "Tarea3", "20/10/20", 2, "usuario1", true);
            lista[4] = new Tareas(1, "Tarea4", "20/10/20", 2, "usuario1", true);
            lista[5] = new Tareas(1, "Tarea5", "20/10/20", 2, "usuario1", true);
            lista[6] = new Tareas(1, "Tarea6", "20/10/20", 2, "usuario1", true);
            lista[7] = new Tareas(1, "Tarea7", "20/10/20", 2, "usuario1", true);
            lista[8] = new Tareas(1, "Tarea8", "20/10/20", 2, "usuario1", true);
            lista[9] = new Tareas(1, "Tarea9", "20/10/20", 2, "usuario1", true);

            return lista;
        }
    }
}
