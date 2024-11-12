using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public class Grupo
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public byte[]? Imagem_grupo { get; set; }

        public bool Exibir { get; set; }
    }
}
