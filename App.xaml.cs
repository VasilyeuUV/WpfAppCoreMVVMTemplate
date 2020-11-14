using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using WpfAppCoreMVVMTemplate.ViewModels;

namespace WpfAppCoreMVVMTemplate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        /// <summary>
        /// Подключение сервисов
        /// </summary>
        /// <param name="host"></param>
        /// <param name="services"></param>
        internal static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();   // ViewModel главного окна
        }




        #region SELECT CURRENT DIRECTORY

        /// <summary>
        /// Свойство, отвечает на вопрос: работа происходит в режиме дизайна 
        /// или приложение запущено в нормальном режиме
        /// </summary>
        public static bool IsDesignMode { get; private set; } = true;

        /// <summary>
        /// Рабочая директория в зависимости от режима работы
        /// </summary>
        public static string CurrentDirectory => IsDesignMode
            ? Path.GetDirectoryName(GetSourceCodepath())            // приложение запущено в дизайнере
            : Environment.CurrentDirectory;                         // приложение запущено в нормальном режиме

        /// <summary>
        /// Возвращает путь к директории файла App.xaml.cs
        /// (испольуется в качестве текущей директории в режиме Дизайнера)
        /// </summary>
        /// <returns></returns>
        private static string GetSourceCodepath([CallerFilePath] string path = null) => path;

        #endregion



        #region HOST

        private static IHost _host;

        /// <summary>
        /// Хост
        /// </summary>
        public static IHost Host => _host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        #endregion


        #region START & STOPE HOST
        /// <summary>
        /// Действия при запуске приложения
        /// </summary>
        /// <param name="e"></param>
        protected override async void OnStartup(StartupEventArgs e)
        {
            IsDesignMode = false;

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
        #endregion

    }
}
