using System.ComponentModel.DataAnnotations;

namespace Cardapio_digital.Models
{
    public class Grupo
    {
        [Key]
        public int Id { get; set; }

        public string Nome {get; set; }

        public byte[]? Imagem_grupo { get; set; }

        public bool Exibir {  get; set; }
        public Grupo() 
        {

        }
    }
}
