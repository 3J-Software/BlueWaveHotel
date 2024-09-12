using BlueWaveHotel.BL.Managers.Abstract;
using BlueWaveHotel.BL.Managers.Concrete;
using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Extensions
{
    public static class BlueWaveHotelServices
    {
        public static IServiceCollection AddBlueWaveHotelService(this IServiceCollection services)
        {
            services.AddControllersWithViews();

            var entityTypes = typeof(BaseEntity).Assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(BaseEntity)));

            foreach (var entityType in entityTypes)
            {
                var managerType = typeof(BaseManager<>).MakeGenericType(entityType);
                var interfaceType = typeof(IManager<>).MakeGenericType(entityType);
                services.AddScoped(interfaceType, managerType);
            }

            return services;
        }
    }

}
