using Microsoft.EntityFrameworkCore;

namespace LovelyWaffles.MVC.Models
{
    public class WaffleDBContext
        :DbContext
    {
        public WaffleDBContext(DbContextOptions<WaffleDBContext> options)
            :base(options)
        {
        }
        public DbSet<Waffle> Waffles { get; set; }
    }
}
