using CelilCavus.cryptop.web.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CelilCavus.cryptop.web.Models.Configuration
{
    public class AboutConfiguration:EntityTypeConfiguration<About>
    {
        public AboutConfiguration()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(x => x.Image).IsRequired();
            this.Property(x => x.Image).HasMaxLength(50);

            this.Property(x => x.Description).IsRequired();
            this.Property(x => x.Description).HasMaxLength(500);
        }
    }
}