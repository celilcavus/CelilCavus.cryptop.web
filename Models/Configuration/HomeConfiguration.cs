using CelilCavus.cryptop.web.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CelilCavus.cryptop.web.Models.Configuration
{
    public class HomeConfiguration:EntityTypeConfiguration<Home>
    {
        public HomeConfiguration()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(x => x.Title).IsRequired();
            this.Property(x => x.Title).HasMaxLength(50);

            this.Property(x => x.SubTitle).IsRequired();
            this.Property(x => x.SubTitle).HasMaxLength(50);

        }
    }
}