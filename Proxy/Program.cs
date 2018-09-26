using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set your PIN");
            short pin = short.Parse(Console.ReadLine());
            BankProxy proxy = new BankProxy();
            if(proxy.EnterPIN(pin))
            {
                Console.WriteLine("Pin is correct your current account state is {0}", proxy.GetAccountState());
                proxy.GetMoneyFromAccount(1242);
                Console.WriteLine("Your current account state is {0}", proxy.GetAccountState());
                proxy.PayTheMoney(1000);
                Console.WriteLine("Your current account state is {0}", proxy.GetAccountState());
            }
            else
            {
                Console.WriteLine("Pin is incorrect.");
            }
            Console.ReadKey();
        }
    }
}
