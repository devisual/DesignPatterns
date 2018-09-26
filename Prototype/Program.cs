using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var userState = new User
            {
                UserName = "User 1",
                UserLocation = new System.Drawing.Point(0, 0),
                UserWeaponLocation = new System.Drawing.Point(1, 3)
            };

            Console.WriteLine("Start game with user {0}", userState.UserName);
            Console.WriteLine("User location {0}, user weapon location {1}", userState.UserLocation, userState.UserWeaponLocation);

            userState.UserLocation = new System.Drawing.Point(10, 5);
            userState.UserWeaponLocation = new System.Drawing.Point(11, 5);

            Console.WriteLine("We are still playing. User location {0}, user weapon location {1}", userState.UserLocation, userState.UserWeaponLocation);

            var saveState = (UserState)userState.Clone();

            Console.WriteLine("Save user state");

            userState.UserLocation = new System.Drawing.Point(20, 2);
            userState.UserWeaponLocation = new System.Drawing.Point(21, 5);

            Console.WriteLine("User location {0}, user weapon location {1}", userState.UserLocation, userState.UserWeaponLocation);
            Console.WriteLine("Saved user state");
            Console.WriteLine("User location {0}, user weapon location {1}", saveState.UserLocation, saveState.UserWeaponLocation);
            Console.ReadKey();
        }
    }
}
