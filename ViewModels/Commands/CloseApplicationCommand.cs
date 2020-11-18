using System.Windows;
using WpfAppCoreMVVMTemplate.ViewModels.Commands.Base;

namespace WpfAppCoreMVVMTemplate.ViewModels.Commands
{

    /// <summary>
    /// Класс конкретной команды
    /// </summary>
    internal class CloseApplicationCommand : CommandBase
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
