using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Course.Data;
using System.Linq;

namespace Course
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefreshVoyageList();
            RefreshCityLists();
            StartCityBox.DataSource = City.Items.Values.ToList();
            FinalCityBox.DataSource = City.Items.Values.ToList();
            //PilotBox.DataSource = Pilot.Items.Values.ToList();
            VoyageBox.DataSource = Voyage.Items.Values.ToList();
            RefreshInformation();
        }
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            City.Serialiaze("city");
            Voyage.Serialiaze("voyage");
            Flight.Serialiaze("flight");
            Pilot.Serialiaze("pilot");
        }


        private void RefreshCityLists()
        {
            StartCityList.DataSource = null;
            FinalCityList.DataSource = null;
            StartCityList.DataSource = City.Items.Values.ToList();
            FinalCityList.DataSource = City.Items.Values.ToList();
            FinalCityBox.DataSource = City.Items.Values.ToList();
            StartCityBox.DataSource = City.Items.Values.ToList();
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
            if (VoyageList.SelectedItem != null)
            {
                VoyageBox.DataSource = Voyage.Items.Values.ToList();
                VoyageBox.SelectedItem = VoyageList.SelectedItem;
            }
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
            RefreshInformation();
        }
        private void RefreshInformation()
        {
            TbDepartureTime.Text = null;
            TbArrivalTime.Text = null;
            TbSeats.Text = "0";
            TbPrice.Text = "0";
            /*Pilot.Text = "_";*/
            if (FlightList.SelectedItem != null)
            {
                DepartureDate.Value = ((Flight)FlightList.SelectedItem).departureDate;
                TbDepartureTime.Text = ((Flight)FlightList.SelectedItem).departureTime;
                ArrivalDate.Value = ((Flight)FlightList.SelectedItem).arrivalDate;
                TbArrivalTime.Text = ((Flight)FlightList.SelectedItem).arrivalTime;
                TbSeats.Text = ((Flight)FlightList.SelectedItem).seats.ToString();
                TbPrice.Text = ((Flight)FlightList.SelectedItem).price.ToString();
                TbFlightName.Text = ((Flight)FlightList.SelectedItem).name;
                TbPilot.Text = ((Flight)FlightList.SelectedItem).Pilot.name;
                VoyageBox.SelectedItem = ((Flight)FlightList.SelectedItem).Voyage;
            }
        }


        private void FinalCityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshVoyageList();
            FinalCityBox.SelectedItem = (City)FinalCityList.SelectedItem;
        }
        private void StartCityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshVoyageList();
            if(StartCityList.SelectedItem != null)
                TbCityName.Text = ((City)StartCityList.SelectedItem).name;
            StartCityBox.SelectedItem = (City)StartCityList.SelectedItem;
        }
        private void VoyageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFlightList();
            if (VoyageList.SelectedItem != null)
            {
                TbVoyageName.Text = ((Voyage)VoyageList.SelectedItem).name;
                StartCityBox.SelectedItem = ((Voyage)VoyageList.SelectedItem).StartCity;
                FinalCityBox.SelectedItem = ((Voyage)VoyageList.SelectedItem).FinalCity;
                TbVoyageCompany.Text = ((Voyage)VoyageList.SelectedItem).company;
            }
            
        }
        private void FlightList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshInformation();       
        }

        

        private void AddCityBtn_Click(object sender, EventArgs e)
        {
            if (TbCityName.Text == "") MessageBox.Show("Input all info");
            else new City(1) { name = TbCityName.Text };
            RefreshCityLists();
        }
        private void EditCityBtn_Click(object sender, EventArgs e)
        {
            if (StartCityList.SelectedItem != null)
                if (TbCityName.Text == "") MessageBox.Show("Input all info");
                else ((City)StartCityList.SelectedItem).name = TbCityName.Text;
            RefreshCityLists();
        }
        private void RemoveCityBtn_Click(object sender, EventArgs e)
        {
            if (StartCityList.SelectedItem != null)
            {
                RemoveCity((City)StartCityList.SelectedItem);
            }
            RefreshCityLists();
        }
        private void RemoveCity(City c)
        {
            foreach (Voyage v in c.OutgoingVoyages)
                RemoveVoyage(v);
            City.Items.Remove(c.Id);
        }


        private void AddVoyageBtn_Click(object sender, EventArgs e)
        {
            if (TbVoyageName.Text == "" || TbVoyageCompany.Text == "") MessageBox.Show("Input all info");
            new Voyage(1) { name = TbVoyageName.Text,
                StartCity = (City)StartCityBox.SelectedItem,
                FinalCity = (City)FinalCityBox.SelectedItem,
                company = TbVoyageCompany.Text
            };
            RefreshVoyageList();
        }
        private void EditVoyageBtn_Click(object sender, EventArgs e)
        {
            if (VoyageList.SelectedItem != null || TbVoyageName.Text == "" || TbVoyageCompany.Text == "")
            {
                ((Voyage)VoyageList.SelectedItem).name = TbVoyageName.Text;
                ((Voyage)VoyageList.SelectedItem).StartCity = (City)StartCityBox.SelectedItem;
                ((Voyage)VoyageList.SelectedItem).FinalCity = (City)FinalCityBox.SelectedItem;
                ((Voyage)VoyageList.SelectedItem).company = TbVoyageCompany.Text;
            }
            RefreshVoyageList();
        }
        private void RemoveVoyageBtn_Click(object sender, EventArgs e)
        {
            if (VoyageList.SelectedItem != null)
                RemoveVoyage((Voyage)VoyageList.SelectedItem);
            RefreshVoyageList();
        }
        private void RemoveVoyage(Voyage v)
        {
            foreach (Flight f in v.Flights)
                RemoveFlight(f);
            Voyage.Items.Remove(v.Id);

        }

       
        private void AddFlightBtn_Click(object sender, EventArgs e)
        {
            if (TbFlightName.Text == "" || ArrivalDate.Text == "" || DepartureDate == null ||
                TbArrivalTime == null || TbDepartureTime.Text == "" || TbSeats.Text == "" || TbPrice.Text == "")
            {
                MessageBox.Show("Input all info");
                return;
            }
            var tmp = new Flight(1)
            {
                name = TbFlightName.Text,
                arrivalDate = ArrivalDate.Value,
                departureDate = DepartureDate.Value,
                arrivalTime = TbArrivalTime.Text,
                departureTime = TbDepartureTime.Text,
                seats = Convert.ToInt32(TbSeats.Text),
                price = Convert.ToInt32(TbPrice.Text),
                Voyage = (Voyage)VoyageBox.SelectedItem,
            };
            tmp.Pilot = new Pilot(1) { name = TbPilot.Text, Flight = tmp };
            RefreshFlightList();
            
        }
        private void EditFlightBtn_Click(object sender, EventArgs e)
        {
            if (TbFlightName == null || ArrivalDate == null || DepartureDate == null ||
                TbArrivalTime == null || TbDepartureTime == null || TbSeats == null || TbPrice == null)
            {
                MessageBox.Show("Input all info");
                return;
            }
            if (FlightList.SelectedItem != null)
            {
                ((Flight)FlightList.SelectedItem).name = TbFlightName.Text;
                ((Flight)FlightList.SelectedItem).arrivalDate = ArrivalDate.Value;
                ((Flight)FlightList.SelectedItem).departureDate = DepartureDate.Value;
                ((Flight)FlightList.SelectedItem).arrivalTime = TbArrivalTime.Text;
                ((Flight)FlightList.SelectedItem).departureTime = TbDepartureTime.Text;
                ((Flight)FlightList.SelectedItem).seats = Convert.ToInt32(TbSeats.Text);
                ((Flight)FlightList.SelectedItem).price = Convert.ToInt32(TbPrice.Text);
                ((Flight)FlightList.SelectedItem).Pilot.name = TbPilot.Text;
                ((Flight)FlightList.SelectedItem).Voyage = (Voyage)VoyageBox.SelectedItem;
            }
            RefreshFlightList();
        }
        private void RemoveFlightBtn_Click(object sender, EventArgs e)
        {
            if(FlightList.SelectedItem != null)
            {
                RemoveFlight((Flight)FlightList.SelectedItem);
            }
            RefreshFlightList();
        }
        private void RemoveFlight(Flight f)
        {
            Pilot.Items.Remove(f.Pilot.Id);
            Flight.Items.Remove(f.Id);
        }

        
    }
}
