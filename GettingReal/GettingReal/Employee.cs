using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace GettingReal
{
    public class Employee
    {
        public string EmployeeInitials { get; private set; }

        public Employee(string initials)
        {
            if (string.IsNullOrWhiteSpace(initials))
            {
                throw new ArgumentException("Initialer må ikke være tomt");
            }
            if (initials.Length < 2 || initials.Length > 4)
            {
                throw new ArgumentException("Initialer skal være mellem 2 og 4 bogstaver");
            }
                EmployeeInitials = initials;
        }
    }
}
