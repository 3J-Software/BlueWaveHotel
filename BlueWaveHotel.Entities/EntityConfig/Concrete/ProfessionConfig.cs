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

            // Title özelliği
            builder.Property(x => x.Title)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasIndex(x => x.Title).IsUnique();

            // Shift özelliği bir ICollection olduğundan, ilişki olarak yapılandırılmalı
            builder.HasMany(p => p.Shift)
                   .WithOne() // Eğer Shift içinde ters ilişki yoksa WithOne() kullanılabilir
                   .IsRequired(false); // Eğer bir Shift'in birden fazla Profession ile ilişkisi yoksa
        }
    }
}
