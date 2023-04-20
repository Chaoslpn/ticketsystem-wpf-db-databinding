using _07_Ticketsystem_WPF.Persistenz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ticketsystem_WPF.Model
{
    public class Kunde : Person // Klasse Kunde wird von Person abgeleitet (=vererbt)
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }

        }

        public void Anlegen()
        {
            // Wegen der Schichtentrennung wird der Aufruf hier durchgereicht
            // Übergang von einer nicht statischen auf eine statische Methode
            DBKunde.Anlegen(this);
        }

        public static List<Kunde> AlleLesen()
        {
            // Wegen der Schichtentrennung wird der Aufruf hier nur durchgereicht
            return DBKunde.AlleLesen();
        }

        public override string ToString()
        {
            //return $"{Id} {Geschlecht} {Vorname} {Nachname} {GebDatum.ToShortDateString()} {Alter} Jahre";
            // return $"{Id} " + base.ToString();
            return $"{Vorname} {Nachname}";
        }

        public override bool Equals(object obj)
        {
            Kunde k = obj as Kunde;

            return k != null && k.Id == Id;
        }


        public static Kunde GetKundeById(int suchId)
        {
            return DBKunde.GetKundeByID(suchId);
        }
    }
}
