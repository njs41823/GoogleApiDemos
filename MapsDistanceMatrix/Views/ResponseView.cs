using System.Collections.Generic;
using System.Windows.Forms;
using GoogleApisLib.Models.MapsDistanceMatrix;
using MapsDistanceMatrix.ComponentModel;

namespace MapsDistanceMatrix.Views
{
    public partial class ResponseView : Form
    {
        public ResponseView(ApiResponse apiResponse)
        {
            InitializeComponent();
            List<object> allElements = new List<object>();
            for (int rowIndex = 0; rowIndex < apiResponse.Rows.Length; rowIndex++)
            {
                for (int elementIndex = 0; elementIndex < apiResponse.Rows[rowIndex].Elements.Length; elementIndex++)
                {
                    Element e = apiResponse.Rows[rowIndex].Elements[elementIndex];
                    allElements.Add(
                        new
                        {
                            Origin = apiResponse.OriginAddresses[rowIndex],
                            Destination = apiResponse.DestinationAddresses[elementIndex],
                            Distance = e.Distance?.Text,
                            Duration = e.Duration?.Text,
                            Fare = e.Fare?.Text,
                            e.Status
                        });
                }
            }
            ResponseDataGrid.AutoGenerateColumns = false;
            ResponseDataGrid.DataSource = new SortableBindingList<object>(allElements);
        }
    }
}
