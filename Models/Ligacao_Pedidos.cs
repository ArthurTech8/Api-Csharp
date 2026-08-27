using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("ligacao_pedidos")]
    public class Ligacao_Pedidos
    {
        [Key]

        public int Id { get; set; }
        public int Id_clientes { get; set; }
        public int Id_produto { get; set; }
        public int quantidade_pedido { get; set; }
        public DateTime data_pedido { get; set; }

    }
}
