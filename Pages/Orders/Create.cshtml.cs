using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MobileHub.Data;
using MobileHub.Models;

namespace MobileHub.Pages.Orders
{
    public class CreateModel : PageModel
    {
        private readonly MobileHub.Data.MobileHubContext _context;

        public CreateModel(MobileHub.Data.MobileHubContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MobileID"] = new SelectList(_context.Mobile, "ID", "ID");
        ViewData["UserID"] = new SelectList(_context.User, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Order Order { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Order.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
