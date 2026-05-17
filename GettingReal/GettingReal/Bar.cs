using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GettingReal
{
    public class Bar
    {
        public string Name { get; private set; }
        public int Capacity { get; private set; }

        public Bar(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
    }
    
}
