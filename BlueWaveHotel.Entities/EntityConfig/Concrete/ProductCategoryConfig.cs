using BlueWaveHotel.Entities.EntityConfig.Abstract;
using BlueWaveHotel.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueWaveHotel.Entities.EntityConfig.Concrete
{
    public class ProductCategoryConfig : BaseConfig<ProductCategory>
    {
        public override void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.CategoryName).IsRequired();
            builder.HasIndex(x => x.CategoryName).IsUnique();

        }
    }
}
