namespace UnitTestProject1
{
    internal class BankAccount
    {
        private double beginningBalance;
        private string v;

        public BankAccount(string v, double beginningBalance)
        {
            this.v = v;
            this.beginningBalance = beginningBalance;
        }
    }
}