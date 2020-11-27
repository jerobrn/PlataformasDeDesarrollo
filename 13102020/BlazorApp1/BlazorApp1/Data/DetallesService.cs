﻿using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class DetallesService
    {



        private DBCont context;

        public DetallesService(DBCont _context)
        {
            context = _context;
        }

        public async Task<List<Detalles>> GetAll()
        {
          //  return await context.Detalles.ToListAsync();


         //   var RemoteService = RestService.For<IRemoteService>("https://localhost:44341/api/");

           // return await RemoteService.GetDetalles();

            var remoteService = RestService.For<IRemoteService>("https://localhost:44341/api/");
            return await remoteService.GetDetalles();
        }

        public async Task<Detalles> Save(Detalles value)
        {
            /*
            if (value.IDDetalle == 0)
            {
                await context.Detalles.AddAsync(value);
            }
            else
            {
                context.Detalles.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
            */

            var remoteService = RestService.For<IRemoteService>("https://localhost:44341/api/");
            return await remoteService.GuardarDetalles(value);
        }

        public async Task<Detalles> Get(int id)
        {
            // return await context.Detalles.Where(i => i.IDDetalle == id).SingleAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44341/api/");
            return await remoteService.GetDetalles(id);
        }


        public async Task<bool> Borrar(int id)
        {
            var entidad = await context.Detalles.Where(i => i.IDDetalle == id).SingleAsync();
            context.Detalles.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }



    }
}
