using System;
using System.Collections.Generic;
using System.Text;

namespace Serailization
{
    public class Person

    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public class Address
        {
            public int ID { get; set;}
            public string Street { get; set; }
            public string Street { get; set; }

        }

    }
}
