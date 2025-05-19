using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoProjem
{
    class LogHelper
    {
        public static class LogHelperr
        {
            public static void LogAction(string userName, string action, string details)
            {
                string connectionString = "BAĞLANTI DİZENİZ";
                
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO LOGS (KullanıcıAdı, İslem, Detaylar) VALUES (@UserName, @Action, @Details)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Action", action);
                    cmd.Parameters.AddWithValue("@Details", details);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

    }
}
