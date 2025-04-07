using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Interface
{
    public interface IProdutoRepository
    {
        public void Create(Produto produto);
        public void Update(Produto produto);
        public List<Produto> GetAllProdutos();
    }
}
