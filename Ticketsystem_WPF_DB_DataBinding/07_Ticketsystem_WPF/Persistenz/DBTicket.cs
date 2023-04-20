using _07_Ticketsystem_WPF.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketsystem_WPF;

namespace _07_Ticketsystem_WPF.Persistenz
{
    public static class DBTicket
    {
        public static List<Ticket> AlleLesen()
        {
            List<Ticket> lstticket = new List<Ticket>();

            using (MySqlConnection con = DBZugriff.OpenDB())
            {
                string sql = "SELECT * FROM ticket";
                using (MySqlDataReader rdr = DBZugriff.ExecuteReader(sql, con))
                {
                    while (rdr.Read())
                    {
                        Ticket ticket = GetDataFromReader(rdr);
                        lstticket.Add(ticket);
                    }
                }
            }

            return lstticket;
        }
        public static void Anlegen(Ticket t)
        {
            string sql = $"INSERT INTO ticket (status, beschreibung, zeitpunkt, kunde) " +
                         $"VALUES ({(int)t.Status}, '{t.Beschreibung}', '{t.Zeitpunkt.ToString("yyyy-MM-dd")}', {t.Kunde.Id})";

            DBZugriff.ExecuteNonQuery(sql);
        }
        public static void Aendern(Ticket t)
        {
            string sql = $"UPDATE ticket " +
                         $"SET status = {(int)t.Status}, beschreibung = '{t.Beschreibung}', zeitpunkt = '{t.Zeitpunkt.ToString("yyyy-MM-dd")}', kunde = {t.Kunde.Id} " +
                         $"WHERE id = {t.Id} AND zeitstempel = '{t.Zeitstempel.ToString("yyyy-MM-dd hh:mm:ss")}'";

            if (DBZugriff.ExecuteNonQuery(sql) == 0)
            {
                // Trickreich: folgende Methode löst eine Exception aus, falls das Ticket gelöscht wurde
                //             die nachfolgende Zeile wird nicht mehr erreicht
                GetTicketByID(t.Id);
                throw new MultiUserAccessException($"Das Ticket wurde zwischenzeitlich geändert");
            }
        }
        public static void Loeschen(Ticket t)
        {
            string sql = $"DELETE FROM ticket " +
                         $"WHERE id = {t.Id}";

            if (DBZugriff.ExecuteNonQuery(sql) == 0)
                throw new Exception($"Das Ticket mit der ID: {t.Id} konnte nicht gelöscht werden");
        }

        private static Ticket GetDataFromReader(MySqlDataReader rdr)
        {
            Ticket ticket = new Ticket();
            ticket.Id = rdr.GetInt32("id");
            ticket.Status = (TicketStatus)rdr.GetInt32("status");
            ticket.Kunde = DBKunde.GetKundeByID(rdr.GetInt32("kunde"));
            ticket.Beschreibung = rdr.GetString("beschreibung");
            ticket.Zeitpunkt = rdr.GetDateTime("zeitpunkt");
            ticket.Zeitstempel = rdr.GetDateTime("zeitstempel");
            return ticket;
        }
        public static Ticket GetTicketByID(int id)
        {
            using (MySqlConnection con = DBZugriff.OpenDB())
            {
                string sql = $"SELECT * FROM ticket WHERE id = {id}";
                using (MySqlDataReader rdr = DBZugriff.ExecuteReader(sql, con))
                {
                    if (rdr.Read())
                    {
                        Ticket ticket = GetDataFromReader(rdr);
                        return ticket;
                    }
                    else
                    {
                        throw new Exception($"Ticket mit ID: {id} existiert nicht");
                    }
                }
            }
        }
    }
}
