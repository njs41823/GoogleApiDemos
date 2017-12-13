using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GoogleApisLib.Models.MapsDistanceMatrix;
using MapsDistanceMatrix.Buzzi;
using MapsDistanceMatrix.ComponentModel;
using MapsDistanceMatrix.Views;

namespace MapsDistanceMatrix.Forms
{
    public partial class ApiDemoForm : Form
    {
        public ApiDemoForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public SortableBindingList<AddressString> OriginAddressStrings { get; } = new SortableBindingList<AddressString>(new List<AddressString>());
        public SortableBindingList<AddressString> DestinationAddressStrings { get; } = new SortableBindingList<AddressString>(new List<AddressString>());

        private void InitializeForm()
        {
            OriginAddressesDataGrid.DataSource = OriginAddressStrings;
            DestinationAddressesDataGrid.DataSource = DestinationAddressStrings;

            UnitsComboBox.DataSource = 
                (
                    from Units u 
                    in Enum.GetValues(typeof(Units)).Cast<Units>()
                    orderby u == Units.NotSpecified ? string.Empty : DisplayStringDictionaries.UnitsDisplayStrings[u]
                    select new { ValueMember = u, DisplayMember = DisplayStringDictionaries.UnitsDisplayStrings[u] }
                ).ToList();
            UnitsComboBox.ValueMember = "ValueMember";
            UnitsComboBox.DisplayMember = "DisplayMember";

            ModeComboBox.DataSource =
                (
                    from Mode m 
                    in Enum.GetValues(typeof(Mode)).Cast<Mode>()
                    orderby m == Mode.NotSpecified ? string.Empty : DisplayStringDictionaries.ModeDisplayStrings[m]
                    select new { ValueMember = m, DisplayMember = DisplayStringDictionaries.ModeDisplayStrings[m] }
                ).ToList();
            ModeComboBox.ValueMember = "ValueMember";
            ModeComboBox.DisplayMember = "DisplayMember";

            LanguageComboBox.DataSource = 
                (
                    from Language l 
                    in Enum.GetValues(typeof(Language)).Cast<Language>()
                    orderby l == Language.NotSpecified ? string.Empty : DisplayStringDictionaries.LanguageDisplayStrings[l]
                    select new { ValueMember = l, DisplayMember = DisplayStringDictionaries.LanguageDisplayStrings[l] }
                ).ToList();
            LanguageComboBox.ValueMember = "ValueMember";
            LanguageComboBox.DisplayMember = "DisplayMember";

            AvoidComboBox.DataSource = 
                (
                    from Avoid a 
                    in Enum.GetValues(typeof(Avoid)).Cast<Avoid>()
                    orderby a == Avoid.NotSpecified ? string.Empty : DisplayStringDictionaries.AvoidDisplayStrings[a]
                    select new { ValueMember = a, DisplayMember = DisplayStringDictionaries.AvoidDisplayStrings[a] }
                ).ToList();
            AvoidComboBox.ValueMember = "ValueMember";
            AvoidComboBox.DisplayMember = "DisplayMember";

            TrafficModelComboBox.DataSource = 
                (
                    from TrafficModel t 
                    in Enum.GetValues(typeof(TrafficModel)).Cast<TrafficModel>()
                    orderby t == TrafficModel.NotSpecified ? string.Empty : DisplayStringDictionaries.TrafficModelDisplayStrings[t]
                    select new { ValueMember = t, DisplayMember = DisplayStringDictionaries.TrafficModelDisplayStrings[t] }
                ).ToList();
            TrafficModelComboBox.ValueMember = "ValueMember";
            TrafficModelComboBox.DisplayMember = "DisplayMember";

            TransitModeComboBox.DataSource = 
                (
                    from TransitMode t 
                    in Enum.GetValues(typeof(TransitMode)).Cast<TransitMode>()
                    orderby t == TransitMode.NotSpecified ? string.Empty : DisplayStringDictionaries.TransitModeDisplayStrings[t]
                    select new { ValueMember = t, DisplayMember = DisplayStringDictionaries.TransitModeDisplayStrings[t] }
                ).ToList();
            TransitModeComboBox.ValueMember = "ValueMember";
            TransitModeComboBox.DisplayMember = "DisplayMember";

            TransitRoutingPreferenceComboBox.DataSource = 
                (
                from TransitRoutingPreference t 
                in Enum.GetValues(typeof(TransitRoutingPreference)).Cast<TransitRoutingPreference>()
                orderby t == TransitRoutingPreference.NotSpecified ? string.Empty : DisplayStringDictionaries.TransitRoutingPreferenceDisplayStrings[t]
                select new { ValueMember = t, DisplayMember = DisplayStringDictionaries.TransitRoutingPreferenceDisplayStrings[t] }
                ).ToList();
            TransitRoutingPreferenceComboBox.ValueMember = "ValueMember";
            TransitRoutingPreferenceComboBox.DisplayMember = "DisplayMember";

            foreach (Control c in SpecifyTimesGroupBox.Controls)
            {
                c.DataBindings.Clear();
                c.DataBindings.Add("Enabled", SpecifyTimesCheckBox, nameof(SpecifyTimesCheckBox.Checked));
            }
        }

        private void OriginAddressAddButton_Click(object sender, EventArgs e)
        {
            BuzziFormatAddress originAddress = 
                new BuzziFormatAddress(
                    OriginAddressLine1TextBox.Text,
                    OriginAddressLine2TextBox.Text,
                    string.Empty, string.Empty,
                    OriginAddressCityTextBox.Text,
                    OriginAddressStateComboBox.Text,
                    OriginAddressPostalCodeTextBox.Text,
                    OriginAddressCountryComboBox.Text);
            OriginAddressStrings.Add(new AddressString(originAddress.ApiRequestFormat));
            OriginAddressLine1TextBox.Clear();
            OriginAddressLine2TextBox.Clear();
            OriginAddressCityTextBox.Clear();
            OriginAddressStateComboBox.SelectedIndex = 0;
            OriginAddressPostalCodeTextBox.Clear();
            OriginAddressCountryComboBox.SelectedIndex = 0;
        }

        private void DestinationAddressAddButton_Click(object sender, EventArgs e)
        {
            BuzziFormatAddress destinationAddress =
                new BuzziFormatAddress(
                    DestinationAddressLine1TextBox.Text,
                    DestinationAddressLine2TextBox.Text,
                    string.Empty, string.Empty,
                    DestinationAddressCityTextBox.Text,
                    DestinationAddressStateComboBox.Text,
                    DestinationAddressPostalCodeTextBox.Text,
                    DestinationAddressCountryComboBox.Text);
            DestinationAddressStrings.Add(new AddressString(destinationAddress.ApiRequestFormat));
            DestinationAddressLine1TextBox.Clear();
            DestinationAddressLine2TextBox.Clear();
            DestinationAddressCityTextBox.Clear();
            DestinationAddressStateComboBox.SelectedIndex = 0;
            DestinationAddressPostalCodeTextBox.Clear();
            DestinationAddressCountryComboBox.SelectedIndex = 0;
        }

        private async void GetDistanceMatrixButton_Click(object sender, EventArgs e)
        {
            DateTime departureTime = DepartureDatePicker.Value.Date + DepartureTimePicker.Value.TimeOfDay;
            DateTime arrivalTime = ArrivalDatePicker.Value.Date + ArrivalTimePicker.Value.TimeOfDay;

            ApiRequest request = new ApiRequest(Properties.Settings.Default.ApiKey, Properties.Settings.Default.ApiJsonEndpoint)
            {
                Origins = (from AddressString s in OriginAddressStrings select s.Address).ToList(),
                Destinations = (from AddressString s in DestinationAddressStrings select s.Address).ToList(),
                Units = (Units) UnitsComboBox.SelectedValue,
                Mode = (Mode) ModeComboBox.SelectedValue,
                Language = (Language) LanguageComboBox.SelectedValue,
                Avoid = (Avoid) AvoidComboBox.SelectedValue, 
                TrafficModel = (TrafficModel) TrafficModelComboBox.SelectedValue, 
                TransitMode = (TransitMode) TransitModeComboBox.SelectedValue,
                TransitRoutingPreference = (TransitRoutingPreference) TransitRoutingPreferenceComboBox.SelectedValue,
                DepartureTime = SpecifyTimesCheckBox.Checked ? (DepartureTimeRadioButton.Checked ? (DateTime?)departureTime : null) : null,
                ArrivalTime = SpecifyTimesCheckBox.Checked ? (ArrivalTimeRadioButton.Checked ? (DateTime?)arrivalTime : null) : null
            };
            RequestRichTextBox.Text = request.RequestString;
            ApiResponse response;
            Cursor = Cursors.WaitCursor;
            GetDistanceMatrixButton.Enabled = false;
            try
            {
                response = await request.GetDistanceMatrixAsync();
            }
            catch (Exception ex)
            {
                DialogResult userResponse = MessageBox.Show(
                    "An error occurred while attempting to call the Google Maps Distance Matrix API:" +
                    Environment.NewLine + Environment.NewLine +
                    "Type: " + ex.GetType().Name + Environment.NewLine +
                    "Message: " + ex.Message,
                    "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (userResponse == DialogResult.Retry)
                {
                    GetDistanceMatrixButton_Click(sender, e);
                }
                return;
            }
            finally
            {
                GetDistanceMatrixButton.Enabled = true;
                Cursor = Cursors.Default;
            }
            ResponseRichTextBox.Text = response.ResponseJson;
            if (response.ErrorMessage != null)
            {
                MessageBox.Show(
                    "The result contained an error message:" + Environment.NewLine + Environment.NewLine +
                    response.ErrorMessage,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (response.Elements.Length == 0)
            {
                MessageBox.Show(
                    "The response contained no results." + Environment.NewLine + Environment.NewLine +
                    "Response Status: " + response.Status,
                    "No Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            using (ResponseView responseView = new ResponseView(response))
            {
                responseView.ShowDialog();
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutForm aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog();
            }
        }

        private void SpecifyTimesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = SpecifyTimesCheckBox.CheckState != CheckState.Unchecked;
            foreach (Control c in SpecifyTimesGroupBox.Controls)
            {
                c.Enabled = enabled;
            }
        }
    }

    public class AddressString
    {
        public AddressString(string address)
        {
            Address = address;
        }
        public string Address { get; }
    }
}
