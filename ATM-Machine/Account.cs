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
        private int _accountID;
        private int _pinNum;
        private decimal _checking;
        private decimal _savings;//I could also see storing this as a list, for multiple savings accounts at different interest rates

        //constructor that recieves an account(customer) info and uses it to initialize the instance variable with public property
        public Account(int accID, int pinNum, decimal checking,  decimal savings)
        {
            AccountID = accID;
            PinNum = pinNum;
            Checking = checking;
            Savings = savings;
        }

        public int AccountID
        {
            get { return _accountID; }
            set 
            {
                if (value > 0)
                    _accountID = value;
                else
                    throw new Exception("AccountID can't be 0 or less.");
                   
            }
        }

        public int PinNum
        {
            get { return _pinNum; }
            set
            {
                if (value > 0)
                    _pinNum = value;
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
            bool OK = false;
            if (Checking - amount >= 0)
            {
                Checking -= amount;
                OK = true;
            }
            else if (Savings >= (Checking - amount))//Test if this works, automatically takes from savings on overdraw
            {
                Console.Write("Debit amount exceeds checking balance, remainder has be withdrawn from savings account.");
                Checking = 0;
                Savings -= amount;
                OK = true;
            }
            else
            {
                Console.Write("Debit amount exceeded checking account balance.");
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
                Console.Write("Debit amount exceeded savings account balance.");
                OK = false;
            }
            return OK;

        }
    }
}
