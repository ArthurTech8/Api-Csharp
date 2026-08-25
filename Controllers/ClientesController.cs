using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var clientes = _context.Clientes.ToList();

            return Ok(clientes);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Clientes cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return CreatedAtAction(
                nameof(Get),
                new { id = cliente.Id },
                cliente
            );
        }
    }
}