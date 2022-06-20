using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Course.Data;

namespace Course
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            StartCityList.DataSource = City.Items.Values.ToList();
            FinalCityList.DataSource = City.Items.Values.ToList();
            RefreshVoyageList();
        }

        private void RefreshVoyageList()
        {
            VoyageList.DataSource = null;
            ZeroVoyage.Visible = true;
            if (StartCityList.SelectedItem != null && FinalCityList.SelectedItem != null)
                VoyageList.DataSource = Voyage.Items.Values.Where(vl => 
                    vl.StartCity == StartCityList.SelectedItem &&
                    vl.FinalCity == FinalCityList.SelectedItem).ToList();
            if (Voyage.Items.Values.Where(vl =>
                vl.StartCity == StartCityList.SelectedItem &&
                vl.FinalCity == FinalCityList.SelectedItem).ToList().Count() != 0)
                ZeroVoyage.Visible = false;
        }
        private void RefreshFlightList()
        {
            FlightList.DataSource = null;
            ZeroFlight.Visible = true;
            if (VoyageList.SelectedItem != null)
                FlightList.DataSource = Flight.Items.Values.Where(fl =>
                    fl.Voyage == VoyageList.SelectedItem).ToList();
            if (Flight.Items.Values.Where(fl => fl.Voyage == VoyageList.SelectedItem).ToList().Count() != 0)
                ZeroFlight.Visible = false;
        }
        private void RefreshInformation()
        {
            DepartureTime.Text = null;
            ArrivalTime.Text = null;
            Seats.Text = "0";
            Price.Text = "0";
            Pilot.Text = "_";
            TbCompany.Text = "_";
            if (FlightList.SelectedItem != null)
            {
                DepartureDate.Value = ((Flight)FlightList.SelectedItem).departureDate;
                DepartureTime.Text = ((Flight)FlightList.SelectedItem).departureTime;
                ArrivalDate.Value = ((Flight)FlightList.SelectedItem).arrivalDate;
                ArrivalTime.Text = ((Flight)FlightList.SelectedItem).arrivalTime;
                Seats.Text = ((Flight)FlightList.SelectedItem).seats.ToString();
                Price.Text = ((Flight)FlightList.SelectedItem).price.ToString() + "$";
                Pilot.Text = ((Flight)FlightList.SelectedItem).Pilot.ToString();
                TbCompany.Text = ((Flight)FlightList.SelectedItem).Voyage.company;
            }
        }

        private void FinalCityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshVoyageList();
        }
        private void StartCityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshVoyageList();
        }
        private void VoyageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFlightList();
        }
        private void FlightList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshInformation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ready");
        }
    }
}
