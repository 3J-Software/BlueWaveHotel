﻿using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class BedType : BaseEntity
    {
        public string BedName { get; set; }
        public ICollection<Room> rooms { get; set; }

    }
}