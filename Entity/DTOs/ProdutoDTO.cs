using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class ProdutoDTO
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public byte[] Produto_imagem { get; set; }

        public bool Exibir { get; set; }

        public int Id_grupo { get; set; }

    }
}
