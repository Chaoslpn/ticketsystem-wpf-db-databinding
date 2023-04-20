using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ticketsystem_WPF.Persistenz
{
    public static class DBZugriff
    {
        private static string CONNECTION = "Server=bszw.ddns.net;Database=bfi2124a_geyern;Uid=bfi2124a;Pwd=geheim;";
        public static MySqlConnection OpenDB()
        {
            MySqlConnection con = new MySqlConnection(CONNECTION);
            con.Open();
            return con;
        }
        public static void CloseDB(MySqlConnection con)
        {
            con.Close();
        }
        public static int ExecuteNonQuery(string sql)
        {
            using (MySqlConnection con = OpenDB())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                int anz = cmd.ExecuteNonQuery();
                return anz;
            }
        }
        public static MySqlDataReader ExecuteReader(string sql, MySqlConnection con)
        {
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public static int GetLastInsertId(MySqlConnection con)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", con);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
