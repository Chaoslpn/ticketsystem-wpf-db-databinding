using _07_Ticketsystem_WPF.Model;
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
    /// <summary>
    /// Interaktionslogik für KundeDetailDlg.xaml
    /// </summary>
    public partial class KundeDetailDlg : Window
  {
    private Kunde _kunde;

    public KundeDetailDlg(Kunde k)
    {
      InitializeComponent();

      this._kunde = k;

      this.cbGeschlecht.Items.Add(Gender.männlich);
      this.cbGeschlecht.Items.Add(Gender.weiblich);

      this.dpGebDat.DisplayDateEnd = DateTime.Today.AddYears(-16);
      this.dpGebDat.DisplayDateStart = DateTime.Today.AddYears(-65);
    }

    private bool pruefen()
    {
      if (this.tbVorname.Text.Trim() == String.Empty)
      {
        MessageBox.Show("Der Vorname darf nicht leer sein", "Ticketsystem", MessageBoxButton.OK, MessageBoxImage.Error);
        return false;
      }

      if (this.tbNachname.Text.Trim() == String.Empty)
      {
        MessageBox.Show("Der Nachname darf nicht leer sein", "Ticketsystem", MessageBoxButton.OK, MessageBoxImage.Error);
        return false;
      }

      if (this.cbGeschlecht.SelectedItem == null)
      {
        MessageBox.Show("Bitte wählen das Geschlecht aus!", "Ticketsystem", MessageBoxButton.OK, MessageBoxImage.Error);
        return false;
      }
      DateTime test = dpGebDat.DisplayDate;

      // Für Geb. Datum in Datepicker
      if (dpGebDat.SelectedDate == null)
      {
        MessageBox.Show("Bitte Geburtsdatum auswählen!", "Ticketsystem", MessageBoxButton.OK, MessageBoxImage.Error);
        return false;
      }
      else if (dpGebDat.SelectedDate.Value.AddYears(16) > DateTime.Today)
      {
        MessageBox.Show("Das Mindestalter beträgt 16 Jahre", "Ticketsystem", MessageBoxButton.OK, MessageBoxImage.Error);
        return false;
      }

      // Für Geb. Datum in Textbox
      //try
      //{
      //  DateTime dt = Convert.ToDateTime(this.tbGebDatum.Text);

      //  if (dt.AddYears(16) > DateTime.Today)
      //  {
      //    MessageBox.Show("Das Mindestalter beträgt 16 Jahre", "Ticketsystem", MessageBoxButton.OK, MessageBoxImage.Error);
      //    return false;
      //  }

      //}
      //catch (Exception)
      //{
      //  MessageBox.Show("Bitte korrektes Datum eingeben!", "Ticketsystem", MessageBoxButton.OK, MessageBoxImage.Error);
      //  return false;
      //}

      return true;
    }

    private void btOK_Click(object sender, RoutedEventArgs e)
    {
      if (pruefen())
      {
        this._kunde.Vorname = this.tbVorname.Text;
        this._kunde.Nachname = this.tbNachname.Text;
        this._kunde.Geschlecht = (Gender)this.cbGeschlecht.SelectedItem;

        // Für DatePicker
        this._kunde.GebDatum = this.dpGebDat.SelectedDate.Value;
        
        // Für Textbox
        // this._kunde.GebDatum = Convert.ToDateTime(this.tbGebDatum.Text);

        this._kunde.Anlegen();
        
        this.DialogResult = true;
        this.Close();
      }

    }

    private void btAbbrechen_Click(object sender, RoutedEventArgs e)
    {
      this.DialogResult=false;
      this.Close();
    }
  }
}
