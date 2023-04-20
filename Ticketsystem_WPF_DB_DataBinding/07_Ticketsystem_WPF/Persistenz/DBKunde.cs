using _07_Ticketsystem_WPF.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ticketsystem_WPF.Persistenz
{
    // Eine statische Klasse darf nur statische Methoden enthalten
    public static class DBKunde
    {
        public static List<Kunde> AlleLesen()
        {
            List<Kunde> lstkunde = new List<Kunde>();

            using (MySqlConnection con = DBZugriff.OpenDB())
            {
                string sql = "SELECT * FROM kunde";
                using (MySqlDataReader rdr = DBZugriff.ExecuteReader(sql, con))
                {
                    while (rdr.Read())
                    {
                        Kunde kunde = GetDataFromReader(rdr);
                        lstkunde.Add(kunde);
                    }
                }
            }

            return lstkunde;
        }
        public static void Anlegen(Kunde k)
        {
            using (MySqlConnection con = DBZugriff.OpenDB())
            {
                string sql = $"INSERT INTO kunde (vorname, nachname, geschlecht, geburtsdatum)" +
                             $"VALUES ('{k.Vorname}', '{k.Nachname}', {(int)k.Geschlecht}, '{k.GebDatum.ToString("yyyy-MM-dd")}')";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                k.Id = DBZugriff.GetLastInsertId(con);
            }
        }

        private static Kunde GetDataFromReader(MySqlDataReader rdr)
        {
            Kunde kunde = new Kunde();
            kunde.Id = rdr.GetInt32("id");
            kunde.Nachname = rdr.GetString("nachname");
            kunde.Vorname = rdr.GetString("vorname");
            kunde.Geschlecht = (Gender)rdr.GetInt32("geschlecht");
            kunde.GebDatum = rdr.GetDateTime("geburtsdatum");
            return kunde;
        }
        public static Kunde GetKundeByID(int id)
        {
            using (MySqlConnection con = DBZugriff.OpenDB())
            {
                string sql = $"SELECT * FROM kunde WHERE id = {id}";
                using (MySqlDataReader rdr = DBZugriff.ExecuteReader(sql, con))
                {
                    if (rdr.Read())
                    {
                        Kunde kunde = GetDataFromReader(rdr);
                        return kunde;
                    }
                    else
                    {
                        throw new Exception($"Kunde mit ID: {id} existiert nicht");
                    }
                }
            }
        }
    }
}
