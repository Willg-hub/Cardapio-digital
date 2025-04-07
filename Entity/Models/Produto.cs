using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Nome { get; set; }

        [MaxLength(5000)]
        public string Descricao { get; set; }

        [Column(TypeName = "numeric(10,2)")] // PostgreSQL decimal
        public decimal Preco { get; set; }

        public byte[]? Produto_imagem { get; set; } // mapeado como bytea automaticamente

        public bool Exibir { get; set; } // Corrigido o nome do campo

        [ForeignKey("Grupo")]
        public int Id_grupo { get; set; }

        public Grupo Grupo { get; set; }
    }
}
