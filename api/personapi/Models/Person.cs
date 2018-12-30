using System;
using System.Collections.Generic;
using personapi.Models;

namespace personapi
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? StateId { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }

        public virtual States State { get; set; }
    }
}
