using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;
using WpfAppCoreMVVMTemplate.ViewModels;

namespace WpfAppCoreMVVMTemplate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        #region HOST

        private static IHost _host;

        /// <summary>
        /// Хост
        /// </summary>
        public static IHost Host => _host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        #endregion

        /// <summary>
        /// Подключение сервисов
        /// </summary>
        /// <param name="host"></param>
        /// <param name="services"></param>
        internal static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();   // ViewModel главного окна
        }

        /// <summary>
        /// Действия при запуске приложения
        /// </summary>
        /// <param name="e"></param>
        protected override async void OnStartup(StartupEventArgs e)
        {
            var host = Host;        // создаем хост
            base.OnStartup(e);

            await host.StartAsync().ConfigureAwait(false);      // запуск хоста в асинхронном режиме
        }

        /// <summary>
        /// Действия перед остановкой приложения
        /// </summary>
        /// <param name="e"></param>
        protected override async void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            var host = Host;
            await host.StopAsync().ConfigureAwait(false);      // остановка хоста в асинхронном режиме
            host.Dispose();
            _host = null;
        }

    }
}
