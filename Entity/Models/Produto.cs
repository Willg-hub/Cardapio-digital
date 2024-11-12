using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public byte[] Produto_imagem { get; set; }

        public bool Exibiir { get; set; }

        public int Id_grupo { get; set; }

        public Produto()
        {

        }
    }
}
