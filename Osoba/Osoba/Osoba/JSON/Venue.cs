using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Osoba.JSON
{
    public class Venue
    {
        public int Id { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
    }

    public class PersonSerializer
    {
        public string Serialize(Venue venue)
        {
            return JsonConvert.SerializeObject(venue);
        }

        public Venue Deserialize(String text)
        {
            return JsonConvert.DeserializeObject<Venue>(text); 
        }
    }
}
