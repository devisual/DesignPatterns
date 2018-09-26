namespace Proxy
{
    interface IBankService
    {
        double GetAccountState();
        void PayTheMoney(double amount);
        void GetMoneyFromAccount(double amount);
    }
}
