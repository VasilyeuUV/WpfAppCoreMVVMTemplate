using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

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
