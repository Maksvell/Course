using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Course.Data
{
    public class Pilot : Base<Pilot>
    {
        [JsonConstructor]
        public Pilot() : base() { }
        public Pilot(int i) : base(i) { }
        public Guid _flightId;
        [JsonIgnore]
        public Flight Flight
        {
            get { return Flight.Items[_flightId]; }
            set { _flightId = value.Id; }
        }

        public override string ToString()
        {
            return name;
        }

    }
}
