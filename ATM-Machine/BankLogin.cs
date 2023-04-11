using System.Data.SqlClient;
using System.Data;

namespace ATM_Machine
{
    public partial class BankLogin : Form
    {

        public BankLogin()
        {
            InitializeComponent();
        }

        private void BankLogin_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            //Login button - why is it so hard to change button name? GUI editor hates it
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please provide Account ID and Bank Pin");
                return;
            }
            //Switch to SQLHelper.Account here, validate pin match for login.
            Account CurrentAcc = SQLHelper.GetAccount(Convert.ToInt32(textBox1.Text));
            if (CurrentAcc.PinNum == Convert.ToInt32(textBox2.Text))
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                BankingForm fm = new BankingForm(CurrentAcc.AccountID);
                fm.Show();
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }
    }
}