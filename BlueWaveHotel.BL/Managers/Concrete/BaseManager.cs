using BlueWaveHotel.BL.Managers.Abstract;
using BlueWaveHotel.DAL.Repository.Concrete;
using BlueWaveHotel.Entities.DbContexts;
using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.BL.Managers.Concrete
{
    public class BaseManager<T> : Repository<T>, IManager<T> where T : BaseEntity
    {

        private readonly mySqlContext _context;

        public BaseManager(mySqlContext context) : base(context)
        {
            _context = context;
        }


    }
}
