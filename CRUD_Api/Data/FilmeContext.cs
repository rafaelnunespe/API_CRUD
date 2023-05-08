using CRUD_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Api.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt)
        {

        }

        public DbSet<Filme> Filmes { get; set; }
    }
}
