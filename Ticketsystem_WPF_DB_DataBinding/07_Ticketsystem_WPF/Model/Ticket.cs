using _07_Ticketsystem_WPF.Persistenz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ticketsystem_WPF.Model
{
    public enum TicketStatus { Neu, InBearbeitung, Geloest };
    public class Ticket
    {

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private TicketStatus _status;

        public TicketStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private Kunde _kunde;

        public Kunde Kunde
        {
            get { return _kunde; }
            set { _kunde = value; }
        }

        private string _beschreibung;

        public string Beschreibung
        {
            get { return _beschreibung; }
            set { _beschreibung = value; }
        }

        private DateTime _zeitpunkt;

        public DateTime Zeitpunkt
        {
            get { return _zeitpunkt; }
            set { _zeitpunkt = value; }
        }

        // Zeitpunkt der letzten Änderung
        public DateTime Zeitstempel { get; set; }

        //public Ticket(int id, TicketStatus status, Kunde kunde, string beschreibung, DateTime zeitpunkt)
        //{
        //  Id = id;
        //  Status = status;
        //  Kunde = kunde;
        //  Beschreibung = beschreibung;
        //  Zeitpunkt = zeitpunkt;
        //}

        public Ticket()
        {
            // default für ein neues Ticket
            Zeitpunkt = DateTime.Now;
            Status = TicketStatus.Neu;
            Kunde = null;
        }

        // Anmerkung: könnte ggf auch in die Persistenzschicht verlagert werden
        public void Speichern()
        {
            if (Id < 1)
                Anlegen();
            else
                Aendern(); // alle Tickets mit Id > 0 sind bereits in der Datei
        }

        public void Aendern()
        {
            DBTicket.Aendern(this);
        }

        public void Anlegen()
        {
            DBTicket.Anlegen(this);
        }

        public void Loeschen()
        {
            DBTicket.Loeschen(this);
        }

        public static List<Ticket> AlleLesen()
        {
            return DBTicket.AlleLesen();
        }

        public static Ticket GetTicketById(int suchId)
        {
            return DBTicket.GetTicketByID(suchId);
        }

        public override string ToString()
        {
            //return $"{this.Id.ToString().PadLeft(3)}  {this.Zeitpunkt.ToShortDateString()} {this.Status.ToString().PadRight(13)} {this.Kunde.Nachname.PadRight(20)} {this.Beschreibung} ";
            return $"{Id,3}  {Zeitpunkt.ToShortDateString()} {Status,-13} {Kunde.Nachname,-20} {Beschreibung} ";
        }

        // Die vom Visual Studio generierte Equals-Methode:
        //public override bool Equals(object obj)
        //{
        //  return obj is Ticket ticket && Id == ticket.Id;
        //}

        public override bool Equals(object obj)
        {
            // Cast Variante 1: wirft Exception, falls obj nicht auf Ticket-Objekt zeigt
            // Ticket t = (Ticket)obj;

            // Cast Variante 2: setzt t auf null, falls obj nicht auf Ticket-Objekt zeigt
            Ticket t = obj as Ticket;

            if (t == null)
                return false;

            // wir legen hier fest, dass zwei Ticket Objekte dann "logisch gleich" sind,
            // wenn deren Id übereinstimmt
            if (Id == t.Id)
                return true;
            else
                return false;

            // Kurzschreibweise:
            // return t != null && t.Id == this.Id;
        }
    }
}
