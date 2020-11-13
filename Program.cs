using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppCoreMVVMTemplate
{
    public static class Program
    {
        /// <summary>
        /// Application Entry Point.
        /// </summary>        
        //[System.Diagnostics.DebuggerNonUserCodeAttribute()]
        //[System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
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
        public static IHostBuilder CreateHostBuilder(string[] Args)
        {
            var host_builder = Host.CreateDefaultBuilder(Args);

            // конфигурирование хоста
            host_builder.UseContentRoot(Environment.CurrentDirectory);  // рабочий каталог
            host_builder.ConfigureAppConfiguration((host, cfg) =>       // конфигурация приложения
            {
                cfg.SetBasePath(Environment.CurrentDirectory);          // - базовый путь
                cfg.AddJsonFile("appsettings.json",                     // - файл конфигурации в формате JSON
                    optional: true,                                     // (true - файл является опциональным, т.е. если его нет, то данные не загружать)
                    reloadOnChange: true                                // (true - перечитать файл, если система обнаружит, что он изменился)
                    );                                                  
            });

            // конфигурация сервисов
            host_builder.ConfigureServices(App.ConfigureServices);       // конфигурацию сервисов произведем в приложении в методе App.ConfigureServices

            return host_builder;
        }

    }
}
