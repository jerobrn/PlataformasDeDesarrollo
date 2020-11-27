using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class RecursosService
    {


            private DBCont context;

            public RecursosService(DBCont _context)
            {
                context = _context;
            }

            public async Task<List<Recursos>> GetAll()
            {
            //  return await context.Recursos.ToListAsync();

            var RemoteService = RestService.For<IRemoteService>("https://localhost:44341/api/");

            return await RemoteService.GetRecursos();

        }

            public async Task<Recursos> Save(Recursos value)
            {
            /*
                if (value.IDRecurso == 0)
                {
                    await context.Recursos.AddAsync(value);
                }
                else
                {
                    context.Recursos.Update(value);
                }
                await context.SaveChangesAsync();
                return value;
            */
            var remoteService = RestService.For<IRemoteService>("https://localhost:44341/api/");
            return await remoteService.GuardarRecursos(value);
        }

            public async Task<Recursos> Get(int id)
            {
            // return await context.Recursos.Where(i => i.IDRecurso == id).SingleAsync();

            var remoteService = RestService.For<IRemoteService>("https://localhost:44341/api/");
            return await remoteService.GetRecursos(id);
        }



            public async Task<bool> Borrar(int id)
            {
                var entidad = await context.Recursos.Where(i => i.IDRecurso == id).SingleAsync();
                context.Recursos.Remove(entidad);
                await context.SaveChangesAsync();
                return true;
            }


       





    }


    
}
