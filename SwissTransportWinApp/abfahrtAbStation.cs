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
    
    public partial class abfahrtAbStation : Form
    {
           public string station;
        public abfahrtAbStation()
        {
            InitializeComponent();
        }
        Transport transport = new Transport();
        private void stationBoardListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void abfahrtAbStation_Load(object sender, EventArgs e)
        {
            var verbindungen = transport.GetStationBoard(station, "");
            for (int i = 0; i < 5; i++)
            {
                string zeitVerbindung = verbindungen.Entries[i].Stop.Departure.TimeOfDay + "";
                stationTimeBoardListBox.Items.Add(zeitVerbindung);

                string nummerVerbindung = verbindungen.Entries[i].Category + " " + verbindungen.Entries[i].Number;
                nummerListBox.Items.Add(nummerVerbindung);

                string richtungVerbindung = verbindungen.Entries[i].To;
                richtungListBox.Items.Add(richtungVerbindung);
            }
        }

        private void zeitLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
