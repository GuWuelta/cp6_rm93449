using cp6_rm93449.Models;
using Microsoft.EntityFrameworkCore;

namespace cp6_rm93449.Persistence
{
    public class OracleDbContext : DbContext
    {
        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options) { }

        public DbSet<Acessorio> Acessorio { get; set; }

        public DbSet<Carro> Carro { get; set; }

        public DbSet<Modelo> Modelo { get; set; }
    }
}
