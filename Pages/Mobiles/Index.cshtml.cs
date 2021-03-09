using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MobileHub.Data;
using MobileHub.Models;

namespace MobileHub.Pages.Mobiles
{
    public class IndexModel : PageModel
    {
        private readonly MobileHub.Data.MobileHubContext _context;

        public IndexModel(MobileHub.Data.MobileHubContext context)
        {
            _context = context;
        }

        public IList<Mobile> Mobile { get;set; }

        public async Task OnGetAsync()
        {
            Mobile = await _context.Mobile.ToListAsync();
        }
    }
}
