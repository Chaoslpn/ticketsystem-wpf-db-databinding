using _07_Ticketsystem_WPF.Exceptions;
using _07_Ticketsystem_WPF.Model;
using _07_Ticketsystem_WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ticketsystem_WPF
{
    public enum DialogMode { Neu, Bearbeiten }

  /// <summary>
  /// Interaktionslogik für TicketDetailDlg.xaml
  /// </summary>
  public partial class TicketDetailDlg : Window
  {
    //private Ticket _ticket;
    private DialogMode _mode;
    public TicketDetailDlg(DialogMode m)
    {
      InitializeComponent();
      
      _mode = m;
    
      if (m == DialogMode.Neu)
      {
        this.Title = "Neues Ticket anlegen";
        this.cbStatus.IsEnabled = false;
      }
      else
      {
        this.Title = "Ticket bearbeiten";
        this.cbKunde.IsEnabled = false;
        this.btKundeHinzufuegen.IsEnabled = false;        
      }
    }

  
    private void btOK_Click(object sender, RoutedEventArgs e)
    {
      MainViewModel model = FindResource("mvmodel") as MainViewModel;

      //if (tbBeschreibung.Text.Trim() == String.Empty)
      if (String.IsNullOrWhiteSpace(model.SelTicket.Beschreibung))
      {
        MessageBox.Show("Die Fehlerbeschreibung darf nicht leer sein!");
        return;
      }

      if (model.SelTicket.Kunde == null)
      {
        MessageBox.Show("Bitte wählen Sie einen Kunden aus!");
        return;
      }
      
      if (this._mode == DialogMode.Neu)
        model.SelTicket.Anlegen();
      else
      {
        try
        {
           model.SelTicket.Aendern();
        }
        catch (MultiUserAccessException ex1)
        {
          MessageBoxResult r = MessageBox.Show("Das Ticket wurde zwischenzeitlich geändert.\n\nNeu laden?", "Ticketsystem", MessageBoxButton.YesNo, MessageBoxImage.Question);

          if (r == MessageBoxResult.Yes)
          {
            model.SelTicket = Ticket.GetTicketById(model.SelTicket.Id);            
            return;
          }
        }
        catch (Exception ex2)
        {
          MessageBox.Show($"Fehler beim Speichern\n\n{ex2.Message}", "Ticketsystem", MessageBoxButton.OK, MessageBoxImage.Error);
        }
      }


      this.DialogResult = true;
      //this.Close();
    }

    private void btAbbrechen_Click(object sender, RoutedEventArgs e)
    {
      this.DialogResult = false;
      this.Close();
    }

    private void btKundeHinzufuegen_Click(object sender, RoutedEventArgs e)
    {
      Kunde k = new Kunde();
      KundeDetailDlg dlg = new KundeDetailDlg(k);
      bool? res = dlg.ShowDialog();
      if (res == true)
      {
        // Combobox komplett neu füllen
        // oder:
        this.cbKunde.Items.Add(k);        
        this.cbKunde.SelectedItem = k;
        
        // evtl. auch möglich:
        // this.cbKunde.SelectedIndex = this.cbKunde.Items.Count - 1;
      }
    }
  }
}
