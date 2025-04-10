using Entity.Context;
using Entity.Interface;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly PgContext _context;

       public ProdutoRepository(PgContext pgContext)
        {
            _context = pgContext;
        }

        public void Create(Produto produto)
        {
            _context.Produto.Add(produto);
        }

        public void Update(Produto produto) { 
            var produtoExistente = _context.Produto.FirstOrDefault(x => x.Id == produto.Id);
            if (produtoExistente == null)
            {
                throw new Exception("Produto não encotrado");
            }
            else
            {
            _context.Produto.Update(produto);
            _context.SaveChanges();
            }

        }

        public List<Produto> GetAllProdutos()
        {
            return _context.Produto.ToList();
        }
    }
}
