using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Course.Data
{
    public class Flight : Base<Flight>
    {
        [JsonConstructor]
        public Flight() : base() { }
        public Flight(int i) : base(i) { }

        public DateTime departureDate, arrivalDate;
        public string departureTime, arrivalTime;
        public int seats, price;

        public Guid _voyageId;
        public Guid _pilotId;
        [JsonIgnore]
        public Voyage Voyage
        {
            get { return Voyage.Items[_voyageId]; }
            set { _voyageId = value.Id; }
        }
        [JsonIgnore]
        public Pilot Pilot
        {
            get { return Pilot.Items[_pilotId]; }
            set { _pilotId = value.Id; }
        }

        public override string ToString()
        {
            return name /*+ " (" + Voyage.name + ", " + departureTime + " -> " + arrivalTime + ", " + Pilot.name + ")"*/;
        }
    }
}
