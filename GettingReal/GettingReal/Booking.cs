using System;
using System.Collections.Generic;
using System.Text;

namespace GettingReal
{
    public class Booking
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime DateTime { get; set; }
        public int Guests { get; set; }
        public string Occasion { get; set; }

        public Booking(string name, string phone, DateTime dateTime, int guests, string occasion)
        {
            Name = name;
            Phone = phone;
            DateTime = dateTime;
            Guests = guests;
            Occasion = occasion;
        }
    }
}