using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class RecursosService
    {

        public Recursos[] GetRecursos()
        {
            Recursos[] lista = new Recursos[10];
            lista[0] = new Recursos(1, "Usuario1", new Usuarios(1, "Usuario1", "1234"));
          

            return lista;
        }



    }
}
