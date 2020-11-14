using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace WpfAppCoreMVVMTemplate
{
    public static class Program
    {
        /// <summary>
        /// Application Entry Point.
        /// </summary>        
        [System.STAThreadAttribute()]
        public static void Main()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }


        /// <summary>
        /// Создание хоста
        /// </summary>
        /// <param name="Args">Аргументы</param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] Args) =>
            Host.CreateDefaultBuilder(Args)                         // конфигурирование хоста
                .UseContentRoot(App.CurrentDirectory)               // рабочий каталог
                .ConfigureAppConfiguration((host, cfg) => cfg       // конфигурация приложения:
                    .SetBasePath(App.CurrentDirectory)                  // - базовый путь
                    .AddJsonFile("appsettings.json",                    // - файл конфигурации в формате JSON
                        optional: true,                                 // (true - файл является опциональным, т.е. если его нет, то данные не загружать)
                        reloadOnChange: true                            // (true - перечитать файл, если система обнаружит, что он изменился)
                        )
                    )
                .ConfigureServices(App.ConfigureServices);         // конфигурация сервисов (произведем в приложении в методе App.ConfigureServices)
    }
}
