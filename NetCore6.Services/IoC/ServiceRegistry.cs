using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore6.Services.Services;

namespace NetCore6.Services.IoC
{
    public static class ServiceRegistry
    {
        public static void AddServiceRegistry(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ITurismoService, TurismoService>();

            services.AddHttpClient("BackEnd", client => 
            {
                client.BaseAddress = new Uri(configuration["AppSettings:ApiUrl"]);
            });
        }
    }
}