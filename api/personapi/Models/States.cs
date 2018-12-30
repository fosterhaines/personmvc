using System;
using System.Collections.Generic;

namespace personapi.Models
{
    public partial class States
    {
        public States()
        {
            Person = new HashSet<Person>();
        }

        public int StateId { get; set; }
        public string StateCode { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
