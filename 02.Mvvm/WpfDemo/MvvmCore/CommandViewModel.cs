using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfDemo.MvvmCore
{
    public class CommandViewModel : ViewModelBase
    {
        public CommandViewModel(ICommand command)
        {
            if (command == null)
                throw new ArgumentNullException("command");
            this.Command = command;
        }
        public ICommand Command { get; private set; }
    }
}
