﻿using System.Windows;
using System.Windows.Input;
using WpfAppCoreMVVMTemplate.ViewModels.Base;
using WpfAppCoreMVVMTemplate.ViewModels.Commands;

namespace WpfAppCoreMVVMTemplate.ViewModels.MainWindow
{
    /// <summary>
    /// ViewModel Главного меню приложения
    /// </summary>
    internal class MainMenuViewModel : ViewModelBase
    {


        #region КОМАНДЫ

        #region CloseApplicationCommand

        private ICommand _closeApplicationCommand = null;
        public ICommand CloseApplicationCommand =>
            _closeApplicationCommand ??= new LambdaCommand(obj => { Application.Current.Shutdown(); });

        #endregion 

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
