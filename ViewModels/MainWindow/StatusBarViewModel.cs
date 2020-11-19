using WpfAppCoreMVVMTemplate.ViewModels.Base;

namespace WpfAppCoreMVVMTemplate.ViewModels.MainWindow
{
    internal class StatusBarViewModel : ViewModelBase
    {

        #region СТАТУС ПРОГРАММЫ
        private string _status = "Статус";

        /// <summary>
        /// Статус программы
        /// </summary>
        public string Status
        {
            get => _status;
            set => Set(ref _status, value);
        } 
        #endregion



    }
}
