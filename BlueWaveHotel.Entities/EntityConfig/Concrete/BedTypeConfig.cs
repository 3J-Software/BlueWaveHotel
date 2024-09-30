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
            builder.Property(x => x.BedName).HasMaxLength(50);

            builder.HasData(
               new BedType { Id = "1", BedName = "Single" },
               new BedType { Id = "2", BedName = "Double" },
               new BedType { Id = "3", BedName = "Single-L" },
               new BedType { Id = "4", BedName = "Double-L" }
                );


        }
    }
}
