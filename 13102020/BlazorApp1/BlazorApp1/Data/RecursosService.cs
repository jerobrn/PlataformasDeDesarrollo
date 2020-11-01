﻿using Microsoft.EntityFrameworkCore;
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
                return await context.Recursos.ToListAsync();
            }

            public async Task<Recursos> Save(Recursos value)
            {
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
            }

            public async Task<Recursos> Get(int id)
            {
                return await context.Recursos.Where(i => i.IDRecurso == id).SingleAsync();
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
