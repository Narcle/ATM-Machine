using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    internal class User
    {
        //one private instance variable of type decimal to represent the account balance
        private decimal _checking;
        private int AccID;
        private decimal _savings;

        //constructor that recieves an initial balance and uses it to initialize the instance variable with public property
        public User(decimal checking, int accID, decimal savings)
        {
            Checking = checking;
            AccID = accID;
            Savings = savings;
        }
        public decimal Checking
        {
            //The property should validate the initial balance
            get { return _checking; }
            set
            {
                if (value >= 0)
                    _checking = value;
                else
                    throw new Exception("Balance cannot be negative");
            }
        }

        public decimal Savings
        {
            get { return _savings; }
            set
            {
                if (_savings != value);
            }
        }

        //Method Credit should add an amount to the current balance
        public virtual void Credit(decimal amount)
        {
            if (amount > 0)
                Checking += amount;
            else
                throw new Exception("Credited amount must be greater than zero");
        }
        //Method Debit should withdraw money from the Account and ensure that the debit amount does not exceed the
        //Account’s balance. If it does, the balance should be left unchanged, and the method should display the
        //message "Debit amount exceeded account balance." 

        //Hint: Define Account’s Debit method so that it returns a bool indicating whether money was withdrawn.
        public virtual bool Debit(decimal amount)
        {
            bool OK = true;
            if (Checking - amount >= 0)
            {
                Checking -= amount;
                OK = true;
            }
            else if (Savings >= (Checking - amount))
            {
                Console.Write("Debit amount exceeds checking balance, remainder has be withdrawn from savings account.");
                Checking = 0;
                Savings -= (Checking - amount);
                OK = true;
            }
            else
            {
                Console.Write("Debit amount exceeded account balance.");
                OK = false;
            }
            return OK;
        }


    }
}
