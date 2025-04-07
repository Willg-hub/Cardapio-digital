using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public class Grupo
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Nome { get; set; }

        public byte[]? Imagem_grupo { get; set; }

        public bool Exibir { get; set; }

        public List<Produto> ListaProdutos { get; set; }
    }
}
