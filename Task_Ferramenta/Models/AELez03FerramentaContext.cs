using Microsoft.EntityFrameworkCore;

namespace Task_Ferramenta.Models
{
    public class AELez03FerramentaContext : DbContext
    {
        public AELez03FerramentaContext(DbContextOptions<AELez03FerramentaContext> options) : base(options) { } 
        
        public DbSet<Reparto> Repartos { get; set; }
        public DbSet<Prodotto> Prodottos { get; set; }
    }
}
