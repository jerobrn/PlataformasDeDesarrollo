using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuariosService
    {

        public Usuarios[] GetUsuarios()
        {
            Usuarios[] lista = new Usuarios[4];
            lista[0] = new Usuarios(1, "Usuario1", "1234");
            lista[1] = new Usuarios(2, "Usuario2", "1234");
            lista[2] = new Usuarios(3, "Usuario3", "1234");
            lista[3] = new Usuarios(4, "Usuario4", "1234");


            return lista;
        }

            private DBCont context;

            public UsuariosService(DBCont _context)
            {
                context = _context;
            }

            public async Task<List<Usuarios>> GetAll()
            {
                return await context.Usuarios.ToListAsync();
            }
        }


    
}
