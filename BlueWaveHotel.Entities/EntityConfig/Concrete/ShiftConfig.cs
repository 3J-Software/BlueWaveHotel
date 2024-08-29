using BlueWaveHotel.Entities.EntityConfig.Abstract;
using BlueWaveHotel.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWaveHotel.Entities.EntityConfig.Concrete
{
    public class ShiftConfig : BaseConfig<Shift>
    {
        public override void Configure(EntityTypeBuilder<Shift> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Start).IsRequired();
            builder.Property(x => x.Finish).IsRequired();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.HasIndex(x => x.Name).IsUnique();

        }
    }
}
