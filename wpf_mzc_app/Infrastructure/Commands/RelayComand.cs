using System;
using wpf_mzc_app.Infrastructure.Commands.Base;

namespace wpf_mzc_app.Infrastructure.Commands
{
    public class RelayComand : Command
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public RelayComand(Action<object> Execute, Func<object, bool> CanExecute)
        {
            _execute = Execute;
            _canExecute = CanExecute;
        }

        public override bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;

        public override void Execute(object parameter) => _execute(parameter);
    }
}