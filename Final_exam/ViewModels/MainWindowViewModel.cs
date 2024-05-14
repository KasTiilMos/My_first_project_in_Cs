using Final_exam.Inarastrure.Comands;
using Final_exam.ViewModels.Base;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace Final_exam.ViewModels
{
    
    internal class MainWindowViewModel : ViewModel
    {
        public MainWindowViewModel() 
        {
            CloseAppCommand = new LambdaCommand(OnCloseAppCommandExecuted, CanCloseAppCommandExecute);
        }
        private string _Title = "Книги";

        public string Title
        {
            get => _Title;
            set { set(ref _Title, value);}
        }
        /// <summary>
        /// Статус программы
        /// </summary>
        private string _Status = "Готов!";

        public string Status
        {
            get => _Status;
            set => set(ref _Status, value);
        }


        #region Команды

        public ICommand CloseAppCommand { get;}

        private bool CanCloseAppCommandExecute(object p) => true;
        
        private void OnCloseAppCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }
        #endregion
    }
}
