using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public static class Global
    {
      
        public static string constring = "server=Badhon\\SQLEXPRESS;Database=HMS;Trusted_connection=True;TrustServerCertificate=True;";

        public static void delete(string table, string pkeyname, int p_key)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();

                // Build query safely
                string query = $"DELETE FROM [{table}] WHERE [{pkeyname}] = @p_key";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@p_key", p_key);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
