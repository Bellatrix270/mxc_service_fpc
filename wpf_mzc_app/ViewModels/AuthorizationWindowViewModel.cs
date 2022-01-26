using System.Windows;
using System.Windows.Input;
using wpf_mzc_app.Infrastructure.Commands;

namespace wpf_mzc_app.ViewModels
{
    public class AuthorizationWindowViewModel : ViewModel
    {
        #region Property
        private string _LoginUser = "Ваш логин";

        public string LoginUser
        {
            get => _LoginUser;
            set => Set(ref _LoginUser, value);
        }

        private string _PasswordUser = "Ваш пароль";

        public string PasswordUser
        {
            get => _PasswordUser;
            set => Set(ref _PasswordUser, value);
        }
        #endregion

        #region Commands

        public ICommand CloseApplicationCommand { get; } //Command for binding.

        private bool CanCloseApplicationCommandExecute(object obj) => true;

        private void OnCloseApplicationCommandExecuted(object obj)
        {
            Application.Current.Shutdown();
        }

        #endregion

        public AuthorizationWindowViewModel()
        {
            CloseApplicationCommand =
                new RelayComand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
        }
    }
}