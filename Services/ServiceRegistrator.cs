using Microsoft.Extensions.DependencyInjection;
using WpfAppCoreMVVMTemplate.Services._ServiceInterfaces;
using WpfAppCoreMVVMTemplate.Services.Examples;

namespace WpfAppCoreMVVMTemplate.Services
{
    /// <summary>
    /// Регистратор сервисов
    /// </summary>
    internal static class ServiceRegistrator
    {

        /// <summary>
        /// Регистрация всех сервисов, необходимых приложению
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            // здесь регистрируем сервисы. пример: 
            // services.AddSingleton<IClassService, ClassService>();    // объект будет создан единожды при первом запросе его
            // services.AddTrancient<IClassService, ClassService>();    // при каждом обращении будет зарегистрироваться новый временный объект
            // services.AddScoped<IClassService, ClassService>();       // позволяет зарегистрировать сервис в режиме области видимости

            services.AddTransient<IAsyncServiceExample, AsyncServiceExample>(); // пример регистрации асинхронного сервиса, удалить

            return services;
        }
    }
}
