using System;
using System.Collections.Generic;
using System.Text;

namespace GettingReal
{
    public class Guest
    {
        public string Phone { get; private set; }
        public string Name { get; private set; }

        public Guest(string name, string phone)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Navn må ikke være tomt");
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                throw new ArgumentException("Telefon nummer må ikke være tomt");
            }
            Name = name;
            Phone = phone;
        }
    }
}
