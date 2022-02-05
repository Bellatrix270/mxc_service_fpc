using System.Linq;
using System.Windows;
using System.Windows.Input;
using wpf_mzc_app.Infrastructure.Commands;
using wpf_mzc_app.Models.ModelDB;
using wpf_mzc_app.Services;
using wpf_mzc_app.Views.Windows;

namespace wpf_mzc_app.ViewModels
{
    public class AuthorizationWindowViewModel : ViewModel
    {
        #region Property
        private string _LoginUser = "Archi.dronerov@yandex.ru";

        public string LoginUser
        {
            get => _LoginUser;
            set => Set(ref _LoginUser, value);
        }

        private string _PasswordUser = "D21BmeC92gA33ool";

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
        
        public ICommand AuthorizationUserCommand { get; }

        private bool CanAuthorizationUserCommandExecute(object obj) => true; // TODO: add validate data.

        private void OnAuthorizationUserCommandExecute(object obj)
        {
            using (MZCServicePC db = new MZCServicePC())
            {
                var emp = db.employees.FirstOrDefault(
                    d => d.email == LoginUser &&  d.password == PasswordUser
                    ); //Firsts query very slow. Approximately 1.7 sec.

                if (emp != null)
                {
                    EmployeesService.SendData(emp);
                    new MainMenuWindow().Show();
                }
            }
        }

        #endregion

        public AuthorizationWindowViewModel()
        {
            CloseApplicationCommand =
                new RelayComand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            AuthorizationUserCommand =
                new RelayComand(OnAuthorizationUserCommandExecute, CanAuthorizationUserCommandExecute);
        }
    }
}