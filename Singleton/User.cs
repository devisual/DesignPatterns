using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    sealed class User
    {
        static User _user;
        int UserCount;
        public static User Instance
        {
            get
            {
                if (_user == null)
                {
                    _user = new User();
                }
                return _user;
            }     
        }
        private User()
        {
            UserCount = 1;
        }
        public int GetUserCounter()
        {
            UserCount++;
            return UserCount;
        }
    }
}
