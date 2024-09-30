using BlueWaveHotel.Entities.EntityConfig.Abstract;
using BlueWaveHotel.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BlueWaveHotel.Entities.EntityConfig.Concrete
{
    public class RoomConfig : BaseConfig<Room>
    {
        public override void Configure(EntityTypeBuilder<Room> builder)
        {

            base.Configure(builder);

            builder.Property(x => x.Status).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Capacity).IsRequired();


            base.Configure(builder);
            builder.Property(x => x.Status).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Capacity).IsRequired();

            for (int i = 1; i <= 76; i++)
            {
                if (i >= 1 && i < 10)
                {
                    builder.HasData(
                     new Room
                     {
                         Id = i.ToString(),
                         floorID = "1",
                         Capacity = 1,
                         Status = "avaible",
                     });
                    builder.HasMany(s => s.bedTypes).WithMany(x => x.rooms).UsingEntity(p => p.HasData(
                        new { roomsId = i.ToString(), bedTypesId = "1", }
                        ));
                }


                if (i >= 10 && i < 20)
                {
                    builder.HasData(
                    new Room
                    {
                        Id = i.ToString(),
                        floorID = "1",
                        Capacity = 3,
                        Status = "avaible",
                    });
                    builder.HasMany(s => s.bedTypes).WithMany(x => x.rooms).UsingEntity(p => p.HasData(
                        new { roomsId = i.ToString(), bedTypesId = "1", }
                        ));
                }


                if (i >= 20 && i < 30)
                {
                    builder.HasData(
                    new Room
                    {
                        Id = i.ToString(),
                        floorID = "2",
                        Capacity = 1,
                        Status = "avaible",
                    });
                    builder.HasMany(s => s.bedTypes).WithMany(x => x.rooms).UsingEntity(p => p.HasData(
                        new { roomsId = i.ToString(), bedTypesId = "1", }
                        ));
                }


                if (i >= 30 && i < 40)
                {
                    builder.HasData(
                    new Room
                    {
                        Id = i.ToString(),
                        floorID = "2",
                        Capacity = 2,
                        Status = "avaible",
                    });
                    builder.HasMany(s => s.bedTypes).WithMany(x => x.rooms).UsingEntity(p => p.HasData(
                        new { roomsId = i.ToString(), bedTypesId = "1" }
                        ));
                }


                if (i >= 40 && i < 50)
                {
                    builder.HasData(
                    new Room
                    {
                        Id = i.ToString(),
                        floorID = "3",
                        Capacity = 2,
                        Status = "avaible",
                    });
                    builder.HasMany(s => s.bedTypes).WithMany(x => x.rooms).UsingEntity(p => p.HasData(
                        new { roomsId = i.ToString(), bedTypesId = "2" }
                        ));
                }

                if (i >= 50 && i < 60)
                {
                    builder.HasData(
                    new Room
                    {
                        Id = i.ToString(),
                        floorID = "3",
                        Capacity = 3,
                        Status = "avaible",
                    });
                    builder.HasMany(s => s.bedTypes).WithMany(x => x.rooms).UsingEntity(p => p.HasData(
                    new { roomsId = i.ToString(), bedTypesId = "2" },
                    new { roomsId = i.ToString(), bedTypesId = "1" }
                    ));

                }
                if (i >= 60 && i < 70)
                {
                    builder.HasData(
                    new Room
                    {
                        Id = i.ToString(),
                        floorID = "4",
                        Capacity = 2,
                        Status = "avaible",
                    });
                    builder.HasMany(s => s.bedTypes).WithMany(x => x.rooms).UsingEntity(p => p.HasData(
                    new { roomsId = i.ToString(), bedTypesId = "2" }
                    ));

                }
                if (i >= 70 && i <= 76)
                {
                    builder.HasData(
                    new Room
                    {
                        Id = i.ToString(),
                        floorID = "4",
                        Capacity = 4,
                        Status = "avaible",
                    });

                    builder.HasMany(s => s.bedTypes).WithMany(x => x.rooms).UsingEntity(p => p.HasData(
                    new { roomsId = i.ToString(), bedTypesId = "2", },
                    new { roomsId = i.ToString(), bedTypesId = "1", }
                    ));


                }
            }


            builder.HasData(
            new Room
            {
                Id = "77",
                floorID = "4",
                Capacity = 2,
                Status = "avaible",
            });

            builder.HasMany(s => s.bedTypes).WithMany(x => x.rooms).UsingEntity(p => p.HasData(
            new { roomsId = "77", bedTypesId = "4", },
            new { roomsId = "77", bedTypesId = "3", }
            ));
        }

    }
}

