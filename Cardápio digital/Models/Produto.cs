using System.ComponentModel.DataAnnotations;

namespace Cardapio_digital.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public byte[] Produto_imagem { get; set; }

        public int Id_grupo { get; set; }

        public Produto(string nome, string descricao, decimal preco, byte[] produto_imagem, int id_grupo)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Produto_imagem = produto_imagem;
            Id_grupo = id_grupo;
        }
    }
}
