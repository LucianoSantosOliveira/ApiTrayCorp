using ApiTrayCorp.Model;

namespace ApiTrayCorp.Service
{
    public class ProdutosService
    {
        private ApiTrayCorp.Data.ProdutoContext _context;

        public ProdutosService(ApiTrayCorp.Data.ProdutoContext produtoContext)
        {
            _context = produtoContext;
        }

        public List<Produtos> GetProdutoById(Guid produtoId)
        {
            return _context.Produtos.Where(p => p.Id == produtoId).ToList();
        }

        public List<Produtos> GetAllProdutos()
        {
            return _context.Produtos.Where(p => p.Id != Guid.Empty).ToList();
        }

        public void EditProduto(Produtos produto)
        {
             _context.Produtos.Update(produto);
             _context.SaveChanges();
        }

        public void CreateProduto(Produtos produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void DeleteProduto(Produtos produto)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }
    }
}
