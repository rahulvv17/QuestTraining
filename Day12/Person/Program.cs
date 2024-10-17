using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new people();
            p1.Name = "Mr X";
            p1.Email = "jocj@dkmc.com";
            var address = new List<Address>
            {
                new Address { AddressType = "Home", AddressLine1 = "kochi", AddressLine2 = " Kerala", PinCode = 65562 },
                 new Address { AddressType = "work", AddressLine1 = "kannur", AddressLine2 = " Kerala", PinCode = 65552 },
            };
            p1.Addresss = address;

        }
    }
}