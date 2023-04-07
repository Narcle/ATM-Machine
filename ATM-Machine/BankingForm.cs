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
        public BankingForm()
        {
            InitializeComponent();
            //can I do variable changes here? To set AccountId, checking, savings
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Withdraw button, THE MAIN FUNCTION. If (drop down is checking) then withdraw from checking, etc for Savings too.
        private void Withdraw_Click(object sender, EventArgs e)
        {
            Update_Balances(1);
        }

        private void Update_Balances(int AccountID)
        {
            Account CurrentAcc = SQLHelper.GetAccount(AccountID);

            CustomerID.Text = CurrentAcc.AccountID.ToString();
            SavingsBalance.Text = CurrentAcc.Savings.ToString();
            CheckingBalance.Text = CurrentAcc.Checking.ToString();

        }

        private void BankingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
