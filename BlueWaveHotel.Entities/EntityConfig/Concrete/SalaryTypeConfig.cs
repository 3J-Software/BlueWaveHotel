using BlueWaveHotel.Entities.EntityConfig.Abstract;
using BlueWaveHotel.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWaveHotel.Entities.EntityConfig.Concrete
{
    public class SalaryTypeConfig : BaseConfig<SalaryType>
    {
        public override void Configure(EntityTypeBuilder<SalaryType> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
