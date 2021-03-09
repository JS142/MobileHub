using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MobileHub.Data;
using MobileHub.Models;

namespace MobileHub.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly MobileHub.Data.MobileHubContext _context;

        public IndexModel(MobileHub.Data.MobileHubContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order
                .Include(o => o.Mobile)
                .Include(o => o.User).ToListAsync();
        }
    }
}
