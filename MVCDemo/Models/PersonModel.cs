using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; } = 0;

        public DateTime BirthDay { get; set; }

        public bool IsAlive { get; set; } = true;
    }
}