using System;

namespace wpf_mzc_app.Services
{
    public static class EmployeesService
    {
        public static event Action<object> _eventHandler;
        public static object CurrentUser;

        public static void SendData(object user)
        {
            CurrentUser = user;
            _eventHandler?.Invoke(user);
        }
    }
}