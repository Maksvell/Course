using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;

namespace Course.Data
{
    public class City : Base<City>
    {
        [JsonConstructor]
        public City() : base() {
            //Items.Add(this.Id, this);
        }
        public City(int i) : base(i) { }
        [JsonIgnore]
        public List<Voyage> ComingVoyages
        {
            get { return Voyage.Items.Values.Where(cv => cv.FinalCity == this).ToList(); }
        }
        
        [JsonIgnore]
        public List<Voyage> OutgoingVoyages
        {
            get { return Voyage.Items.Values.Where(ov => ov.StartCity == this).ToList(); }
        }
        
        public override string ToString()
        {
            return name;
        }
    }
}
