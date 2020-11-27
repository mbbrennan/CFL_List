using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie2.Data;
using RazorPagesMovie2.Models;

namespace RazorPagesMovie2.Pages.Standings
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMovie2.Data.RazorPagesMovie2Context _context;

        public DeleteModel(RazorPagesMovie2.Data.RazorPagesMovie2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Standing Standing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Standing = await _context.Standing.FirstOrDefaultAsync(m => m.ID == id);

            if (Standing == null)
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

            Standing = await _context.Standing.FindAsync(id);

            if (Standing != null)
            {
                _context.Standing.Remove(Standing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
