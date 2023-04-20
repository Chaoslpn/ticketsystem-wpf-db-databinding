using _07_Ticketsystem_WPF.Model;
using _07_Ticketsystem_WPF.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace Ticketsystem_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _model;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // nachdem mehrere Methoden Zugriff auf das MainViewModel benötigen
            // speichern wir uns gleich zu Beginn die Referenz
            _model = FindResource("mvmodel") as MainViewModel;
        }

        //private void FillListbox()
        //{
        //  lbTickets.Items.Clear();

        //  List<Ticket> lst = Ticket.AlleLesen();

        //  foreach (Ticket t in lst)
        //  {
        //    lbTickets.Items.Add(t);
        //  }
        //}

        private void btLoeschen_Click(object sender, RoutedEventArgs e)
        {
            Ticket t = lbTickets.SelectedItem as Ticket;
            if (t == null)
                return;

            MessageBoxResult res = MessageBox.Show("Wollen Sie das Ticket wirklich löschen?", "Ticketsystem WPF", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes)
            {
                _model.SelTicket.Loeschen();

                // entweder so ...        
                _model.LstTicket.Remove(_model.SelTicket);

                // oder so:
                //FillListbox();
            }
        }

        private void lbTickets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (lbTickets.SelectedItem != null)
            //{
            //  this.btBearbeiten.IsEnabled = true;
            //  this.btLoeschen.IsEnabled = true;
            //}
            //else
            //{
            //  this.btBearbeiten.IsEnabled = false;
            //  this.btLoeschen.IsEnabled = false;
            //}

            // Kurzform
            this.btBearbeiten.IsEnabled = lbTickets.SelectedItem != null;
            this.btLoeschen.IsEnabled = lbTickets.SelectedItem != null;
            this.btProtokoll.IsEnabled = lbTickets.SelectedItem != null;
        }

        private void btEnde_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btNeu_Click(object sender, RoutedEventArgs e)
        {
            this._model.SelTicket = new Ticket();
            TicketDetailDlg dlg = new TicketDetailDlg(DialogMode.Neu);

            // dlg.ShowDialog() öffnet den Dialog modal
            // (=Hauptfenster ist währenddessen nicht bedienbar)
            //
            // dlg.Show() würde den Dialog nicht-modal öffnen

            // Der Rückgabewert von ShowDialog ist identisch mit dem
            // im TicketDetailDlg gesetzten Wert für "DialogResult"
            bool? res = dlg.ShowDialog();

            if (res == true)
            {
                //FillListbox();
            }


            // Alternative:
            // this.lbTickets.Items.Add(t);
        }

        private void btBearbeiten_Click(object sender, RoutedEventArgs e)
        {
            if (_model.SelTicket == null)
                return;

            TicketDetailDlg dlg = new TicketDetailDlg(DialogMode.Bearbeiten);
            dlg.ShowDialog();
        }

        private void btProtokoll_Click(object sender, RoutedEventArgs e)
        {
            if (_model.SelTicket == null)
                return;

            ProtokollDlg dlg = new ProtokollDlg();
            dlg.ShowDialog();
        }
    }
}
