using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using WpfAppCoreMVVMTemplate.Infrastructure.Commands;
using WpfAppCoreMVVMTemplate.ViewModels.Base;

namespace WpfAppCoreMVVMTemplate.ViewModels
{
    /// <summary>
    /// ViewModel Главного меню приложения
    /// </summary>
    internal class MainMenuViewModel : ViewModelBase
    {


        #region CloseApplicationCommand
        private ICommand _closeApplicationCommand = null;
        public ICommand CloseApplicationCommand => 
            _closeApplicationCommand ??= new LambdaCommand(obj => { Application.Current.Shutdown(); });
        #endregion





        // РЕАЛИЗАЦИЯ ОДНОЙ КОМАНДЫ (подробный вариант)

        //public MainMenuViewModel()
        //{
        //    //
        //    #region Команды
        //    CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
        //    #endregion
        //}


        //#region КОМАНДЫ

        //#region CloseApplicationCommand
        //public ICommand CloseApplicationCommand { get; }

        ///// <summary>
        ///// Условия доступности команды (закрытие приложения)
        ///// </summary>
        ///// <param name="p"></param>
        ///// <returns></returns>
        //private bool CanCloseApplicationCommandExecute(object p) => true;

        ///// <summary>
        ///// Работает, когда команда выполняется
        ///// </summary>
        ///// <param name="p"></param>
        //private void OnCloseApplicationCommandExecuted(object p)
        //{
        //    Application.Current.Shutdown();
        //} 
        //#endregion

        //#endregion

    }
}
