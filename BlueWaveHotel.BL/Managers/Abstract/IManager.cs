using BlueWaveHotel.DAL.Repository.Abstract;
using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.BL.Managers.Abstract
{
    public interface IManager<T> : IRepository<T> where T : BaseEntity
    {

    }
}
