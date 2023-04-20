using System;

namespace _07_Ticketsystem_WPF.Model
{
    public enum Gender { weiblich, männlich }

    public class Person
    {
        private string _nachname;

        public string Nachname
        {
            get { return _nachname; }

            set
            {
                if (value.Trim() == "")
                    throw new Exception("Nachname war leer");

                _nachname = value;
            }
        }


        private string _vorname;

        public string Vorname
        {
            // wird aufgerufen bei Zuweisung z.B.
            // Vorname = "Fritz";
            set // set-Accessor
            {
                if (string.IsNullOrWhiteSpace(value)) //   value.Trim() == "")
                    throw new Exception("Vorname war leer");

                this._vorname = value; // value ist ein vordef. Schlüsselwort
            }

            get // get-Accessor
            {
                return this._vorname;
            }
        }

        private DateTime _gebDatum;
        public DateTime GebDatum
        {
            get
            {
                return this._gebDatum;
            }

            set
            {
                this._gebDatum = value;
            }
        }

        // Absolute Kurzform 
        // bis auf weiteres bei Prüfungen NICHT erlaubt!
        // public DateTime GebDatum2 { get; set; }

        private Gender _geschlecht;

        public Gender Geschlecht
        {
            get
            {
                return this._geschlecht;
            }

            set
            {
                this._geschlecht = value;
            }
        }


        // readonly property (kein set-Accessor, keine private Instanzvariable)
        public int Alter
        {
            get
            {
                return BerechneAlter();
            }
        }

        public Person()
        {
        }

        public Person(string nn, string vn, Gender g, DateTime gebdat)
        {
            // Im Konstruktor werden i.d.R. die Properties verwendet
            // (damit die Fehlerprüfung ausgeführt wird)
            Vorname = vn;
            Nachname = nn;
            GebDatum = gebdat;
            Geschlecht = g;
        }

        public override string ToString()
        {
            string anrede = "Herr";
            if (Geschlecht == Gender.weiblich)
                anrede = "Frau";

            return $"{anrede} {Vorname} {Nachname} {GebDatum.ToShortDateString()} {BerechneAlter()} Jahre  ";
        }

        private int BerechneAlter()
        {
            DateTime heute = DateTime.Today;
            int alter = heute.Year - GebDatum.Year;

            if (heute.Month < GebDatum.Month ||
                heute.Month == GebDatum.Month && heute.Day < GebDatum.Day)
                alter--;

            // Variante: Berechung des Geburtstags im laufenden Jahr
            //if (this.GebDatum.AddYears(alter) > heute)
            //  alter--;

            return alter;
        }


    }
}
