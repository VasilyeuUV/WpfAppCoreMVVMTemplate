using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using WpfAppCoreMVVMTemplate.Infrastructure.Commands;
using WpfAppCoreMVVMTemplate.ViewModels.Base;

namespace WpfAppCoreMVVMTemplate.ViewModels
{
    internal class MainMenuViewModel : ViewModelBase
    {


        public MainMenuViewModel()
        {
            //
            #region Команды
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            #endregion
        }


        #region КОМАНДЫ

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        /// <summary>
        /// Условия доступности команды (закрытие приложения)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private bool CanCloseApplicationCommandExecute(object p) => true;

        /// <summary>
        /// Работает, когда команда выполняется
        /// </summary>
        /// <param name="p"></param>
        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        } 
        #endregion


        #endregion



    }
}
