using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using GoogleApisLib.Models.MapsDistanceMatrix;
using MapsDistanceMatrix.Buzzi;

namespace MapsDistanceMatrix.Models
{
    public class Trip : INotifyPropertyChanged
    {
        public Trip(BuzziFormatAddress origin, BuzziFormatAddress destination, double distance = -1)
        {
            Origin = origin;
            Destination = destination;
            Distance = distance;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public BuzziFormatAddress Origin { get; set; }

        public BuzziFormatAddress Destination { get; set; }

        private double _distance;
        public double Distance
        {
            get => _distance;
            set
            {
                _distance = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Distance)));
            }
        }
        
        public static async Task GetTripDistances(List<Trip> trips)
        {
            List<BuzziFormatAddress> origins = (from Trip t in trips select t.Origin).Distinct().ToList();
            foreach (BuzziFormatAddress origin in origins)
            {
                List<BuzziFormatAddress> destinations = (from Trip t in trips where t.Origin.Equals(origin) select t.Destination).ToList();
                List<Trip> originTrips = (from Trip t in trips where t.Origin.Equals(origin) select t).ToList();
                if (originTrips.Count == 0) { continue; }

                int originTripsIndex = 0;
                while (destinations.Count > 0)
                {
                    List<BuzziFormatAddress> destinationsSubset = destinations.Take(Properties.Settings.Default.ApiMaxElementsPerRequest).ToList();
                    foreach (BuzziFormatAddress b in destinationsSubset)
                    {
                        destinations.Remove(b);
                    }
                    ApiRequest request = new ApiRequest(Properties.Settings.Default.ApiKey, Properties.Settings.Default.ApiJsonEndpoint)
                    {
                        Origins = new List<string> { origin.ApiRequestFormat },
                        Destinations = (from BuzziFormatAddress b in destinationsSubset select b.ApiRequestFormat).ToList(),
                        Language = Language.English,
                        Mode = Mode.Driving,
                        Units = Units.Imperial
                    };
                    ApiResponse response = await request.GetDistanceMatrixAsync();
                    if (response.Rows.Length == 0 || response.Rows[0].Elements.Length == 0) { continue; }

                    for (int elementIndex = 0; elementIndex < response.Rows[0].Elements.Length; elementIndex++, originTripsIndex++)
                    {
                        Distance d = response.Rows[0].Elements[elementIndex].Distance;
                        if (d == null) { continue; }
                        originTrips[originTripsIndex].Distance = Math.Round(d.Value / 1609.34, 2);
                    }
                }
            }
        }
    }
}
