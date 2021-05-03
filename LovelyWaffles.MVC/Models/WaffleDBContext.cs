using Microsoft.EntityFrameworkCore;

namespace LovelyWaffles.MVC.Models
{
    public class WaffleDbContext
        :DbContext
    {
        public WaffleDbContext(DbContextOptions<WaffleDbContext> options)
            :base(options)
        {
        }
        public DbSet<Waffle> Waffles { get; set; }
    }
}
