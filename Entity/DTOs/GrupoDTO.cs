using Entity.Models;

namespace Entity.DTOs
{
    public class GrupoDTO
    {
        public string Nome { get; set; }

        public byte[]? Imagem_grupo { get; set; }

        public bool Exibir { get; set; }

        public List<ProdutoDTO> ListaProdutos { get; set; }
    }
}
