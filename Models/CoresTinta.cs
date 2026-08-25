using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("Cores_tinta")]
    public class CoresTinta
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public string Cor { get; set; }
        public string volume { get; set; }
    }
}
