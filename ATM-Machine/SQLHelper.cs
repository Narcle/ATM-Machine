using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    public static class SQLHelper
    {
        //const string SQLcs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
        const string SQLcs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Nathan\My Drive\WSCC\Programming 2 CIS135\ATM-Machine\ATM-Machine\Database1.mdf"";Integrated Security=True";

        //Select function
        public static void SelectFromDatabase(string sqlstring)
        {
          
        }

        //Update SQL table to reflect account changed variables, updates to SQL server only.
        public static void UpdateAccount(Account CurAccount)
        {
            using (SqlConnection con = new SqlConnection(SQLcs))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Accounts SET checkingBal=@Checking and savingsBal=@Savings WHERE AccountId=@Account", con);
                cmd.Parameters.AddWithValue("@Account", CurAccount.AccountID.ToString());
                cmd.Parameters.AddWithValue("@Checking", CurAccount.Checking.ToString());
                cmd.Parameters.AddWithValue("@Savings", CurAccount.Savings.ToString());
                try
                {
                    con.Open();
                    int test = cmd.ExecuteNonQuery();
                    if (test > 0)
                        Console.WriteLine("Account " + CurAccount.AccountID.ToString() + " has been updated.");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error Generated. Details: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                    Console.Read();

                }
            }
        }

        //Get account details from SQL server and insert into Account class for OO
        public static Account GetAccount(int AccountID)
        {

            using (SqlConnection con = new SqlConnection(SQLcs))
            {
                var checking = new decimal();
                var savings = new decimal();
                string query = "SELECT * FROM Accounts WHERE AccountId=@Account";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Account", AccountID);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {  
                        while (reader.Read()) 
                        {
                            checking = Convert.ToDecimal(reader["checkingBal"]);
                            savings = Convert.ToDecimal(reader["savingsBal"]);
                        }

                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error Generated. Details: " + ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                        Console.Read();

                    }
                    return new Account(AccountID, checking, savings);
                }
            }
        }
    }
}
