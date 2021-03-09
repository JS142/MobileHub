using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MobileHub.Data;
using MobileHub.Models;

namespace MobileHub.Pages.Mobiles
{
    public class EditModel : PageModel
    {
        private readonly MobileHub.Data.MobileHubContext _context;

        public EditModel(MobileHub.Data.MobileHubContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Mobile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MobileExists(Mobile.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MobileExists(int id)
        {
            return _context.Mobile.Any(e => e.ID == id);
        }
    }
}
