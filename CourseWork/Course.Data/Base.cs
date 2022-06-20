using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Course.Data
{
    public class Base<T> where T : Base<T>
    {
        public static Dictionary<Guid, T> Items = new Dictionary<Guid, T>();

        public string name;

        public Guid Id { get; set; }

        [JsonConstructor]
        public Base() 
        {
            //Items.Add(this.Id, (T)this);
        }

        public Base(int i)
        {
            Id = Guid.NewGuid();
            Items.Add(Id, (T)this);
        }

        public static void Serialiaze(string k)
        {
            string str = JsonConvert.SerializeObject(Items);
            File.WriteAllText($@"E:\кпи топ\курсач\code\Course\Course.Data\json\{k}.json", str);
        }

        
    }
}
