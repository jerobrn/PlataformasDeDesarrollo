using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;



namespace BlazorApp1.Data
{
    public class TareasService
    {
        private DBCont context;

        public TareasService(DBCont _context)
        {
            context = _context;
        }


        public async Task<List<Tareas>> GetAllTareas()
        {
            return await context.Tareas.ToListAsync();
        }

        public async Task<Tareas> Save(Tareas value)
        {
            if (value.IDTarea == 0)
            {
                await context.Tareas.AddAsync(value);
            }
            else
            {
                context.Tareas.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<Tareas> Get(int id)
        {
            return await context.Tareas.Where(i => i.IDTarea == id).SingleAsync();
        }

        public async Task<bool> Borrar(int id)
        {
            var entidad = await context.Tareas.Where(i => i.IDTarea == id).SingleAsync();
            context.Tareas.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }



    }
}
