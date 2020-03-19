using Microsoft.EntityFrameworkCore;

namespace TheBest.Models
{
  public class TheBestContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }

    public TheBestContext(DbContextOptions options) : base(options) { }
  }
}