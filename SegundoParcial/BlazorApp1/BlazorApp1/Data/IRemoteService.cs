using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public interface IRemoteService 
    {

        [Get("/Usuarios")]
        Task<List<Usuarios>> GetUsuarios();
        
        [Get("/Recursos")]
        Task<List<Recursos>> GetRecursos();

        [Get("/Tareas")]
        Task<List<Tareas>> GetTareas();

        [Get("/Detalles")]
        Task<List<Detalles>> GetDetalles();


        [Post("/Usuarios")]
        Task<Usuarios> GuardarUsuario(Usuarios valor);

        [Post("/Recursos")]
        Task<Recursos> GuardarRecursos(Recursos valor);

        [Post("/Tareas")]
        Task<Tareas> GuardarTareas(Tareas valor);

        [Post("/Detalles")]
        Task<Detalles> GuardarDetalles(Detalles valor);

        [Get("/Usuarios/{id}")]
        Task<Usuarios> GetUsuario(int id);

        [Get("/Recursos/{id}")]
        Task<Recursos> GetRecursos(int id);

        [Get("/Tareas/{id}")]
        Task<Tareas> GetTareas(int id);

        [Get("/Detalles/{id}")]
        Task<Detalles> GetDetalles(int id);

    }
}
