using BlueWaveHotel.Entities.EntityConfig.Abstract;
using BlueWaveHotel.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWaveHotel.Entities.EntityConfig.Concrete
{
    public class ProfessionConfig : BaseConfig<Profession>
    {
        public override void Configure(EntityTypeBuilder<Profession> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
            builder.HasIndex(x => x.Title).IsUnique();

            builder.Property(x => x.Shift).IsRequired().HasMaxLength(50);
            builder.HasIndex(x => x.Shift).IsUnique();
        }
    }
}
