using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileHub.Models
{
    public class Mobile
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Brand { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public string Rating { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
