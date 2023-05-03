using CelilCavus.cryptop.web.Entity;
using CelilCavus.cryptop.web.Models.Configuration;
using System.Data.Entity;


namespace CelilCavus.cryptop.web.Models.Contexts
{
    public class AppContext:DbContext
    {
        public DbSet<Home>  Homes { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<StartAutoMatic> StartAutoMatics { get; set; }
        public DbSet<Works> Works { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new HomeConfiguration());
            modelBuilder.Configurations.Add(new AboutConfiguration());
            modelBuilder.Configurations.Add(new StartAutoMaticConfiguration());
            modelBuilder.Configurations.Add(new WorkConfiguration());
        }
    }

}