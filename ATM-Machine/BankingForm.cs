﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Machine
{
    public partial class BankingForm : Form
    {

        public BankingForm(int AccountNum)
        {
            InitializeComponent();
            //Send logged in account info to GUI, and save AccountID
            Account CurrentAcc = SQLHelper.GetAccount(AccountNum);
            Update_Balances(CurrentAcc);
        }

        //Load account balances from SQL Database and update the GUI text to reflect ID and balances.
        private void Update_Balances(Account CurrentAcc)
        {
            CustomerID.Text = CurrentAcc.AccountID.ToString();
            SavingsBalance.Text = CurrentAcc.Savings.ToString();
            CheckingBalance.Text = CurrentAcc.Checking.ToString();
            WithdrawAmount.Text = "0.00";
            TransferAmount.Text = "0.00";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //ToDo: Transfer of money between accounts (function and button layout)

        private void Withdraw_Click(object sender, EventArgs e)
        {
            //Withdraw Button (had to re-add it, stupid gui designer)
            //Withdraw button, THE MAIN FUNCTION. If (drop down is checking) then withdraw from checking, etc for Savings too.

            //Failsafes for checkboxes
            if ((checkBoxChecking.Checked) & (checkBoxSavings.Checked))
            {
                MessageBox.Show("Please only check only one checkbox for Checking or Savings account.");
                return;
            }
            if (!(checkBoxChecking.Checked) & !(checkBoxSavings.Checked))
            {
                MessageBox.Show("Please check one checkbox for Checking or Savings account.");
                return;
            }
            //if checking withdraw
            if (checkBoxChecking.Checked)
                {
                Account CurrentAcc = SQLHelper.GetAccount(Convert.ToInt32(CustomerID.Text));
                if (CurrentAcc.DebitChecking(Convert.ToDecimal(WithdrawAmount.Text)))
                {
                    MessageBox.Show("Withdraw from Checking = $" + WithdrawAmount.Text);//can you add a cancel to this?
                    SQLHelper.UpdateAccount(CurrentAcc);
                    Update_Balances(CurrentAcc);
                }                
            }
            //if savings withdraw
            if (checkBoxSavings.Checked)
            {
                Account CurrentAcc = SQLHelper.GetAccount(Convert.ToInt32(CustomerID.Text));
                if (CurrentAcc.DebitSavings(Convert.ToDecimal(WithdrawAmount.Text)))
                {
                    MessageBox.Show("Withdraw from Savings = $" + WithdrawAmount.Text);//can you add a cancel to this?
                    SQLHelper.UpdateAccount(CurrentAcc);  
                    Update_Balances(CurrentAcc);
                }
            }
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            //Failsafes
            if ((TransferToChecking.Checked) & (TransferToSavings.Checked))
            {
                MessageBox.Show("Please only check only one checkbox for Transfer.");
                return;
            }
            if (!(TransferToChecking.Checked) & !(TransferToSavings.Checked))
            {
                MessageBox.Show("Please check one checkbox for Checking or Savings account to transfer from/to.");
                return;
            }

            //Transfer $ from savings to checking
            if (TransferToChecking.Checked)
            {
                decimal amt = Convert.ToDecimal(TransferAmount.Text);
                if (amt > 0)
                {
                    Account CurrentAcc = SQLHelper.GetAccount(Convert.ToInt32(CustomerID.Text));
                    if (CurrentAcc.Savings >= amt)
                    {
                        if (CurrentAcc.DebitSavings(amt))
                        {
                            CurrentAcc.CreditChecking(amt);
                            SQLHelper.UpdateAccount(CurrentAcc);
                            Update_Balances(CurrentAcc);
                            MessageBox.Show("From Savings to Checking Transfer = $" + amt.ToString());
                        }
                    }
                }
            }
            //Transfer from checking to savings
            if (TransferToSavings.Checked)
            {
                decimal amt = Convert.ToDecimal(TransferAmount.Text);
                if (amt > 0)
                {
                    Account CurrentAcc = SQLHelper.GetAccount(Convert.ToInt32(CustomerID.Text));
                    if (CurrentAcc.Checking >= amt)
                    {
                        if (CurrentAcc.DebitChecking(amt))
                        {
                            CurrentAcc.CreditSavings(amt);
                            SQLHelper.UpdateAccount(CurrentAcc);
                            Update_Balances(CurrentAcc);
                            MessageBox.Show("From Checking to Savings Transfer = $" + amt.ToString());
                        }
                    }
                }
            }             
        }
    }
}
