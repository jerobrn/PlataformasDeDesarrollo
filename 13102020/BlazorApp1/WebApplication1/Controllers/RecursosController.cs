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

    public class RecursosController : ControllerBase
    {
       
        private readonly DBCont _context;
        public RecursosController(DBCont context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Recursos> Get()
        {
            return _context.Recursos.ToList();
        }


    }
}
