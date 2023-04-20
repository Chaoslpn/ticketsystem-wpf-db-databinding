using _07_Ticketsystem_WPF.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ticketsystem_WPF.Persistenz
{
    public class DBProtokoll
    {
        public void Anlegen(Protokoll p)
        {
            string sql = $"INSERT INTO protokoll (date, editor, state, idticket)" +
                $"VALUES ({p.Date}, {p.Bearbeiter}, {p.Status}, {p.TicketId})";
            DBZugriff.ExecuteNonQuery(sql);
        }
        public List<Protokoll> AlleLesen()
        {
            List<Protokoll> protokolls = new List<Protokoll>();
            using (MySqlConnection con = DBZugriff.OpenDB())
            {
                string sql = "SELECT * FROM protokoll";
                using (MySqlDataReader rdr = DBZugriff.ExecuteReader(sql, con))
                {
                    while (rdr.Read())
                    {
                        Protokoll p = GetDataFromReader(rdr);
                        protokolls.Add(p);
                    }
                }
            }

            return protokolls;
        }
        private static Protokoll GetDataFromReader(MySqlDataReader rdr)
        {
            Protokoll p = new Protokoll();
            p.Id = rdr.GetInt32("id");
            p.Status = (TicketStatus)rdr.GetInt32("state");
            p.Date = rdr.GetDateTime("date");
            p.Bearbeiter = rdr.GetString("editor");
            p.TicketId = rdr.GetInt32("idticket");
            return p;
        }
    }
}
