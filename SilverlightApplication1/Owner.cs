using System;
using System.ComponentModel;

namespace SilverlightBanking
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CustomerSince { get; set; }
        public Uri ImageName { get; set; }
        public DateTime LastActivityDate { get; set; }
        public double CurrentBalance { get; set; }
        public double LastActivityAmount { get; set; }
    }
}