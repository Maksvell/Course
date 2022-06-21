using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Course.Data;
using Newtonsoft.Json;
using System.IO;

namespace Course
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

            string jsonCity = File.ReadAllText(@"E:\кпи топ\курсач\course\Course\CourseWork\Course.Data\json\city.json");
            City.Items = JsonConvert.DeserializeObject<Dictionary<Guid, City>>(jsonCity);
            string jsonVoyage = File.ReadAllText(@"E:\кпи топ\курсач\course\Course\CourseWork\Course.Data\json\voyage.json");
            Voyage.Items = JsonConvert.DeserializeObject<Dictionary<Guid, Voyage>>(jsonVoyage);
            string jsonFlight = File.ReadAllText(@"E:\кпи топ\курсач\course\Course\CourseWork\Course.Data\json\flight.json");
            Flight.Items = JsonConvert.DeserializeObject<Dictionary<Guid, Flight>>(jsonFlight);
            string jsonPilot = File.ReadAllText(@"E:\кпи топ\курсач\course\Course\CourseWork\Course.Data\json\pilot.json");
            Pilot.Items = JsonConvert.DeserializeObject<Dictionary<Guid, Pilot>>(jsonPilot);



            /* var city1 = new City(1) { name = "Berlin" };
             var city2 = new City(1) { name = "Kiyv" };
             var city3 = new City(1) { name = "London" };
             var voyage1 = new Voyage(1) { name = "Tour1", StartCity = city1, FinalCity = city2 };
             var voyage2 = new Voyage(1) { name = "Tour2", StartCity = city2, FinalCity = city3 };
             var voyage3 = new Voyage(1) { name = "Tour3", StartCity = city3, FinalCity = city1 };
             var flight1 = new Flight(1) { name = "AR121", departureTime = "3.00", arrivalTime = "4.00", arrivalDate = new DateTime(2022, 06, 22), departureDate = new DateTime(2022, 06, 22), Voyage = voyage1, seats = 100, price = 200 };
             var flight2 = new Flight(1) { name = "BC327", departureTime = "1.00", arrivalTime = "5.00", arrivalDate = new DateTime(2022, 06, 22), departureDate = new DateTime(2022, 06, 22), Voyage = voyage2, seats = 120, price = 300 };
             var flight3 = new Flight(1) { name = "KT731", departureTime = "2.00", arrivalTime = "7.00", arrivalDate = new DateTime(2022, 06, 22), departureDate = new DateTime(2022, 06, 22), Voyage = voyage3, seats = 60, price = 170 };
             var flight4 = new Flight(1) { name = "LE879", departureTime = "6.00", arrivalTime = "8.00", arrivalDate = new DateTime(2022, 06, 23), departureDate = new DateTime(2022, 06, 23), Voyage = voyage1, seats = 210, price = 80 };
             var pilot1 = new Pilot(1) { name = "Ondre", Flight = flight1 };
             var pilot2 = new Pilot(1) { name = "Katya", Flight = flight2 };
             var pilot3 = new Pilot(1) { name = "Misha", Flight = flight3 };
             var pilot4 = new Pilot(1) { name = "Sashko", Flight = flight4 };
             flight1.Pilot = pilot1;
             flight2.Pilot = pilot2;
             flight3.Pilot = pilot3;
             flight4.Pilot = pilot4;*/

            City.Serialiaze("city");
            Voyage.Serialiaze("voyage");
            Flight.Serialiaze("flight");
            Pilot.Serialiaze("pilot");
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            new UserForm().ShowDialog();
        }
        private void AdminBtn_Click(object sender, EventArgs e)
        {
            new AdminForm().ShowDialog();
        }
    }
}
