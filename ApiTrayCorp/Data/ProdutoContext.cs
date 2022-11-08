using ApiTrayCorp.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiTrayCorp.Data
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options)
    : base(options)
        {
        }
        public virtual DbSet<Produtos> Produtos { get; set; }
    }
}
