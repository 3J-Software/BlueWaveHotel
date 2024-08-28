using BlueWaveHotel.Entities.EntityConfig.Abstract;
using BlueWaveHotel.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWaveHotel.Entities.EntityConfig.Concrete
{
    public class PackageConfig : BaseConfig<Package>
    {
        public override void Configure(EntityTypeBuilder<Package> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.PackageName).HasMaxLength(120);
            builder.HasIndex(x => x.PackageName).IsUnique(); //deneme
        }
    }
}
