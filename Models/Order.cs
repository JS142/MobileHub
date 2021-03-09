using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileHub.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }


        public int MobileID { get; set; }
        public Mobile Mobile { get; set; }

        public DateTime OrderDate { get; set; }
       
    }
}
