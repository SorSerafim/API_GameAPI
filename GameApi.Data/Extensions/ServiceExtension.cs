using GameApi.Data.Context;
using GameApi.Data.Repositories;
using GameApi.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GameApi.Data.Extensions
{
    public static class ServiceExtension
    {
        public static void AddData(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddAutoMapper(Assembly.GetAssembly(typeof(GameApiContext)));
            services.AddDbContext<GameApiContext>(x => x.UseSqlServer(Configuration.GetConnectionString("GameConnection")));
            services.AddTransient<IPlayerRepository, PlayerRepository>();
            services.AddTransient<IOgroRepository, OgroRepository>();
            services.AddTransient<IEquipamentoRepository, EquipamentoRepository>();
            services.AddTransient<IPlayerEquipamentoRepository, PlayerEquipamentoRepository>();
        }
    }
}
