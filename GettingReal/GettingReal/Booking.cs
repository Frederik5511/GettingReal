using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GettingReal
{
    public class Booking
    {
        public DateTime DateTime { get; private set; }
        public int Guests { get; private set; }
        public string Occasion { get; private set; }
        public int BookingId { get; private set; }
        public Guest Guest { get; private set; }
        public Employee Employee { get; private set; }
        public Bar Bar { get; private set; }

        public Booking(Employee employee, Guest guest, Bar bar, DateTime dateTime, int guests, string occasion, int bookingId)
        {
            Employee = employee;
            Guest = guest;
            Bar = bar;
            DateTime = dateTime;
            Guests = guests;
            Occasion = occasion;
            BookingId = bookingId;
        }
        public void UpdateBooking(DateTime dateTime, int guests)
        {
            DateTime = dateTime;
            Guests = guests;
        }
    }
}