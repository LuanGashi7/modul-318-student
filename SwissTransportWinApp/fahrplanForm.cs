using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;


namespace SwissTransportWinApp
{
    public partial class fahrplanForm : Form
    {
     
        private SwissTransport.ITransport trans;
        public fahrplanForm()
        {
            InitializeComponent();
        }
         Transport transport = new Transport();
        /*
         * leitet mit einer überprüfung zum Verbindungsplan Form weiter
         */
        private void suchtVerbindungBttn_Click(object sender, EventArgs e)
        {
                verbindungsplan meinVerbindungsplan = new verbindungsplan();
            if (vonTextBox.Text == String.Empty || nachTextBox.Text == String.Empty || uhrzeitBox.Text == String.Empty)
            {
                MessageBox.Show("Bitte füllen sie alle Felder korrekt aus.");
            }
            else
            {
                meinVerbindungsplan.startStation = vonTextBox.Text;
                meinVerbindungsplan.endStation = nachTextBox.Text;
                meinVerbindungsplan.datum = datumBox.Text;
                meinVerbindungsplan.uhrzeit = uhrzeitBox.Text;
                meinVerbindungsplan.Show();
            }
        }
        /*
         * Erstellt eine Liste mit ähnlichen Stationen wie die eingegebene Abfahrtsstationen
        */
        private void vonTextBox_TextChanged(object sender, EventArgs e)
        {
            var stations = transport.GetStations(vonTextBox.Text).StationList;

            vonStationlistBox.Items.Clear();

            for (int i = 0; i < stations.Count - 1; i++)
            {
                try
                {
                    vonStationlistBox.Items.Add(stations[i].Name);
                }
                catch
                {
                    MessageBox.Show("Geben sie ein gültigen Abfahrtsort an.");
                }
                }
        }
        /*
        * Erstellt eine Liste mit ähnlichen Stationen wie die eingegebene Zielstationen
        */
        private void nachTextBox_TextChanged(object sender, EventArgs e)
        {
            var stations = transport.GetStations(nachTextBox.Text).StationList;

            nachStationlistBox.Items.Clear();

            for (int i = 0; i < stations.Count - 1; i++)
            {
                try
                {
                    nachStationlistBox.Items.Add(stations[i].Name);
                }
                catch
                {
                    MessageBox.Show("Geben sie ein gültigen Zielort an.");
                }
            }
        }
        /*
        * leitet mit einer überprüfung zum abfahrtAbStation Form weiter.
        */
        private void verbindungAnzBttn_Click(object sender, EventArgs e)
        {

            if (stationTextBox.Text == string.Empty)
            {
                MessageBox.Show("Bitte füllen sie alle Felder korrekt aus.");
            }
            else {
                abfahrtAbStation meineAbfahrtAbStation = new abfahrtAbStation();
                meineAbfahrtAbStation.station = stationTextBox.Text;
                meineAbfahrtAbStation.Show();
            } 
        }
        /*
        * Erstellt eine Liste ähnlichen Stationen wie die eingegebene Station
        */
        private void stationTextBox_TextChanged(object sender, EventArgs e)
        {
            var stations = transport.GetStations(stationTextBox.Text).StationList;

            stationListBox.Items.Clear();

            for (int i = 0; i < stations.Count - 1; i++)
            {
                try
                {
                    stationListBox.Items.Add(stations[i].Name);
                }
                catch {
                    MessageBox.Show("Geben sie eine gültige Station ein");
                }
            }
        }

        private void vonStationlistBox_DoubleClick(object sender, EventArgs e)
        {
            vonTextBox.Text = Convert.ToString(vonStationlistBox.SelectedItem);
            vonStationlistBox.Items.Clear();
        }

        private void nachStationlistBox_DoubleClick(object sender, EventArgs e)
        {
            nachTextBox.Text = Convert.ToString(nachStationlistBox.SelectedItem);
            nachStationlistBox.Items.Clear();
        }

        private void stationListBox_DoubleClick(object sender, EventArgs e)
        {
            stationTextBox.Text = Convert.ToString(stationListBox.SelectedItem);
            stationListBox.Items.Clear();
        }
    }
}