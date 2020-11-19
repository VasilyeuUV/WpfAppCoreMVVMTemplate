using Microsoft.Extensions.DependencyInjection;
using WpfAppCoreMVVMTemplate.ViewModels.MainWindow;

namespace WpfAppCoreMVVMTemplate.ViewModels
{
    internal static class ViewModelRegistrator
    {
        public static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            // здесь регистрируем ViewModels
            services.AddSingleton<MainWindowViewModel>();       // ViewModel главного окна

            return services;
        }
    }
}
