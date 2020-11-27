using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie2.Data;
using RazorPagesMovie2.Models;

namespace RazorPagesMovie2.Pages
{
    public class StandingsModel : PageModel
    {
        private readonly RazorPagesMovie2.Data.RazorPagesMovie2Context _context;

        public StandingsModel(RazorPagesMovie2.Data.RazorPagesMovie2Context context)
        {
            _context = context;
        }

        public IList<Standing> Standing { get;set; }

        public async Task OnGetAsync()
        {
            Standing = await _context.Standing.ToListAsync();
        }
    }
}
