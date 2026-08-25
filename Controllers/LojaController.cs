using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class LojaController : ControllerBase
        {
            private readonly AppDbContext _context;

            public LojaController(AppDbContext context)
            {
                _context = context;
            }

            [HttpGet]
            public IActionResult Get()
            {
                var resultado = _context.Clientes
                    .Join(
                        _context.CoresTinta,
                        cliente => cliente.Id,
                        tinta => tinta.Id,
                        (cliente, tinta) => new
                        {
                            Cliente = cliente.nome,
                            CPF = cliente.cpf,
                            Produto = tinta.Nome,
                            Cor = tinta.Cor,
                            Preco = tinta.Preco,
                            Quantidade = tinta.Quantidade,
                            Volume = tinta.volume
                        }
                    )
                    .ToList();

                return Ok(resultado);
            }
        }
    }

