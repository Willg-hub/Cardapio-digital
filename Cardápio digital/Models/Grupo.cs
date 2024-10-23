using System.ComponentModel.DataAnnotations;

namespace Cardapio_digital.Models
{
    public class Grupo
    {
        [Key]
        public int Id { get; set; }

        public string Nome {get; set; }

        byte[] Imagem_grupo { get; set; }
        public Grupo(string nome, byte[] imagem) 
        {
         this.Nome = nome;
         this.Imagem_grupo = imagem;
        }
    }
}
