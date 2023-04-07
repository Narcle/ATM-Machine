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

        //update function
        public static void UpdateDatabase(string NameToUpdate, string GPA)
        {
            using (SqlConnection con = new SqlConnection(SQLcs))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Students SET Stu_GPA=@GPA WHERE Stu_Name=@NameToUpdate", con);
                cmd.Parameters.AddWithValue("@NameToUpdate", NameToUpdate);
                cmd.Parameters.AddWithValue("@GPA", GPA);
                try
                {
                    con.Open();
                    int test = cmd.ExecuteNonQuery();
                    if (test > 0)
                        Console.WriteLine(NameToUpdate + " has been updated.");
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


        //insert function
        public static void InsertIntoDatabase(string Name, string GPA)
        {
            using (SqlConnection con = new SqlConnection(SQLcs))
            {
                string query = "INSERT INTO Students (Stu_Name, Stu_GPA) VALUES (@Name, @GPA)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@GPA", GPA);

                try
                {
                    con.Open();
                    int test = cmd.ExecuteNonQuery();
                    if (test > 0)
                        Console.WriteLine("Records Inserted Successfully");
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

        //deletefunction
        public static void DeleteFromDatabase(string Name)
        {
            using (SqlConnection con = new SqlConnection(SQLcs))
            {
                string query = "DELETE FROM Students WHERE Stu_Name=@Name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", Name);

                try
                {
                    con.Open();
                    int test = cmd.ExecuteNonQuery();
                    if (test > 0)
                        Console.WriteLine("Records Deleted Successfully");
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

        //Select function
        public static void SelectFromDatabase(string sqlstring)
        {
          
        }

        //Update SQL table to reflect account changed variables, updates to SQL server only.
        public static void UpdateAccount(int AccountID, decimal Checking, decimal Savings)
        {
            using (SqlConnection con = new SqlConnection(SQLcs))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Accounts SET checkingBal=@Checking and savingsBal=@Savings WHERE AccountId=@AccountID", con);
                cmd.Parameters.AddWithValue("@AccountID", AccountID);
                cmd.Parameters.AddWithValue("@Checking", Checking);
                cmd.Parameters.AddWithValue("@Savings", Savings);
                try
                {
                    con.Open();
                    int test = cmd.ExecuteNonQuery();
                    if (test > 0)
                        Console.WriteLine("Account " + AccountID + " has been updated.");
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

        public static Account GetAccount(int AccountID)
        {

            using (SqlConnection con = new SqlConnection(SQLcs))
            {
                var checking = new decimal();
                var savings = new decimal();
                var retList = new List<string>();
                string query = "SELECT * FROM Accounts WHERE AccountId = " + AccountID.ToString() ;
                SqlCommand cmd = new SqlCommand(query, con);
                //cmd.Parameters.AddWithValue("@tableName", tableName);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {

                        while (reader.Read())
                        {
                            retList.Add(reader.GetString(0));
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
                    return Account(AccountID, checking, savings);
                }
            }
        }

        //Get Table data
        public static List<string> GetSQLTable(string tableName)
        {
            var retList = new List<string>();
            using (SqlConnection con = new SqlConnection(SQLcs))
            {
                string query = "SELECT * FROM " + tableName;
                SqlCommand cmd = new SqlCommand(query, con);
                //cmd.Parameters.AddWithValue("@tableName", tableName);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {

                        while (reader.Read())
                        {
                            retList.Add(reader.GetString(0));
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
                    return retList;
                }
            }
        }
    }
}
