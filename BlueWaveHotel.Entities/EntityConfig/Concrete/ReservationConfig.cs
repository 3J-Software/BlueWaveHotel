using BlueWaveHotel.Entities.EntityConfig.Abstract;
using BlueWaveHotel.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWaveHotel.Entities.EntityConfig.Concrete
{
    public class ReservationConfig : BaseConfig<Reservation>
    {
        public override void Configure(EntityTypeBuilder<Reservation> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.customers).IsRequired();
            builder.Property(x => x.package).IsRequired();
            builder.Property(x => x.BookingStart).IsRequired();
            builder.Property(x => x.BookingEnd).IsRequired();
            builder.Property(x => x.CheckIn).IsRequired();
            builder.Property(x => x.CheckOut).IsRequired();
            builder.Property(x => x.rooms).IsRequired();

        }
    }
}
