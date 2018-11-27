using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class ProduceWindowCommand : ICommand
    {
        private Window[] _windows;
        public ProduceWindowCommand(Window[] windows)
        {
            _windows = windows;
        }
        public void Execute()
        {
            foreach (Window _window in _windows)
            {
                _window.Produce();
            }
        }
    }
}
