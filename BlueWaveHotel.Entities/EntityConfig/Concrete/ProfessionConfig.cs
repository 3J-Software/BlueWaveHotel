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


        }
    }
}
