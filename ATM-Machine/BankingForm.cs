using System;
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
        }

        private void BankingForm_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Withdraw_Click_1(object sender, EventArgs e)
        {
            //Withdraw Button (had to re-add it, stupid gui designer)
            //Withdraw button, THE MAIN FUNCTION. If (drop down is checking) then withdraw from checking, etc for Savings too.
            
            //if (Checking drop down)

            Account CurrentAcc = SQLHelper.GetAccount(Convert.ToInt32(CustomerID.Text));
            CurrentAcc.DebitChecking(Convert.ToDecimal(WithdrawAmount.Text));
            SQLHelper.UpdateAccount(CurrentAcc);
            Update_Balances(CurrentAcc);

        }
    }
}
