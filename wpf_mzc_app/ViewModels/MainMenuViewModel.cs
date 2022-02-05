using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using wpf_mzc_app.Infrastructure.Commands;
using wpf_mzc_app.Models;
using wpf_mzc_app.Models.ModelDB;
using wpf_mzc_app.Services;

namespace wpf_mzc_app.ViewModels
{
    public class MainMenuViewModel : ViewModel
    {
        private employee emp;

        private bool _isHide = false;

        #region Properties

        private string _AcssesTitle = "Вы зашли как, ";

        public string AcssesTitle
        {
            get
            {
                if (emp == null) return _AcssesTitle + "никто";

                switch (emp.post)
                {
                    case Post.Administrator: return _AcssesTitle + "администратор";

                    case Post.Manager: return _AcssesTitle + "менеджер";

                    case Post.Employee: return _AcssesTitle + "сотрудник";

                    default:
                        return "У вас нет должности";
                }
                
            }
            set => Set(ref _AcssesTitle, value);
        }
        
        private string _UserName = "Имя: ";

        public string UserName
        {
            get => _UserName;
            set => Set(ref _UserName, value);
        }
        
        private string _UserSecondName = "Фамилия: ";

        public string UserSecondName
        {
            get => _UserSecondName;
            set => Set(ref _UserSecondName, value);
        }
        
        private string _UserPatronymic = "Отчёство: ";

        public string UserPatronymic
        {
            get => _UserPatronymic;
            set => Set(ref _UserPatronymic, value);
        }
        
        #endregion

        #region Commands
        
        public ICommand CloseApplicationCommand { get; } //Command for binding.

        private bool CanCloseApplicationCommandExecute(object obj) => true;

        private void OnCloseApplicationCommandExecuted(object obj)
        {
            Application.Current.Shutdown();
        }
        
        public ICommand HideInfoCommand { get; }

        private bool CanHideInfoCommandExecute(object obj) => true;

        private void OnHideInfoCommandExecuted(object obj)
        {
            if (!_isHide)
            {
                string secretName = Regex.Replace(emp.fname, @"\w", "*");
                string secretSecondName = Regex.Replace(emp.lname, @"\w", "*");
                string secretPatronymic = Regex.Replace(emp.patronymic, @"\w", "*");
                
                UserName = "Имя: " + secretName;
                UserSecondName = "Фамилия: " + secretSecondName;
                UserPatronymic = "Отчество: " + secretPatronymic;
                
                _isHide = true;
            }
            else
            {
                UserName = "Имя: "  + emp.fname;
                UserSecondName = "Фамилия: "  + emp.lname;
                UserPatronymic = "Отчёство: "  + emp.patronymic;
                
                _isHide = false;
            }
        }
        
        #endregion

        public MainMenuViewModel()
        {
            CloseApplicationCommand =
                new RelayComand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            HideInfoCommand = 
                new RelayComand(OnHideInfoCommandExecuted, CanHideInfoCommandExecute);

            EmployeesService._eventHandler += OnChangeUserData;
            emp = (employee)EmployeesService.CurrentUser;
            
            _UserName += emp.fname;
            _UserSecondName += emp.lname;
            _UserPatronymic +=  emp.patronymic;

            //TODO: Binding two ViewModel between.
        }

        private void OnChangeUserData(object obj)
        {
            throw new NotImplementedException();
        }
    }
}