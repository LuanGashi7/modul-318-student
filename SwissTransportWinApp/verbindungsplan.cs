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
    public partial class verbindungsplan : Form
    {
        public string startStation;
        public string endStation;
        public string datum;
        public string uhrzeit;
       
        public verbindungsplan()
        {
            InitializeComponent();
        }
        Transport transport = new Transport();
        /*
        * Zeigt den Verbindungsplan mit den Infos wie Zeitspanne, Bus/Zug Nummer und Dauer an.
        */
        private void verbindungsplan_Load(object sender, EventArgs e)
        {
            Connections connections;
            StationBoardRoot verbindungen;

            try
            {
                connections = transport.GetConnections(startStation, endStation, datum, uhrzeit);
                verbindungen = transport.GetStationBoard(startStation, "");

                for (int i = 0; i < connections.ConnectionList.Count; i++)
                {
                    string zeitspanne = connections.ConnectionList[i].From.Departure.Remove(0, 11).Remove(5, 8) + " -> " + connections.ConnectionList[i].To.Arrival.Remove(0, 11).Remove(5, 8);
                    zeitspannenListBox.Items.Add(zeitspanne);

                    string nummerVerbindung = verbindungen.Entries[1].Category + " " + verbindungen.Entries[i].Number;
                    nummerListBox.Items.Add(nummerVerbindung);

                    string connection = connections.ConnectionList[i].Duration.Remove(0, 3).Remove(5, 3) + " min";
                    dauerListBox.Items.Add(connection);
                }
            }
            catch
            {
                MessageBox.Show("Ihre Eingaben sind ungültig.");
            } 
        }
    }
}
