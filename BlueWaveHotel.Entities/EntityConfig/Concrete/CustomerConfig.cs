using BlueWaveHotel.Entities.EntityConfig.Abstract;
using BlueWaveHotel.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWaveHotel.Entities.EntityConfig.Concrete
{
    public class CustomerConfig : BaseConfig<Customers>
    {
        public override void Configure(EntityTypeBuilder<Customers> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Adress).HasMaxLength(500).IsRequired();

            builder.Property(x => x.Id_Number).HasMaxLength(11).IsRequired();
            builder.HasIndex(x => x.Id_Number).IsUnique();

            builder.Property(x => x.Mail).HasMaxLength(100);
            builder.HasIndex(x => x.Mail).IsUnique();

            builder.Property(x => x.Phone).HasMaxLength(11).IsRequired();
            builder.HasIndex(x => x.Phone).IsUnique();

            builder.Property(x => x.NickName).HasMaxLength(50).IsRequired();
            builder.HasIndex(x => x.NickName).IsUnique();

            builder.Property(x => x.password).HasMaxLength(30).IsRequired();
        }
    }
}
