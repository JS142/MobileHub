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
    public class DetailsModel : PageModel
    {
        private readonly MobileHub.Data.MobileHubContext _context;

        public DetailsModel(MobileHub.Data.MobileHubContext context)
        {
            _context = context;
        }

        public Mobile Mobile { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Mobile = await _context.Mobile.FirstOrDefaultAsync(m => m.ID == id);

            if (Mobile == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
