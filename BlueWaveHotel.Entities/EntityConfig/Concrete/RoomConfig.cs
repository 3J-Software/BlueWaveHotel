﻿using BlueWaveHotel.Entities.EntityConfig.Abstract;
using BlueWaveHotel.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BlueWaveHotel.Entities.EntityConfig.Concrete
{
    public class RoomConfig : BaseConfig<Room>
    {
        public override void Configure(EntityTypeBuilder<Room> builder)
        {
            //builder.HasMany(r => r.bedTypes)
            //       .WithMany(b => b.rooms);

            base.Configure(builder);

            builder.Property(x => x.Status).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Capacity).IsRequired();

            // 'floor' özelliği için doğru yapılandırma:
            //builder.HasOne(r => r.floor)
            //       .WithMany() // Floor sınıfının diğer ilişkileri yoksa, WithMany() kullanılabilir.
            //       .HasForeignKey(r => r.FloorId)
            //       .IsRequired();
        }
    }
}