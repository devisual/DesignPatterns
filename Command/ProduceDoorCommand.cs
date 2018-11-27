using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class ProduceDoorCommand : ICommand
    {
        Door _door;
        public ProduceDoorCommand(Door door)
        {
            _door = door;
        }
        public void Execute()
        {
            _door.Produce();
        }
    }
}
