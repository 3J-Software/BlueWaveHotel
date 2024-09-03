using BlueWaveHotel.BL.Managers.Abstact;
using BlueWaveHotel.BL.Managers.Concrete;

namespace BlueWaveHotel.Extensions
{
    public static class BlueWaveHotelServices
    {
        public static IServiceCollection AddBlueWaveHotelService(this IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped(typeof(IManager<T>), typeof(BaseManager<T>));

            return services;
        }


    }
}
