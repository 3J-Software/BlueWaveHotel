using BlueWaveHotel.Entities.EntityConfig.Abstract;
using BlueWaveHotel.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWaveHotel.Entities.EntityConfig.Concrete
{
    public class ExtraConfig : BaseConfig<Extra>
    {
        public override void Configure(EntityTypeBuilder<Extra> builder)
        {
            base.Configure(builder);


        }
    }
}
