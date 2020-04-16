using Microsoft.EntityFrameworkCore;
using WebApiAspNetCore.Model;

namespace WebApiAspNetCore.Model
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}