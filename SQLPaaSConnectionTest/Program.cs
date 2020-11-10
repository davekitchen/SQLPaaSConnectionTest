using System;
using System.Data.SqlClient;

namespace SQLPaaSConnectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = "Server=mkdcontest.database.windows.net,1433; Database=Contest; User ID=<UserName>;Password=<Password>;Trusted_Connection=False;Encrypt=True";

            using (SqlConnection conMain = new SqlConnection(conStr))
            {
                conMain.Open();

                string cmd = "INSERT INTO t_TestData(TheText) VALUES('Hello World2')";

                using (SqlCommand cmdMain = new SqlCommand(cmd, conMain))
                {
                    cmdMain.CommandType = System.Data.CommandType.Text;
                    cmdMain.ExecuteNonQuery();
                }
            }

            Console.WriteLine("All done press RETURN to exit.");
            Console.ReadLine();
        }
    }
}
