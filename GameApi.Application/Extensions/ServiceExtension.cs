using GameApi.Application.Services;
using GameApi.Domain.Interfaces.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GameApi.Application.Extensions
{
    public static class ServiceExtension
    {
        public static void AddAplication(this IServiceCollection services)
        {
            services.AddTransient<IPlayerEquipamentoService, PlayerEquipamentoService>();
            services.AddTransient<IPlayerService, PlayerService>();
            services.AddTransient<IOgroService, OgroService>();
            services.AddTransient<IEquipamentoService, EquipamentoService>();
            services.AddTransient<IUserService, UserService>();
        }
    }
}
