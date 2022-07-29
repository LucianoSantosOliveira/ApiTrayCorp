using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiTrayCorp.Model;

namespace ApiTrayCorp.Data
{
    public class ApiTrayCorpContext : DbContext
    {
        public ApiTrayCorpContext (DbContextOptions<ApiTrayCorpContext> options)
            : base(options)
        {
        }

        public DbSet<ApiTrayCorp.Model.Produtos> Produtos { get; set; } = default!;
    }
}
