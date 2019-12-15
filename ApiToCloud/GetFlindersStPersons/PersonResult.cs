
using System;

namespace ApiToCloud.GetFlindersStPersons
{
    public class PersonResult {
        public DateTime date { get; set; }
        public DateTime time { get; set; }
        public DateTime date_time { get; set; }
        public string sensor_id { get; set; }
        public int direction_1 { get; set; }
        public int direction_2 { get; set; }
        public int total_of_directions { get; set; }

    }
}