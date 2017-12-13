using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using MapsDistanceMatrix.Buzzi;
using MapsDistanceMatrix.Models;

namespace MapsDistanceMatrix.Forms
{
    public partial class ShippingDataDemoForm : Form
    {
        public ShippingDataDemoForm()
        {
            InitializeComponent();
            RandomizeTrips();
        }

        public List<Trip> Trips { get; set; }
        private void RandomizeTrips()
        {
            List<BuzziFormatAddress> origins = BuzziFormatAddress.GetRandomAddresses(2);
            List<BuzziFormatAddress> destinations = (from BuzziFormatAddress b in BuzziFormatAddress.GetRandomAddresses(5) where !(from BuzziFormatAddress c in origins where c.Equals(b) select c).Any() select b).ToList();
            Trips =
            (
                from BuzziFormatAddress o in origins
                from BuzziFormatAddress d in destinations
                select new Trip(o, d)
            ).ToList();
            TripsDataGrid.DataSource = new BindingList<Trip>(Trips);
        }

        private async void ProcessButton_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await Trip.GetTripDistances(Trips);
            MessageBox.Show("Trips Processed: " + Trips.Count + Environment.NewLine + "Elapsed Time: " + stopwatch.ElapsedMilliseconds / 1000.0 + " seconds");
        }
    }
}
