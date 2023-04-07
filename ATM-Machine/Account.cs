using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    public class Account
    {
        //private instance variables to represent the user ID, checking and savings balance
        private int _AccountID;
        private decimal _checking;
        private decimal _savings;

        //constructor that recieves an User info and uses it to initialize the instance variable with public property
        public Account(int accID, decimal checking,  decimal savings)
        {
            AccountID = accID;
            Checking = checking;
            Savings = savings;
        }

        public int AccountID
        {
            get { return _AccountID; }
            set 
            {
                if (value > 0)
                    _AccountID = value;
                else
                    throw new Exception("AccountID can't be 0 or less.");
                   
            }
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
                    throw new Exception("Checking balance cannot be negative");
            }
        }

        public decimal Savings
        {
            get { return _savings; }
            set
            {
                if (value >= 0)
                    _savings = value;
                else
                    throw new Exception("Savings balance cannot be negative");
            }
        }

        //Method Credit should add an amount to the current balance
        public virtual void CreditChecking(decimal amount)
        {
            if (amount > 0)
                Checking += amount;
            else
                throw new Exception("Credited amount must be greater than zero");
        }

        public virtual void CreditSavings(decimal amount)
        {
            if (amount > 0)
                Savings += amount;
            else
                throw new Exception("Credited amount must be greater than zero");
        }
        //Method Debit should withdraw money from the Account and ensure that the debit amount does not exceed the
        //Account’s balance. If it does, the balance should be left unchanged, and the method should display the
        //message "Debit amount exceeded account balance." 

        //Hint: Define Account’s Debit method so that it returns a bool indicating whether money was withdrawn.
        public virtual bool DebitChecking(decimal amount)
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
        public virtual bool DebitSavings(decimal amount)
        {
            bool OK = true;
            if (Savings - amount >= 0)
            {
                Savings -= amount;
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
