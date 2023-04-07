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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Bank ID #

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Bank PIN

        }

        //readonly string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
        readonly string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nathan\My Drive\WSCC\Programming 2 CIS135\ATM-Machine\ATM-Machine\Database1.mdf;Integrated Security=True";
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Login button
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please provide Account ID and Bank Pin");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from Accounts where AccountId=@username and bankpin=@password", con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    BankingForm fm = new BankingForm();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}