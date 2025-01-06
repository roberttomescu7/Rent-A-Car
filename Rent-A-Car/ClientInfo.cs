using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car
{
    public class ClientInfo
    {
        public string firstName;
        public string lastName;
        public string CNP;
        public string? street;
        public string? number;
        public string? city;
        public string? county;
        
        public ClientInfo(string firstName, string lastName, string CNP, string street, string number, string city, string county) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.CNP = CNP;
            this.street = street;
            this.number = number;
            this.city = city;
            this.county = county;
        }
    }
}
