using Microsoft.EntityFrameworkCore;

namespace LovelyWaffles.RazorPages.Data
{
    public class WaffleDbContext
        : DbContext
    {
        public WaffleDbContext(DbContextOptions<WaffleDbContext> options)
            : base(options)
        {
        }
        public DbSet<Waffle> Waffles { get; set; }
    }
}
