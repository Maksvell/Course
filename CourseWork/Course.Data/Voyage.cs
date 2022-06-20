using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;

namespace Course.Data
{
    public class Voyage : Base<Voyage>
    {
        [JsonConstructor]
        public Voyage() : base() { }
        public Voyage(int i) : base(i) { }

        public string company;

        public Guid _startCityId;
        public Guid _finalCityId;
        [JsonIgnore]
        public City StartCity
        {
            get { return City.Items[_startCityId]; }
            set { _startCityId = value.Id; }
        }
        [JsonIgnore]
        public City FinalCity
        {
            get { return City.Items[_finalCityId]; }
            set { _finalCityId = value.Id; }
        }
        [JsonIgnore]
        public List<Flight> Flights
        {
            get { return Flight.Items.Values.Where(lf => lf.Voyage == this).ToList(); }
        }
        /*public List<Guid> FlightsId
        {
            get 
            {
                return Flight.Items.Keys.Where(lf => Flight.Items[lf]._voyageId == this.Id).ToList();
            }
        }*/

        public override string ToString()
        {
            return name /*+ " (" + StartCity.name + " -> " + FinalCity.name + ")"*/;
        }
    }
}
