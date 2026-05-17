using System;
using System.Collections.Generic;
using System.Text;

namespace GettingReal
{
    internal class BookingService
    {
        private BookingRepository _repository = new BookingRepository();
        
        
        public Booking CreateBooking(Employee employee, Guest guest, Bar bar, DateTime dateTime, int guests, string occasion)
        {
            int highestId = 0;
            foreach (Booking existingBooking in _repository.GetAll())
            {
                if(existingBooking.BookingId > highestId)
                {
                    highestId = existingBooking.BookingId;
                }
            }
            int bookingId = highestId + 1;
            if (guests <= 0)
            {
                throw new ArgumentException("Antal gæster skal være større end 0");
            }
            if (dateTime < DateTime.Now)
            {
                throw new InvalidOperationException("Du kan ikke oprette en booking som er i fortiden");
            }
            var booking = new Booking(employee, guest, bar, dateTime, guests, occasion, bookingId);
            _repository.Add(booking);
            _repository.Save();
            return booking;
        }
        public void DeleteBooking(int bookingId)
        {
            Booking booking = null;
            foreach (Booking existingBooking in _repository.GetAll())
            {
                if (existingBooking.BookingId == bookingId)
                {
                    booking = existingBooking;
                }
            }
            if (booking == null)
            {
                throw new InvalidOperationException("Booking ID findes ikke");
            }
            _repository.Remove(booking);
            _repository.Save();
        }
        public void EditBooking(int bookingId, DateTime dateTime, int guests)
        {
            Booking booking = null;
            foreach (Booking existingBooking in _repository.GetAll())
            {
                if (existingBooking.BookingId == bookingId)
                {
                    booking = existingBooking;
                }
            }
            if (booking == null)
            {
                throw new InvalidOperationException("Booking ID findes ikke");
            }
            if (guests <= 0)
            {
                throw new ArgumentException("Antal gæster skal være større end 0");
            }
            if (dateTime < DateTime.Now)
            {
                throw new InvalidOperationException("Du kan ikke ændre booking til en dato i fortiden");
            }
            booking.UpdateBooking(dateTime, guests);
            _repository.Save();
        }
        public List<Booking> GetBookings()
        {
            return _repository.GetAll();
        }
    }
}
