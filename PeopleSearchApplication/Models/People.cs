using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace PeopleSearchApplication.Models
{
    public class People
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Age { get; set; }
        public string Interests { get; set; }
        public byte[] Image { get; set; }

        public People(int id, string firstName, string lastName, string streetAddress, string city, string state, string zip, int age, string interests, byte[] image)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StreetAddress = streetAddress;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Age = age;
            this.Interests = interests;
            this.Image = image;
        }

        public People()
        {
        }
    }
}