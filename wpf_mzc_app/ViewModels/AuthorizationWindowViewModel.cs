namespace wpf_mzc_app.ViewModels
{
    public class AuthorizationWindowViewModel : ViewModel
    {
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
    }
}