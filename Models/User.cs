using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileHub.Models
{
    public class User
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int Mobile { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
