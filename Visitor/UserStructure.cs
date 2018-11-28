using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class UserStructure
    {
        List<User> _users = new List<User>();
        public void Add(User user)
        {
            _users.Add(user);
        }
        public void Remove(User user)
        {
            _users.Remove(user);
        }
        public void Accept(Module module)
        {
            foreach(User user in _users)
            {
                user.Accept(module);
            }
        }
    }
}
