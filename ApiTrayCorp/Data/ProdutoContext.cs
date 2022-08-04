using ApiTrayCorp.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiTrayCorp.Data
{
    public class ProdutoContext : DbContext
    {
        public virtual DbSet<Produtos> Produtos { get; set; }
    }
}
