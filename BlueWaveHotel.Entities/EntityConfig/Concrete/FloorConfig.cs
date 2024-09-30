using BlueWaveHotel.Entities.EntityConfig.Abstract;
using BlueWaveHotel.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWaveHotel.Entities.EntityConfig.Concrete
{
    public class FloorConfig : BaseConfig<Floor>
    {
        public override void Configure(EntityTypeBuilder<Floor> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.FloorNumber).HasMaxLength(20);

            builder.HasData(
           new Floor { FloorNumber = "z", Id = "z" },
           new Floor { FloorNumber = "1", Id = "1" },
           new Floor { FloorNumber = "2", Id = "2" },
           new Floor { FloorNumber = "3", Id = "3" },
           new Floor { FloorNumber = "4", Id = "4" }
           );
        }
    }
}
