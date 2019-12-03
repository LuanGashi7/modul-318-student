﻿using System;
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
            verbindungsplan meinVerbindungsplan = new verbindungsplan();
            meinVerbindungsplan.startStation = vonTextBox.Text;
            meinVerbindungsplan.endStation = nachTextBox.Text;
            meinVerbindungsplan.datum = datumBox.Text;
            meinVerbindungsplan.uhrzeit = uhrzeitBox.Text;
            meinVerbindungsplan.Show();

        }

        private void vonTextBox_TextChanged(object sender, EventArgs e)
        {
            var stations = transport.GetStations(vonTextBox.Text).StationList;

            vonStationlistBox.Items.Clear();

            for (int i = 0; i < stations.Count - 1; i++)
            {
                vonStationlistBox.Items.Add(stations[i].Name);

            }
        }

        private void nachTextBox_TextChanged(object sender, EventArgs e)
        {
            var stations = transport.GetStations(nachTextBox.Text).StationList;

            nachStationlistBox.Items.Clear();

            for (int i = 0; i < stations.Count - 1; i++)
            {
                nachStationlistBox.Items.Add(stations[i].Name);

            }
        }

        private void verbindungAnzBttn_Click(object sender, EventArgs e)
        {
            
            abfahrtAbStation meineAbfahrtAbStation = new abfahrtAbStation();
            meineAbfahrtAbStation.station = stationTextBox.Text;
            meineAbfahrtAbStation.Show();
        }

        private void stationTextBox_TextChanged(object sender, EventArgs e)
        {
            var stations = transport.GetStations(stationTextBox.Text).StationList;

            stationListBox.Items.Clear();

            for (int i = 0; i < stations.Count - 1; i++)
            {
                stationListBox.Items.Add(stations[i].Name);

            }
        }

        private void vonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vonStationlistBox_DoubleClick(object sender, EventArgs e)
        {
            vonTextBox.Text = Convert.ToString(vonStationlistBox.SelectedItem);
            vonStationlistBox.Items.Clear();
        }

        private void vonStationlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void nachStationlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}