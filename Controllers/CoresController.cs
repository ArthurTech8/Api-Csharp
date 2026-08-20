using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoresController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CoresController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var cores = _context.CoresTinta.ToList();

            return Ok(cores);
        }
    }
}