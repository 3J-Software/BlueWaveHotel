using BlueWaveHotel.Entities.EntityConfig.Abstract;
using BlueWaveHotel.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWaveHotel.Entities.EntityConfig.Concrete
{
    public class PersonelConfig : BaseConfig<Personel>
    {
        public override void Configure(EntityTypeBuilder<Personel> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(80);

            builder.Property(x => x.Surname).IsRequired().HasMaxLength(80);

            builder.Property(x => x.BirthDate).IsRequired();

            //// SalaryType ile ilişki
            //builder.HasOne(p => p.salaryType)
            //       .WithMany() // Eğer SalaryType sınıfında ters ilişki yoksa WithMany() kullanılabilir.
            //       .HasForeignKey("SalaryTypeId") // Foreign Key olarak kullanılacak property
            //       .IsRequired();

            builder.Property(x => x.salary).IsRequired();

            // Profession ile ilişki
            //builder.HasOne(p => p.profession)
            //       .WithMany() // Eğer Profession sınıfında ters ilişki yoksa WithMany() kullanılabilir.
            //       .HasForeignKey("ProfessionId") // Foreign Key olarak kullanılacak property
            //       .IsRequired();

            builder.Property(x => x.Adress).IsRequired().HasMaxLength(500);

            builder.Property(x => x.ID_number).IsRequired().HasMaxLength(11);
            builder.HasIndex(x => x.ID_number).IsUnique();

            builder.Property(x => x.Status).IsRequired();

            builder.Property(x => x.NickName).IsRequired().HasMaxLength(50);
            builder.HasIndex(x => x.NickName).IsUnique();

            builder.Property(x => x.password).IsRequired().HasMaxLength(30);
            builder.HasIndex(x => x.password).IsUnique();
        }
    }
}
