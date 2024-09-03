using BlueWaveHotel.DAL.Repository.Abstract;
using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.BL.Managers.Abstact
{
    public interface IManager<T> : IRepository<T> where T : BaseEntity
    {

    }
}
