using _07_Ticketsystem_WPF.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _07_Ticketsystem_WPF.ViewModel
{
    public class MainViewModel : BaseModel
    {
        private ObservableCollection<Ticket> _lstTicket;
        public ObservableCollection<Ticket> LstTicket
        {
            get
            {
                return _lstTicket;
            }
            set
            {
                _lstTicket = value;
                OnPropertyChanged("LstTicket");
            }
        }

        private Ticket _selTicket;
        public Ticket SelTicket
        {
            get { return _selTicket; }
            set
            {
                this._selTicket = value;
                OnPropertyChanged("SelTicket");
            }
        }

        private ObservableCollection<Kunde> _lstKunde;
        public ObservableCollection<Kunde> LstKunde
        {
            get { return _lstKunde; }
            set
            {
                _lstKunde = value;
                OnPropertyChanged("LstKunde");
            }
        }

        // nachdem keine Veränderungen (add/remove) an der Liste stattfinden
        // kann eine "normale" List<...> ansteller einer Obs.Collection verwendet werden
        private List<TicketStatus> _lstStatus = new List<TicketStatus>();
        public List<TicketStatus> LstStatus
        {
            get { return _lstStatus; }
            set
            {
                _lstStatus = value;
                OnPropertyChanged("LstStatus");
            }
        }

        private List<Protokoll> _lstProtokoll = new List<Protokoll>();
        public List<Protokoll> LstProtokoll
        {
            get { return _lstProtokoll; }
            set { _lstProtokoll = value; }
        }


        public MainViewModel()
        {
            LstTicket = new ObservableCollection<Ticket>(Ticket.AlleLesen());
            LstKunde = new ObservableCollection<Kunde>(Kunde.AlleLesen());

            LstStatus.Add(TicketStatus.Neu);
            LstStatus.Add(TicketStatus.InBearbeitung);
            LstStatus.Add(TicketStatus.Geloest);

            // oder trickreich (Wedlich-Methode):
            //foreach (TicketStatus s in Enum.GetValues(typeof(TicketStatus)))
            //  this.LstStatus.Add(s);

        }
    }
}
