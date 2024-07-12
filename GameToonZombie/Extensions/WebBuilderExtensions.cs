using GameToonZombie.BI.Interfaces;

namespace GameToonZombie.Extensions
{
    public static class WebBuilderExtensions
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddScoped<IBaseService, IBaseService>();
            services.AddScoped<IZombieService, IZombieService>();

            return services;
        }
    }
}
