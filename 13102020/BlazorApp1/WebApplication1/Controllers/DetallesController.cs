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
    public class DetallesController : ControllerBase
    {


        private readonly DBCont _context;
        public DetallesController(DBCont context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Detalles> Get()
        {
            return _context.Detalles.ToList();
        }



    }
}
