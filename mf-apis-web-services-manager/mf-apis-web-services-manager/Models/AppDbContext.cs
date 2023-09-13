using Microsoft.EntityFrameworkCore;

namespace mf_apis_web_services_manager.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base (options)
        {
        }

        public DbSet <Veiculo> Veiculo { get; set; }
        public DbSet <Consumo> Consumos { get; set; }
    }
}
