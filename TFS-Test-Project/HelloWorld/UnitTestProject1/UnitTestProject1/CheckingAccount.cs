using System;

namespace UnitTestProject1
{
    internal class CheckingAccount
    {
        internal double Balance;
        private double currentBalance;
        private string v;

        public CheckingAccount(string v, double currentBalance)
        {
            this.v = v;
            this.currentBalance = currentBalance;
        }

        internal void Withdraw(double withdrawal)
        {
            throw new NotImplementedException();
        }
    }
}