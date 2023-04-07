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
           SavingsBalance.Text = (0.01).ToString();
        }

        private void Update_Balances()
        {
            SavingsBalance.Text = (0.01).ToString();
            CheckingBalance.Text = (0).ToString();

        }
    }
}
