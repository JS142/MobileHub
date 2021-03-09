using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MobileHub.Models;

namespace MobileHub.Data
{
    public class MobileHubContext : DbContext
    {
        public MobileHubContext (DbContextOptions<MobileHubContext> options)
            : base(options)
        {
        }

        public DbSet<MobileHub.Models.User> User { get; set; }

        public DbSet<MobileHub.Models.Mobile> Mobile { get; set; }

        public DbSet<MobileHub.Models.Order> Order { get; set; }
    }
}
