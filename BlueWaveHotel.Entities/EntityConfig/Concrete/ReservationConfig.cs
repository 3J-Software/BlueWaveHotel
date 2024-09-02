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
            //builder.HasOne(r => r.customers)
            //                   .WithMany() // Eğer Customers sınıfında ters bir ilişki yoksa WithMany() kullanılabilir
            //                   .IsRequired();
            //builder.HasOne(r => r.package)
            //                   .WithMany() // Eğer Package sınıfında ters bir ilişki yoksa WithMany() kullanılabilir
            //                   .IsRequired(); 
            builder.Property(x => x.BookingStart).IsRequired();
            builder.Property(x => x.BookingEnd).IsRequired();
            //builder.HasMany(r => r.rooms)
            //       .WithMany();
        }
    }
}
