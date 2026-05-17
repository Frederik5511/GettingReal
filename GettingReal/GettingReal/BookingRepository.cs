using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace GettingReal
{
    public class BookingRepository
    {
        private string _filePath = "booking.json";
        private List<Booking> _bookings;

        public BookingRepository()
        {
            _bookings = new List<Booking>();
            Load();
        }

        public void Add(Booking booking)
        {
            _bookings.Add(booking);
        }
        public void Remove(Booking booking)
        {
            _bookings.Remove(booking);
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(_bookings);

            File.WriteAllText(_filePath, json);
        }

        public void Load()
        {
            if (!File.Exists(_filePath))
            {
                _bookings = new List<Booking>();
                return;
            }

            string json = File.ReadAllText(_filePath);

            _bookings = JsonSerializer.Deserialize<List<Booking>>(json)
                    ?? new List<Booking>();
        }

        public List<Booking> GetAll()
        {
            return _bookings;
        }
    }
}
