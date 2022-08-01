using System.Windows;
using Test_MVVM.Infrastructure.Commands.Base;

namespace Test_MVVM.Infrastructure.Commands
{
    internal class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}