namespace Proxy
{
    class BankService : IBankService
    {
        short _pin;
        double AccountState = 12000;
        public BankService(short pin)
        {
            _pin = pin;
        }
        public double GetAccountState()
        {
            return AccountState;
        }

        public void GetMoneyFromAccount(double amount)
        {
            AccountState = AccountState - amount;
        }

        public void PayTheMoney(double amount)
        {
            AccountState = AccountState + amount;
        }
    }
}
