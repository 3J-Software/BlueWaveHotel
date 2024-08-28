using BlueWaveHotel.Entities.EntityConfig.Abstract;
using BlueWaveHotel.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWaveHotel.Entities.EntityConfig.Concrete
{
    public class BedTypeConfig : BaseConfig<BedType>
    {
        public override void Configure(EntityTypeBuilder<BedType> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Bedtype).HasMaxLength(50);
        }
    }
}
