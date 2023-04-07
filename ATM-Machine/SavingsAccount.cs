using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    //Derived class SavingsAccount should inherit the functionality of an Account, but also include a
    //decimal instance variable indicating the interest rate (percentage) assigned to the Account.
    class SavingsAccount : Account
    {
        private decimal _interestRate;
        //SavingsAccount’s constructor should receive the initial balance, as well as an initial value for the interest rate.
        public SavingsAccount(decimal balance, decimal interestRate) : base(balance)
        {

        }
        public decimal InterestRate
        {
            get { return _interestRate; }
            set
            {
                if (value > 0)
                    _interestRate = value;
                else
                    throw new Exception("InterestRate must be greater than zero");

            }
        }

        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }
}
