using ClassLibrary.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly DBCont _context;
        public UsuariosController(DBCont context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Usuarios> Get()
        {
            return _context.Usuarios.ToList();
        }





    }
}
