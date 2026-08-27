using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class Ligacao_PedidosController : ControllerBase
        {
            private readonly AppDbContext _context;

            public Ligacao_PedidosController(AppDbContext context)
            {
                _context = context;
            }

            [HttpGet]
            public IActionResult Get()
            {
                var ligacao = _context.Ligacao_Pedidos.ToList();

                return Ok(ligacao);
            }
        }
}
