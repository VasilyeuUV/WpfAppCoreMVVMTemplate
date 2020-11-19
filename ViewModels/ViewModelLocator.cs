using Microsoft.Extensions.DependencyInjection;
using WpfAppCoreMVVMTemplate.ViewModels.MainWindow;

namespace WpfAppCoreMVVMTemplate.ViewModels
{
    /// <summary>
    /// Позволяет осуществить доступ к конкретным ViewModel
    /// </summary>
    internal class ViewModelLocator
    {
        /// <summary>
        /// Свойство для получения ViewModel главного окна приложения
        /// </summary>
        public MainWindowViewModel MainWindowViewModel => App.Host.Services.GetRequiredService<MainWindowViewModel>();

    }
}
