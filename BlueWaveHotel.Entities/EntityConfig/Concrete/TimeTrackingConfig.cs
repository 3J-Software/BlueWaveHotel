using BlueWaveHotel.Entities.EntityConfig.Abstract;
using BlueWaveHotel.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWaveHotel.Entities.EntityConfig.Concrete
{
    public class TimeTrackingConfig : BaseConfig<TimeTracking>
    {
        public override void Configure(EntityTypeBuilder<TimeTracking> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Start).IsRequired();
            builder.Property(x => x.personels).IsRequired();
        }
    }
}
