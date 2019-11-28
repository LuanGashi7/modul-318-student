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
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void suchtVerbindungBttn_Click(object sender, EventArgs e)
        {

       


            trans = new SwissTransport.Transport();
            var connections = trans.GetConnections(vonTextBox.Text, nachTextBox.Text);

            listBox1.Items.Clear();
            for (int i = 0; i < 4; i++)
            {
                string msg = "Sursee" + " (" + connections.ConnectionList[i].From.Departure.Remove(0, 11).Remove(5, 8) + ") -> " + "Luzern" + " (" + connections.ConnectionList[i].To.Arrival.Remove(0, 11).Remove(5, 8) + ") \t Dauer: " + connections.ConnectionList[i].Duration.Remove(0, 3).Remove(5, 3);
                  listBox1.Items.Add(msg);
            }

        }

        private void vonTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nachTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void verbindungAnzBttn_Click(object sender, EventArgs e)
        {
            abfahrtAbStation abs = new abfahrtAbStation();
            abs.Show();
            //transport.GetStationBoard(stationTextBox.Text,"");
        
        }

        private void stationTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
