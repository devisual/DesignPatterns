namespace Proxy
{
    class BankProxy : IBankService
    {
        IBankService MyAccount;
        short _pin;
        public bool EnterPIN(short pin)
        {
            _pin = pin;
           return IsPinValid();
        }

        private bool IsPinValid()
        {
           if(_pin == 5147)
            {
                CreateBankServiceInstance();
                return true;
            }
            return false;
        }

        private void CreateBankServiceInstance()
        {
            MyAccount = new BankFactory().GetBankService(_pin);
        }

        public double GetAccountState()
        {
            return MyAccount.GetAccountState();
        }

        public void GetMoneyFromAccount(double amount)
        {
            MyAccount.GetMoneyFromAccount(amount);
        }

        public void PayTheMoney(double amount)
        {
            MyAccount.PayTheMoney(amount);
        }
    }
}
