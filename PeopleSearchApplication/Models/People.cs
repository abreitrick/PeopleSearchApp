using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleSearchApplication.Models
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Age { get; set; }
        public string Interests { get; set; }
        public object Image { get; set; }
    }
}