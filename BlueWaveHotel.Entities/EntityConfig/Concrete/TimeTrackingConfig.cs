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

            // Start ve Finish özellikleri zorunlu
            builder.Property(x => x.Start).IsRequired();
            builder.Property(x => x.Finish).IsRequired();

            // personels koleksiyonu için ilişki tanımlaması
            //builder.HasMany(tt => tt.personels)
            //       .WithMany(); // Eğer Personel sınıfında ters bir ilişki yoksa WithMany() kullanılabilir
        }
    }
}
