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
    public class DeleteModel : PageModel
    {
        private readonly MobileHub.Data.MobileHubContext _context;

        public DeleteModel(MobileHub.Data.MobileHubContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Mobile = await _context.Mobile.FindAsync(id);

            if (Mobile != null)
            {
                _context.Mobile.Remove(Mobile);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
