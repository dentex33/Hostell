using Microsoft.EntityFrameworkCore;

namespace Hostell.Models
{
    public class HostelAppContext : DbContext
    {
        public DbSet<Resident> Residents { get; set; }
        public DbSet<Block> Blocks { get; set; }

        public HostelAppContext(DbContextOptions<HostelAppContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
