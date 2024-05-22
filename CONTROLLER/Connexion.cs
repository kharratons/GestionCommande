using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;


namespace CONTROLLER
{
    public class Connexion
    {
        public static SqlConnection conn = new SqlConnection("database=gestionDeCommande;server=DESKTOP-JQ8ROCE;User ID=sa;pwd=pass");

        public  void Connecter()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                
            }
        }

        public bool ExecuteCommand(SqlCommand cmd)
        {
            cmd.Connection = conn;
            if (cmd.ExecuteNonQuery() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public  SqlDataReader Rdd(string value)
        {
            SqlCommand command = new SqlCommand(value, conn);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
    }
}
